using System;
using iAuto.Core.Enums;

namespace iAuto.Core.Models
{
    /// <summary>
    /// Lưu trữ thông tin tài khoản game cho tính năng tự động đăng nhập.
    /// Chuẩn hóa từ Class400.cs trong TabLogin.cs
    /// </summary>
    public class GameAccount
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string CharacterName { get; set; }
        public string ServerName { get; set; }
        public int CharacterSlotIndex { get; set; }
        public int Level { get; set; }
        public MenpaiType Menpai { get; set; }

        public string Status { get; set; }
        public string CategoryTag { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastLoginTime { get; set; }

        public GameAccount()
        {
            Username = string.Empty;
            Password = string.Empty;
            CharacterName = string.Empty;
            ServerName = string.Empty;
            CharacterSlotIndex = 0;
            Level = 1;
            Menpai = MenpaiType.None;
            Status = "Đang chờ";
            CategoryTag = string.Empty;
            IsActive = true;
            LastLoginTime = DateTime.MinValue;
        }

        public override string ToString()
        {
            return string.Format("{0} | {1} (Server: {2}, Slot: {3})",
                Username,
                string.IsNullOrEmpty(CharacterName) ? "(Chưa tạo NV)" : CharacterName,
                ServerName,
                CharacterSlotIndex);
        }
    }
}
