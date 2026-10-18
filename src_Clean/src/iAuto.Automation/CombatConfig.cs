using System.Collections.Generic;

namespace iAuto.Automation
{
    /// <summary>
    /// Cấu hình thông số chiến đấu và sinh tồn cho nhân vật.
    /// </summary>
    public class CombatConfig
    {
        public int AutoHpPotionPercent { get; set; }
        public int AutoMpPotionPercent { get; set; }
        public int HpPotionBagSlot { get; set; }
        public int MpPotionBagSlot { get; set; }

        public float MaxCombatRange { get; set; }
        public float CampX { get; set; }
        public float CampY { get; set; }
        public int CampMapId { get; set; }

        public bool AutoAttack { get; set; }
        public bool AutoHealHp { get; set; }
        public bool AutoHealMp { get; set; }
        public bool AutoReturnToCamp { get; set; }
        public bool PrioritizeLeaderTarget { get; set; }

        public List<string> MonsterWhitelist { get; set; }
        public List<string> MonsterBlacklist { get; set; }

        public CombatConfig()
        {
            AutoHpPotionPercent = 70;
            AutoMpPotionPercent = 30;
            HpPotionBagSlot = 0;
            MpPotionBagSlot = 1;

            MaxCombatRange = 25.0f;
            CampX = 0f;
            CampY = 0f;
            CampMapId = 0;

            AutoReturnToCamp = true;
            PrioritizeLeaderTarget = false;

            MonsterWhitelist = new List<string>();
            MonsterBlacklist = new List<string>();
        }
    }
}
