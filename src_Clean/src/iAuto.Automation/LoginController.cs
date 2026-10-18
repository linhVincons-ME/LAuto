using System;
using System.Threading;
using iAuto.Core.Models;
using iAuto.Game.Lua;
using iAuto.Native;

namespace iAuto.Automation
{
    /// <summary>
    /// Điều khiển quy trình tự động đăng nhập vào game TLBB mà không chiếm quyền chuột/bàn phím của người dùng.
    /// Chuẩn hóa từ TabLogin.cs và Class106.method_295()
    /// </summary>
    public class LoginController
    {
        private const uint WM_KEYDOWN = 0x0100;
        private const uint WM_KEYUP = 0x0101;
        private const uint WM_CHAR = 0x0102;
        private const int VK_TAB = 0x09;
        private const int VK_RETURN = 0x0D;

        private readonly IntPtr _gameWindowHandle;
        private readonly LuaCommandService _luaService;

        public LoginController(IntPtr gameWindowHandle, LuaCommandService luaService)
        {
            if (luaService == null)
            {
                throw new ArgumentNullException("luaService");
            }

            _gameWindowHandle = gameWindowHandle;
            _luaService = luaService;
        }

        /// <summary>
        /// Điền tài khoản và mật khẩu vào màn hình đăng nhập thông qua Windows Message.
        /// </summary>
        public void InputCredentials(string username, string password)
        {
            if (_gameWindowHandle == IntPtr.Zero || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return;
            }

            // 1. Xóa nội dung cũ trong ô tài khoản
            _luaService.ExecuteLua("setmetatable(_G, {__index = LoginLogOn_Env}); if this ~= nil and this:IsVisible() then LogOn_ID:SetText(''); end");
            Thread.Sleep(300);

            // 2. Gửi từng ký tự tài khoản bằng WM_CHAR
            for (int i = 0; i < username.Length; i++)
            {
                NativeMethods.PostMessage(_gameWindowHandle, WM_CHAR, new IntPtr((int)username[i]), IntPtr.Zero);
            }

            Thread.Sleep(100);

            // 3. Nhấn TAB để chuyển con trỏ sang ô mật khẩu
            NativeMethods.PostMessage(_gameWindowHandle, WM_KEYDOWN, new IntPtr(VK_TAB), IntPtr.Zero);
            NativeMethods.PostMessage(_gameWindowHandle, WM_KEYUP, new IntPtr(VK_TAB), IntPtr.Zero);

            Thread.Sleep(100);

            // 4. Gửi từng ký tự mật khẩu bằng WM_CHAR
            for (int j = 0; j < password.Length; j++)
            {
                NativeMethods.PostMessage(_gameWindowHandle, WM_CHAR, new IntPtr((int)password[j]), IntPtr.Zero);
            }

            Thread.Sleep(150);

            // 5. Nhấn ENTER để tiến hành đăng nhập
            NativeMethods.PostMessage(_gameWindowHandle, WM_KEYDOWN, new IntPtr(VK_RETURN), IntPtr.Zero);
            NativeMethods.PostMessage(_gameWindowHandle, WM_KEYUP, new IntPtr(VK_RETURN), IntPtr.Zero);
        }

        /// <summary>
        /// Chọn vị trí nhân vật (Slot 0, 1, 2) trên màn hình chọn nhân vật.
        /// </summary>
        public void SelectCharacterSlot(int slotIndex)
        {
            string lua = string.Format(
                "setmetatable(_G, {__index = LoginSelectRole_Env}); if this ~= nil and this:IsVisible() then GameProduceLogin:MoveToCharacter({0}); LoginSelectRole_EnterGame(); end",
                slotIndex);
            _luaService.ExecuteLua(lua);
        }

        /// <summary>
        /// Tự động tạo nhân vật ngẫu nhiên nếu tài khoản mới chưa có nhân vật.
        /// </summary>
        public void AutoCreateRole(string characterName, int gender)
        {
            if (string.IsNullOrEmpty(characterName))
            {
                characterName = "TL" + new Random().Next(10000, 99999).ToString();
            }

            string lua = string.Format(
                "setmetatable(_G, {__index = LoginCreateRole_Env}); if this ~= nil and this:IsVisible() then GameProduceLogin:SetFaceId(0, {0}); GameProduceLogin:CreateRole('{1}', 0); end",
                gender,
                characterName);
            _luaService.ExecuteLua(lua);
        }

        /// <summary>
        /// Kích hoạt kết nối lại (Reconnect) khi game bị ngắt kết nối.
        /// </summary>
        public void TriggerReconnect()
        {
            _luaService.ExecuteLua("DataPool:ReConnect();");
        }
    }
}
