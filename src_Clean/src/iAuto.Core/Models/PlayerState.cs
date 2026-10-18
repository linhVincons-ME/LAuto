using System.Drawing;
using iAuto.Core.Enums;

namespace iAuto.Core.Models
{
    /// <summary>
    /// Lưu trữ trạng thái nhân vật đọc từ bộ nhớ game.
    /// Chuẩn hóa từ Class527.cs
    /// </summary>
    public class PlayerState
    {
        public string CharacterName { get; set; }
        public int Level { get; set; }
        public MenpaiType Menpai { get; set; }

        public int CurrentHp { get; set; }
        public int MaxHp { get; set; }
        public int CurrentMp { get; set; }
        public int MaxMp { get; set; }

        public float X { get; set; }
        public float Y { get; set; }
        public int MapId { get; set; }

        public PointF Position
        {
            get { return new PointF(X, Y); }
        }

        public int Gold { get; set; }       // Vàng
        public int Silver { get; set; }     // Bạc
        public int Bronze { get; set; }     // Đồng
        public int BoundKnb { get; set; }   // KNB khóa
        public int Knb { get; set; }        // KNB

        public bool IsAlive
        {
            get { return CurrentHp > 0; }
        }

        public bool IsInCombat { get; set; }
        public bool IsMounted { get; set; }
        public bool IsInTeam { get; set; }
        public bool IsTeamLeader { get; set; }

        public double HpPercent
        {
            get { return MaxHp > 0 ? (double)CurrentHp / MaxHp * 100.0 : 0.0; }
        }

        public double MpPercent
        {
            get { return MaxMp > 0 ? (double)CurrentMp / MaxMp * 100.0 : 0.0; }
        }

        public PlayerState()
        {
            CharacterName = string.Empty;
            Menpai = MenpaiType.None;
        }
    }
}
