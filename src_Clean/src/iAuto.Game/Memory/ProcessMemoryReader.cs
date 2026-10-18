using System;
using System.Text;
using iAuto.Native;

namespace iAuto.Game.Memory
{
    /// <summary>
    /// Đọc bộ nhớ an toàn từ tiến trình Game.exe thông qua Win32 ReadProcessMemory.
    /// Hỗ trợ giải mã chuỗi con trỏ đa cấp (Multi-level Pointer Dereferencing).
    /// Chuẩn hóa từ Class515.cs
    /// </summary>
    public class ProcessMemoryReader : IDisposable
    {
        private readonly IntPtr _processHandle;
        private readonly bool _is64Bit;

        public IntPtr ProcessHandle
        {
            get { return _processHandle; }
        }

        public ProcessMemoryReader(IntPtr processHandle, bool is64Bit)
        {
            _processHandle = processHandle;
            _is64Bit = is64Bit;
        }

        public ProcessMemoryReader(int processId)
        {
            _processHandle = NativeMethods.OpenProcess(NativeMethods.PROCESS_ALL_ACCESS, false, processId);
            if (_processHandle == IntPtr.Zero)
            {
                throw new InvalidOperationException(string.Format("Không thể mở tiến trình PID {0}", processId));
            }

            bool wow64;
            if (NativeMethods.IsWow64Process(_processHandle, out wow64))
            {
                _is64Bit = !wow64;
            }
            else
            {
                _is64Bit = false;
            }
        }

        #region Đọc dữ liệu nguyên thủy

        /// <summary>
        /// Đọc một mảng byte từ địa chỉ bộ nhớ chỉ định.
        /// </summary>
        public byte[] ReadBytes(long address, int length)
        {
            if (_processHandle == IntPtr.Zero || address == 0 || length <= 0)
            {
                return new byte[0];
            }

            byte[] buffer = new byte[length];
            UIntPtr bytesRead;
            if (NativeMethods.ReadProcessMemory(_processHandle, new IntPtr(address), buffer, (uint)length, out bytesRead))
            {
                return buffer;
            }

            return new byte[0];
        }

        /// <summary>
        /// Đọc giá trị 1 byte từ địa chỉ.
        /// </summary>
        public byte ReadByte(long address)
        {
            byte[] bytes = ReadBytes(address, 1);
            return bytes.Length > 0 ? bytes[0] : (byte)0;
        }

        /// <summary>
        /// Đọc số nguyên 32-bit (int).
        /// </summary>
        public int ReadInt32(long address)
        {
            byte[] bytes = ReadBytes(address, 4);
            return bytes.Length >= 4 ? BitConverter.ToInt32(bytes, 0) : 0;
        }

        /// <summary>
        /// Đọc số nguyên 64-bit (long).
        /// </summary>
        public long ReadInt64(long address)
        {
            byte[] bytes = ReadBytes(address, 8);
            return bytes.Length >= 8 ? BitConverter.ToInt64(bytes, 0) : 0;
        }

        /// <summary>
        /// Đọc số thực dấu phẩy động 32-bit (float).
        /// </summary>
        public float ReadFloat(long address)
        {
            byte[] bytes = ReadBytes(address, 4);
            return bytes.Length >= 4 ? BitConverter.ToSingle(bytes, 0) : 0f;
        }

        /// <summary>
        /// Đọc giá trị con trỏ (4 byte nếu là x86, 8 byte nếu là x64).
        /// </summary>
        public long ReadPointer(long address)
        {
            if (!_is64Bit)
            {
                byte[] bytes = ReadBytes(address, 4);
                return bytes.Length >= 4 ? (long)BitConverter.ToUInt32(bytes, 0) : 0L;
            }
            else
            {
                return ReadInt64(address);
            }
        }

        /// <summary>
        /// Đọc chuỗi ký tự kết thúc bằng null.
        /// </summary>
        public string ReadString(long address, int maxLength, Encoding encoding)
        {
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }

            byte[] bytes = ReadBytes(address, maxLength);
            if (bytes.Length == 0)
            {
                return string.Empty;
            }

            int nullIndex = Array.IndexOf(bytes, (byte)0);
            if (nullIndex == 0)
            {
                return string.Empty;
            }

            int count = nullIndex > 0 ? nullIndex : bytes.Length;
            return encoding.GetString(bytes, 0, count).Trim();
        }

        #endregion

        #region Giải mã con trỏ đa cấp (Pointer Chain)

        /// <summary>
        /// Giải mã chuỗi con trỏ đa cấp: baseAddress -> [offset1] -> [offset2] -> ...
        /// </summary>
        public long ResolvePointer(long baseAddress, params long[] offsets)
        {
            if (baseAddress == 0)
            {
                return 0;
            }

            long current = ReadPointer(baseAddress);
            if (offsets == null || offsets.Length == 0)
            {
                return current;
            }

            for (int i = 0; i < offsets.Length; i++)
            {
                if (current == 0)
                {
                    return 0;
                }

                if (i == offsets.Length - 1)
                {
                    return current + offsets[i];
                }

                current = ReadPointer(current + offsets[i]);
            }

            return current;
        }

        /// <summary>
        /// Đọc số nguyên int qua chuỗi con trỏ đa cấp.
        /// </summary>
        public int ReadInt32Chain(long baseAddress, params long[] offsets)
        {
            long targetAddress = ResolvePointer(baseAddress, offsets);
            return targetAddress != 0 ? ReadInt32(targetAddress) : 0;
        }

        /// <summary>
        /// Đọc float qua chuỗi con trỏ đa cấp.
        /// </summary>
        public float ReadFloatChain(long baseAddress, params long[] offsets)
        {
            long targetAddress = ResolvePointer(baseAddress, offsets);
            return targetAddress != 0 ? ReadFloat(targetAddress) : 0f;
        }

        /// <summary>
        /// Đọc chuỗi qua chuỗi con trỏ đa cấp.
        /// </summary>
        public string ReadStringChain(long baseAddress, int maxLength, params long[] offsets)
        {
            long targetAddress = ResolvePointer(baseAddress, offsets);
            return targetAddress != 0 ? ReadString(targetAddress, maxLength, Encoding.Default) : string.Empty;
        }

        #endregion

        public void Dispose()
        {
            if (_processHandle != IntPtr.Zero)
            {
                NativeMethods.CloseHandle(_processHandle);
            }
        }
    }
}
