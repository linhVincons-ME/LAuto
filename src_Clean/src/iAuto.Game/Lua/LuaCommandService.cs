using System;
using System.Text;
using iAuto.Native;

namespace iAuto.Game.Lua
{
    /// <summary>
    /// Dịch vụ dispatch các đoạn script Lua vào client game thông qua Shared Memory và Windows Message.
    /// Chuẩn hóa từ Class512.cs và Class106.method_375()
    /// </summary>
    public class LuaCommandService
    {
        private const uint WM_IAUTO_LUA = 104; // Opcode thực thi Lua
        private readonly IntPtr _gameWindowHandle;
        private readonly IntPtr _gameProcessHandle;
        private IntPtr _remoteMemoryBuffer;
        private const uint BUFFER_SIZE = 65536;

        public LuaCommandService(IntPtr gameWindowHandle, IntPtr gameProcessHandle)
        {
            _gameWindowHandle = gameWindowHandle;
            _gameProcessHandle = gameProcessHandle;
            _remoteMemoryBuffer = IntPtr.Zero;
        }

        /// <summary>
        /// Gửi đoạn mã Lua thô sang client game thực thi.
        /// </summary>
        public bool ExecuteLua(string luaCode)
        {
            if (string.IsNullOrEmpty(luaCode) || _gameWindowHandle == IntPtr.Zero || _gameProcessHandle == IntPtr.Zero)
            {
                return false;
            }

            if (_remoteMemoryBuffer == IntPtr.Zero)
            {
                _remoteMemoryBuffer = NativeMethods.VirtualAllocEx(
                    _gameProcessHandle,
                    IntPtr.Zero,
                    BUFFER_SIZE,
                    NativeMethods.MEM_COMMIT | NativeMethods.MEM_RESERVE,
                    NativeMethods.PAGE_READWRITE);

                if (_remoteMemoryBuffer == IntPtr.Zero)
                {
                    return false;
                }
            }

            byte[] buffer = Encoding.UTF8.GetBytes(luaCode + " --\0");
            UIntPtr written;
            if (!NativeMethods.WriteProcessMemory(_gameProcessHandle, _remoteMemoryBuffer, buffer, (uint)buffer.Length, out written)
                || written.ToUInt64() != (ulong)buffer.Length)
            {
                return false;
            }

            // Gửi thông điệp kèm địa chỉ buffer chứa chuỗi Lua và Opcode thực thi
            return NativeMethods.PostMessage(_gameWindowHandle, WM_IAUTO_LUA, _remoteMemoryBuffer, IntPtr.Zero);
        }

        #region Các lệnh điều khiển Game thông dụng

        /// <summary>
        /// Sử dụng vật phẩm theo chỉ số slot trong túi đồ.
        /// </summary>
        public void UseBagItem(int slotIndex)
        {
            ExecuteLua(string.Format("PlayerPackage:UseItem({0});", slotIndex));
        }

        /// <summary>
        /// Đi theo trưởng nhóm.
        /// </summary>
        public void FollowTeamLeader()
        {
            ExecuteLua("Player:TeamFrame_AskTeamFollow();");
        }

        /// <summary>
        /// Chọn mục tiêu của mục tiêu hiện tại (Target of Target).
        /// </summary>
        public void SelectTargetOfTarget()
        {
            ExecuteLua("SelectTargetOfTarget();");
        }

        /// <summary>
        /// Chấp nhận nhiệm vụ trong bảng đối thoại đang mở.
        /// </summary>
        public void AcceptCurrentQuest()
        {
            ExecuteLua("QuestFrameAcceptClicked();");
        }

        /// <summary>
        /// Tắt toàn bộ âm thanh client để giảm tải CPU và RAM.
        /// </summary>
        public void DisableClientSounds()
        {
            string lua = @"
Variable:SetVariable('DisableAllSound', 1, 0);
Variable:SetVariable('EnableBGSound', 0, 0);
Variable:SetVariable('Enable3DSound', 0, 0);
Variable:SetVariable('EnableSKSound', 0, 0);
Variable:SetVariable('EnableUISound', 0, 0);";
            ExecuteLua(lua);
        }

        #endregion
    }
}
