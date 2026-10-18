using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace iAuto.Native
{
    /// <summary>
    /// Tiêm thư viện DLL 32-bit (x86) vào tiến trình WOW64 từ ứng dụng chủ 64-bit (x64).
    /// Chuẩn hóa từ Class104.cs
    /// </summary>
    public static class Wow64Injector
    {
        /// <summary>
        /// Tiêm một DLL vào tiến trình đích thông qua CreateRemoteThread(LoadLibraryA).
        /// </summary>
        /// <param name="processId">ID tiến trình đích (Game.exe)</param>
        /// <param name="dllPath">Đường dẫn đầy đủ tới DLL 32-bit</param>
        /// <returns>Địa chỉ Base Address của DLL đã tiêm trong tiến trình đích</returns>
        public static IntPtr InjectDll(int processId, string dllPath)
        {
            if (!File.Exists(dllPath))
            {
                throw new FileNotFoundException("Không tìm thấy file DLL cần tiêm.", dllPath);
            }

            IntPtr hProcess = NativeMethods.OpenProcess(NativeMethods.PROCESS_ALL_ACCESS, false, processId);
            if (hProcess == IntPtr.Zero)
            {
                throw new InvalidOperationException(string.Format("Không thể mở tiến trình PID {0}. Win32Error: {1}", processId, Marshal.GetLastWin32Error()));
            }

            IntPtr remoteMemory = IntPtr.Zero;
            IntPtr hThread = IntPtr.Zero;

            try
            {
                IntPtr loadLibraryAddress = GetRemoteModuleExportAddress(processId, "kernel32.dll", "LoadLibraryA");
                if (loadLibraryAddress == IntPtr.Zero)
                {
                    loadLibraryAddress = GetRemoteModuleExportAddress(processId, "kernelbase.dll", "LoadLibraryA");
                }

                if (loadLibraryAddress == IntPtr.Zero)
                {
                    throw new EntryPointNotFoundException("Không xác định được địa chỉ của hàm LoadLibraryA trong tiến trình x86.");
                }

                byte[] dllPathBytes = Encoding.ASCII.GetBytes(dllPath + "\0");
                remoteMemory = NativeMethods.VirtualAllocEx(
                    hProcess,
                    IntPtr.Zero,
                    (uint)dllPathBytes.Length,
                    NativeMethods.MEM_COMMIT | NativeMethods.MEM_RESERVE,
                    NativeMethods.PAGE_READWRITE);

                if (remoteMemory == IntPtr.Zero)
                {
                    throw new OutOfMemoryException(string.Format("VirtualAllocEx thất bại. Win32Error: {0}", Marshal.GetLastWin32Error()));
                }

                UIntPtr bytesWritten;
                if (!NativeMethods.WriteProcessMemory(hProcess, remoteMemory, dllPathBytes, (uint)dllPathBytes.Length, out bytesWritten)
                    || bytesWritten.ToUInt64() != (ulong)dllPathBytes.Length)
                {
                    throw new IOException(string.Format("WriteProcessMemory thất bại. Win32Error: {0}", Marshal.GetLastWin32Error()));
                }

                uint threadId;
                hThread = NativeMethods.CreateRemoteThread(
                    hProcess,
                    IntPtr.Zero,
                    0,
                    loadLibraryAddress,
                    remoteMemory,
                    0,
                    out threadId);

                if (hThread == IntPtr.Zero)
                {
                    throw new InvalidOperationException(string.Format("CreateRemoteThread thất bại. Win32Error: {0}", Marshal.GetLastWin32Error()));
                }

                if (NativeMethods.WaitForSingleObject(hThread, 10000) != 0)
                {
                    throw new TimeoutException("Hết thời gian chờ tiêm DLL vào tiến trình.");
                }

                uint exitCode;
                if (!NativeMethods.GetExitCodeThread(hThread, out exitCode) || exitCode == 0)
                {
                    throw new InvalidOperationException(string.Format("LoadLibraryA trả về thất bại (ExitCode = 0) cho {0}", dllPath));
                }

                return new IntPtr(exitCode);
            }
            finally
            {
                if (hThread != IntPtr.Zero)
                {
                    NativeMethods.CloseHandle(hThread);
                }

                if (remoteMemory != IntPtr.Zero)
                {
                    NativeMethods.VirtualFreeEx(hProcess, remoteMemory, 0, NativeMethods.MEM_RELEASE);
                }

                NativeMethods.CloseHandle(hProcess);
            }
        }

        /// <summary>
        /// Tìm địa chỉ xuất khẩu (Export Address) của hàm 32-bit trong module của tiến trình đích.
        /// </summary>
        private static IntPtr GetRemoteModuleExportAddress(int processId, string moduleName, string functionName)
        {
            IntPtr hSnapshot = NativeMethods.CreateToolhelp32Snapshot(
                NativeMethods.TH32CS_SNAPMODULE | NativeMethods.TH32CS_SNAPMODULE32,
                (uint)processId);

            if (hSnapshot == IntPtr.Zero || hSnapshot == new IntPtr(-1))
            {
                return IntPtr.Zero;
            }

            try
            {
                NativeMethods.MODULEENTRY32W me = new NativeMethods.MODULEENTRY32W();
                me.dwSize = (uint)Marshal.SizeOf(typeof(NativeMethods.MODULEENTRY32W));

                if (!NativeMethods.Module32FirstW(hSnapshot, ref me))
                {
                    return IntPtr.Zero;
                }

                do
                {
                    if (string.Equals(me.szModule, moduleName, StringComparison.OrdinalIgnoreCase))
                    {
                        uint rva = GetExportRvaFromSysWow64(moduleName, functionName);
                        if (rva == 0)
                        {
                            return IntPtr.Zero;
                        }

                        return new IntPtr(me.modBaseAddr.ToInt64() + rva);
                    }
                } while (NativeMethods.Module32NextW(hSnapshot, ref me));

                return IntPtr.Zero;
            }
            finally
            {
                NativeMethods.CloseHandle(hSnapshot);
            }
        }

        /// <summary>
        /// Phân tích PE header của file DLL 32-bit trong C:\Windows\SysWOW64 để lấy RVA của hàm.
        /// </summary>
        private static uint GetExportRvaFromSysWow64(string dllName, string functionName)
        {
            string sysWow64Dir = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
            string filePath = Path.Combine(sysWow64Dir, dllName);

            if (!File.Exists(filePath))
            {
                return 0;
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (BinaryReader br = new BinaryReader(fs))
            {
                // DOS Header
                if (br.ReadUInt16() != 0x5A4D) return 0; // "MZ"
                fs.Seek(0x3C, SeekOrigin.Begin);
                uint peOffset = br.ReadUInt32();

                // PE Header
                fs.Seek(peOffset, SeekOrigin.Begin);
                if (br.ReadUInt32() != 0x00004550) return 0; // "PE\0\0"

                // File Header & Optional Header (PE32)
                fs.Seek(peOffset + 24 + 96, SeekOrigin.Begin); // DataDirectory[0] = Export Table
                uint exportDirRva = br.ReadUInt32();
                if (exportDirRva == 0) return 0;

                // Section Headers
                fs.Seek(peOffset + 20, SeekOrigin.Begin);
                ushort optHeaderSize = br.ReadUInt16();
                fs.Seek(peOffset + 24 + optHeaderSize, SeekOrigin.Begin);

                // Find section containing export dir
                uint sectionRawOffset = 0;
                uint sectionVirtualAddress = 0;
                for (int i = 0; i < 30; i++)
                {
                    fs.Seek(8, SeekOrigin.Current); // skip name
                    uint virtSize = br.ReadUInt32();
                    uint virtAddr = br.ReadUInt32();
                    uint rawSize = br.ReadUInt32();
                    uint rawAddr = br.ReadUInt32();
                    fs.Seek(16, SeekOrigin.Current); // skip rest of section header

                    if (exportDirRva >= virtAddr && exportDirRva < virtAddr + virtSize)
                    {
                        sectionRawOffset = rawAddr;
                        sectionVirtualAddress = virtAddr;
                        break;
                    }
                }

                if (sectionRawOffset == 0) return 0;

                uint exportTableFileOffset = sectionRawOffset + (exportDirRva - sectionVirtualAddress);
                fs.Seek(exportTableFileOffset + 24, SeekOrigin.Begin);
                uint numberOfFunctions = br.ReadUInt32();
                uint numberOfNames = br.ReadUInt32();
                uint addressOfFunctions = br.ReadUInt32();
                uint addressOfNames = br.ReadUInt32();
                uint addressOfNameOrdinals = br.ReadUInt32();

                for (uint i = 0; i < numberOfNames; i++)
                {
                    uint nameRvaOffset = sectionRawOffset + (addressOfNames - sectionVirtualAddress) + (i * 4);
                    fs.Seek(nameRvaOffset, SeekOrigin.Begin);
                    uint nameRva = br.ReadUInt32();

                    uint nameFileOffset = sectionRawOffset + (nameRva - sectionVirtualAddress);
                    fs.Seek(nameFileOffset, SeekOrigin.Begin);
                    StringBuilder sb = new StringBuilder();
                    byte b;
                    while ((b = br.ReadByte()) != 0)
                    {
                        sb.Append((char)b);
                    }

                    if (string.Equals(sb.ToString(), functionName, StringComparison.Ordinal))
                    {
                        uint ordinalOffset = sectionRawOffset + (addressOfNameOrdinals - sectionVirtualAddress) + (i * 2);
                        fs.Seek(ordinalOffset, SeekOrigin.Begin);
                        ushort ordinal = br.ReadUInt16();

                        uint funcRvaOffset = sectionRawOffset + (addressOfFunctions - sectionVirtualAddress) + (uint)(ordinal * 4);
                        fs.Seek(funcRvaOffset, SeekOrigin.Begin);
                        return br.ReadUInt32();
                    }
                }
            }

            return 0;
        }
    }
}
