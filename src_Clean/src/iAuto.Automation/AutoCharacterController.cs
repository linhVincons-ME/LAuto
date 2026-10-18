using System;
using System.Collections.Generic;
using iAuto.Core.Models;
using iAuto.Game.Memory;

namespace iAuto.Automation
{
    /// <summary>
    /// Các trạng thái hoạt động của nhân vật trong máy trạng thái (State Machine).
    /// </summary>
    public enum CharacterAutomationState
    {
        Idle,
        InCombat,
        EvadingBoss,
        ReturningToCamp,
        Dead
    }

    /// <summary>
    /// Bộ điều khiển tổng quản lý vòng lặp hành vi tự động cho một nhân vật.
    /// Chuẩn hóa từ Class106.cs
    /// </summary>
    public class AutoCharacterController
    {
        private readonly GameStateReader _stateReader;
        private readonly CombatService _combatService;
        private readonly PathfindingService _pathfinder;
        private readonly BossTacticsService _bossTactics;
        private readonly CombatConfig _config;

        public CharacterAutomationState CurrentState { get; private set; }
        public GameEntity CurrentTarget { get; private set; }
        public PlayerState LastPlayerState { get; private set; }

        public AutoCharacterController(
            GameStateReader stateReader,
            CombatService combatService,
            PathfindingService pathfinder,
            BossTacticsService bossTactics,
            CombatConfig config)
        {
            if (stateReader == null) throw new ArgumentNullException("stateReader");
            if (combatService == null) throw new ArgumentNullException("combatService");
            if (pathfinder == null) throw new ArgumentNullException("pathfinder");
            if (bossTactics == null) throw new ArgumentNullException("bossTactics");
            if (config == null) throw new ArgumentNullException("config");

            _stateReader = stateReader;
            _combatService = combatService;
            _pathfinder = pathfinder;
            _bossTactics = bossTactics;
            _config = config;

            CurrentState = CharacterAutomationState.Idle;
        }

        /// <summary>
        /// Chu kỳ cập nhật hành vi tự động (gọi định kỳ mỗi 200 - 500ms).
        /// </summary>
        public void Tick()
        {
            // 1. Đọc trạng thái mới nhất từ RAM
            PlayerState player = _stateReader.ReadPlayerState();
            LastPlayerState = player;

            if (player == null || !player.IsAlive)
            {
                CurrentState = CharacterAutomationState.Dead;
                CurrentTarget = null;
                return;
            }

            // 2. Tự động kiểm tra và hồi phục HP/MP
            _combatService.CheckAndAutoHeal(player, _config);

            // 3. Đọc các thực thể xung quanh
            List<GameEntity> surroundingEntities = _stateReader.ReadSurroundingEntities(player);

            // 4. Ưu tiên cao nhất: Kiểm tra né chiêu thức Boss phụ bản
            if (_bossTactics.Update(player, surroundingEntities))
            {
                CurrentState = CharacterAutomationState.EvadingBoss;
                CurrentTarget = null;
                return;
            }

            // 5. Kiểm tra mục tiêu hiện tại còn sống và trong phạm vi không
            if (CurrentTarget != null && (!CurrentTarget.IsAlive || CurrentTarget.DistanceToPlayer > _config.MaxCombatRange))
            {
                CurrentTarget = null;
            }

            // 6. Tìm mục tiêu mới nếu chưa có
            if (CurrentTarget == null)
            {
                CurrentTarget = _combatService.SelectBestTarget(player, surroundingEntities, _config);
            }

            // 7. Thực hiện chiến đấu hoặc quay về bãi train
            if (CurrentTarget != null)
            {
                CurrentState = CharacterAutomationState.InCombat;
                _combatService.AttackTarget(CurrentTarget);
            }
            else
            {
                // Không có quái: Kiểm tra quay về bãi (Camp)
                if (_config.AutoReturnToCamp && _config.CampX > 0 && _config.CampY > 0)
                {
                    if (!_pathfinder.IsAtLocation(player.X, player.Y, _config.CampX, _config.CampY, 3.0f))
                    {
                        CurrentState = CharacterAutomationState.ReturningToCamp;
                        _pathfinder.MoveTo(_config.CampX, _config.CampY, _config.CampMapId);
                        return;
                    }
                }

                CurrentState = CharacterAutomationState.Idle;
            }
        }
    }
}
