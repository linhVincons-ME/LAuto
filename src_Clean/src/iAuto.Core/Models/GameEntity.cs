using System.Drawing;
using iAuto.Core.Enums;

namespace iAuto.Core.Models
{
    /// <summary>
    /// Loại thực thể trong thế giới game.
    /// </summary>
    public enum EntityType
    {
        Unknown = 0,
        Monster = 1,
        Npc = 2,
        Player = 3,
        Pet = 4
    }

    /// <summary>
    /// Đại diện cho một đối tượng (Quái vật, NPC, Người chơi khác, Pet) trong bộ nhớ game.
    /// Chuẩn hóa từ Class517.cs và Class530.cs
    /// </summary>
    public class GameEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EntityType Type { get; set; }
        public MenpaiType Menpai { get; set; }
        public int Level { get; set; }

        public int CurrentHp { get; set; }
        public int MaxHp { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public PointF Position
        {
            get { return new PointF(X, Y); }
        }

        public double DistanceToPlayer { get; set; }
        public bool IsTargeted { get; set; }
        public bool IsInCombat { get; set; }

        public bool IsAlive
        {
            get { return CurrentHp > 0; }
        }

        public double HpPercent
        {
            get { return MaxHp > 0 ? (double)CurrentHp / MaxHp * 100.0 : 0.0; }
        }

        public GameEntity()
        {
            Id = 0;
            Name = string.Empty;
            Type = EntityType.Unknown;
            Menpai = MenpaiType.None;
        }

        public override string ToString()
        {
            return string.Format("[{0}] {1} (Lv.{2}, HP: {3:F1}%, Dist: {4:F1})",
                Type, Name, Level, HpPercent, DistanceToPlayer);
        }
    }
}
