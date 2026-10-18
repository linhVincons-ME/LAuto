using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using iAuto.Core.Models;

namespace iAuto.Automation
{
    /// <summary>
    /// Định nghĩa kịch bản né chiêu thức của một Boss cụ thể.
    /// </summary>
    public class BossTacticRule
    {
        public string BossName { get; set; }
        public int MapId { get; set; }
        public double SkillIntervalSeconds { get; set; }
        public double EvasionDurationSeconds { get; set; }
        public PointF SafePosition { get; set; }

        public BossTacticRule(string bossName, int mapId, double interval, double duration, PointF safePos)
        {
            BossName = bossName;
            MapId = mapId;
            SkillIntervalSeconds = interval;
            EvasionDurationSeconds = duration;
            SafePosition = safePos;
        }
    }

    /// <summary>
    /// Điều khiển việc né chiêu thức diện rộng (AOE) nguy hiểm của Boss trong phụ bản.
    /// Chuẩn hóa từ Class106.cs (Lý Thu Thủy, Thiên Sơn Đồng Lão...)
    /// </summary>
    public class BossTacticsService
    {
        private readonly PathfindingService _pathfinder;
        private readonly Dictionary<string, Stopwatch> _bossSkillTimers;
        private readonly List<BossTacticRule> _rules;

        public bool IsEvading { get; private set; }
        public string ActiveBossName { get; private set; }

        public BossTacticsService(PathfindingService pathfinder)
        {
            if (pathfinder == null)
            {
                throw new ArgumentNullException("pathfinder");
            }

            _pathfinder = pathfinder;
            _bossSkillTimers = new Dictionary<string, Stopwatch>();
            _rules = new List<BossTacticRule>();

            InitializeDefaultBossRules();
        }

        private void InitializeDefaultBossRules()
        {
            // Kịch bản Lý Thu Thủy (Lãng Hoàn Phúc Địa / Phiêu Miễu Phong - Map 677)
            // Chuẩn hóa từ chuỗi "[Lang Hoàn Phúc Địa-Lý Thu Thủy][141,63-677]"
            _rules.Add(new BossTacticRule(
                "Ly Thu Thuy",
                677,
                15.0, // Chu kỳ ra chiêu 15 giây
                6.0,  // Thời gian né 6 giây
                new PointF(141f, 63f))); // Tọa độ góc an toàn

            // Kịch bản Thiên Sơn Đồng Lão (Map 677)
            _rules.Add(new BossTacticRule(
                "Thien Son Dong Lao",
                677,
                18.0,
                5.0,
                new PointF(213f, 120f)));
        }

        /// <summary>
        /// Cập nhật trạng thái né chiêu dựa trên các Boss xuất hiện xung quanh.
        /// </summary>
        /// <returns>True nếu nhân vật đang trong trạng thái né chiêu (cần dừng tấn công)</returns>
        public bool Update(PlayerState player, List<GameEntity> surroundingEntities)
        {
            if (player == null || surroundingEntities == null || surroundingEntities.Count == 0)
            {
                IsEvading = false;
                return false;
            }

            for (int i = 0; i < _rules.Count; i++)
            {
                BossTacticRule rule = _rules[i];

                if (rule.MapId > 0 && player.MapId != rule.MapId)
                {
                    continue;
                }

                // Tìm xem Boss có đang xuất hiện xung quanh không
                GameEntity boss = null;
                for (int j = 0; j < surroundingEntities.Count; j++)
                {
                    if (surroundingEntities[j].Name.IndexOf(rule.BossName, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        boss = surroundingEntities[j];
                        break;
                    }
                }

                if (boss == null || !boss.IsAlive)
                {
                    continue;
                }

                // Khởi động bộ đếm thời gian cho boss nếu chưa có
                if (!_bossSkillTimers.ContainsKey(rule.BossName))
                {
                    _bossSkillTimers[rule.BossName] = Stopwatch.StartNew();
                }

                Stopwatch timer = _bossSkillTimers[rule.BossName];
                double elapsed = timer.Elapsed.TotalSeconds;

                // Nếu đến thời điểm boss chuẩn bị tung chiêu -> Chạy về tọa độ an toàn
                if (elapsed >= rule.SkillIntervalSeconds && elapsed < rule.SkillIntervalSeconds + rule.EvasionDurationSeconds)
                {
                    IsEvading = true;
                    ActiveBossName = rule.BossName;
                    _pathfinder.MoveTo(rule.SafePosition.X, rule.SafePosition.Y, rule.MapId);
                    return true;
                }

                // Đã hết thời gian chiêu thức của boss -> Reset bộ đếm chu kỳ
                if (elapsed >= rule.SkillIntervalSeconds + rule.EvasionDurationSeconds)
                {
                    timer.Restart();
                }
            }

            IsEvading = false;
            ActiveBossName = string.Empty;
            return false;
        }
    }
}
