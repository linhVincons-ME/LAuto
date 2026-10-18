namespace iAuto.Game.Memory
{
    /// <summary>
    /// Cấu hình các độ lệch địa chỉ (Memory Offsets) theo từng phiên bản máy chủ TLBB.
    /// Chuẩn hóa từ Class502.cs
    /// </summary>
    public class GameProfileOffsets
    {
        public int ProfileId { get; set; }
        public string ProfileName { get; set; }

        // Con trỏ cơ sở (Base Pointers)
        public long PlayerBaseAddress { get; set; }
        public long ActorListBaseAddress { get; set; }
        public long TargetBaseAddress { get; set; }
        public long BagBaseAddress { get; set; }
        public long PetBaseAddress { get; set; }
        public long QuestBaseAddress { get; set; }

        // Độ lệch chỉ số nhân vật
        public int OffsetHp { get; set; }
        public int OffsetMaxHp { get; set; }
        public int OffsetMp { get; set; }
        public int OffsetMaxMp { get; set; }
        public int OffsetX { get; set; }
        public int OffsetY { get; set; }
        public int OffsetMapId { get; set; }
        public int OffsetLevel { get; set; }
        public int OffsetMenpai { get; set; }
        public int OffsetMoneyGold { get; set; }
        public int OffsetMoneySilver { get; set; }
        public int OffsetMoneyBronze { get; set; }
        public int OffsetKnb { get; set; }

        // Độ lệch trong danh sách Actor/Entity
        public int ActorStructSize { get; set; }
        public int ActorOffsetId { get; set; }
        public int ActorOffsetName { get; set; }
        public int ActorOffsetType { get; set; }
        public int ActorOffsetHp { get; set; }
        public int ActorOffsetMaxHp { get; set; }
        public int ActorOffsetX { get; set; }
        public int ActorOffsetY { get; set; }

        public GameProfileOffsets()
        {
            ProfileId = 1;
            ProfileName = "Default";
            ActorStructSize = 0x118;
            ActorOffsetId = 0x04;
            ActorOffsetName = 0x20;
            ActorOffsetHp = 0xB8;
            ActorOffsetMaxHp = 0xBC;
            ActorOffsetX = 0x34;
            ActorOffsetY = 0x3C;
        }

        /// <summary>
        /// Tạo cấu hình chuẩn cho client TLBB thông dụng.
        /// </summary>
        public static GameProfileOffsets CreateDefaultProfile(int profileId, long baseModuleAddress)
        {
            GameProfileOffsets profile = new GameProfileOffsets();
            profile.ProfileId = profileId;
            profile.PlayerBaseAddress = baseModuleAddress;

            switch (profileId)
            {
                case 1: // Client VNG chuẩn
                    profile.ProfileName = "TLBB_VNG";
                    profile.OffsetX = 52;
                    profile.OffsetY = 60;
                    profile.OffsetHp = 0x48;
                    profile.OffsetMaxHp = 0x4C;
                    profile.OffsetMp = 0x50;
                    profile.OffsetMaxMp = 0x54;
                    profile.ActorStructSize = 280;
                    break;

                case 2: // Client Private phổ biến
                    profile.ProfileName = "TLBB_Private";
                    profile.OffsetX = 84;
                    profile.OffsetY = 92;
                    profile.OffsetHp = 132;
                    profile.OffsetMaxHp = 144;
                    profile.ActorStructSize = 260;
                    break;

                default:
                    profile.ProfileName = "TLBB_Generic";
                    break;
            }

            return profile;
        }
    }
}
