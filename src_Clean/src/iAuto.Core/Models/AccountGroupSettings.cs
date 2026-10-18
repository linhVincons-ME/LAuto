namespace iAuto.Core.Models
{
    /// <summary>
    /// Cấu hình chung cho một nhóm tài khoản đăng nhập (tương ứng 1 file XML trong iAuto.Login/).
    /// Chuẩn hóa từ thẻ Settings trong TabLogin.cs
    /// </summary>
    public class AccountGroupSettings
    {
        public int ClientLimit { get; set; }
        public bool AutoRelogOnDisconnect { get; set; }
        public bool ResetDungeonsDaily { get; set; }
        public bool ResetAtMidnight { get; set; }
        public bool IsPaused { get; set; }
        public string FakeNamePrefix { get; set; }

        public AccountGroupSettings()
        {
            ClientLimit = 4;
            AutoRelogOnDisconnect = true;
            ResetDungeonsDaily = true;
            ResetAtMidnight = true;
            IsPaused = false;
            FakeNamePrefix = string.Empty;
        }
    }
}
