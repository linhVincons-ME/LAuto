namespace iAuto.Core.Models
{
    /// <summary>
    /// Đại diện cho một vật phẩm trong túi đồ hoặc kho chứa.
    /// </summary>
    public class GameItem
    {
        public int SlotIndex { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int Count { get; set; }
        public bool IsLocked { get; set; }

        public GameItem()
        {
            SlotIndex = -1;
            ItemId = 0;
            ItemName = string.Empty;
            Count = 0;
            IsLocked = false;
        }

        public override string ToString()
        {
            return string.Format("Slot {0}: {1} x{2}{3}",
                SlotIndex,
                ItemName,
                Count,
                IsLocked ? " (Khóa)" : "");
        }
    }
}
