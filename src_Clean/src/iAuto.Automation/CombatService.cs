using System;
using System.Collections.Generic;
using iAuto.Core.Models;
using iAuto.Game.Lua;
using iAuto.Native;

namespace iAuto.Automation
{
    /// <summary>
    /// Điều khiển việc lựa chọn mục tiêu quái vật, combo kỹ năng và tự động hồi máu/khí.
    /// Chuẩn hóa từ Class106.cs
    /// </summary>
    public class CombatService
    {
        private readonly LuaCommandService _luaService;
        private readonly IntPtr _gameWindowHandle;

        // Opcodes thông điệp Windows gửi tới DLL trong Game
        private const uint WM_SELECT_TARGET = 103;
        private const uint WM_USE_SKILL = 102;

        public CombatService(LuaCommandService luaService, IntPtr gameWindowHandle)
        {
            if (luaService == null)
            {
                throw new ArgumentNullException("luaService");
            }

            _luaService = luaService;
            _gameWindowHandle = gameWindowHandle;
        }

        /// <summary>
        /// Chọn mục tiêu tối ưu từ danh sách thực thể xung quanh.
        /// </summary>
        public GameEntity SelectBestTarget(PlayerState player, List<GameEntity> surroundingEntities, CombatConfig config)
        {
            if (player == null || surroundingEntities == null || surroundingEntities.Count == 0 || config == null)
            {
                return null;
            }

            GameEntity bestTarget = null;
            double minDistance = double.MaxValue;

            for (int i = 0; i < surroundingEntities.Count; i++)
            {
                GameEntity entity = surroundingEntities[i];

                // Chỉ tấn công quái vật còn sống
                if (entity.Type != EntityType.Monster || !entity.IsAlive)
                {
                    continue;
                }

                // Kiểm tra phạm vi cho phép
                if (entity.DistanceToPlayer > config.MaxCombatRange)
                {
                    continue;
                }

                // Kiểm tra danh sách đen (Blacklist)
                if (config.MonsterBlacklist.Contains(entity.Name))
                {
                    continue;
                }

                // Ưu tiên quái vật trong Whitelist
                bool isWhitelisted = config.MonsterWhitelist.Contains(entity.Name);

                if (isWhitelisted)
                {
                    if (bestTarget == null || !config.MonsterWhitelist.Contains(bestTarget.Name) || entity.DistanceToPlayer < minDistance)
                    {
                        bestTarget = entity;
                        minDistance = entity.DistanceToPlayer;
                    }
                }
                else if (bestTarget == null || (!config.MonsterWhitelist.Contains(bestTarget.Name) && entity.DistanceToPlayer < minDistance))
                {
                    bestTarget = entity;
                    minDistance = entity.DistanceToPlayer;
                }
            }

            return bestTarget;
        }

        /// <summary>
        /// Khóa mục tiêu và thực hiện tấn công.
        /// </summary>
        public void AttackTarget(GameEntity target)
        {
            if (target == null || _gameWindowHandle == IntPtr.Zero)
            {
                return;
            }

            // Gửi lệnh chọn mục tiêu qua con trỏ ID
            NativeMethods.PostMessage(_gameWindowHandle, WM_SELECT_TARGET, new IntPtr(target.Id), IntPtr.Zero);

            // Kích hoạt tấn công cơ bản hoặc kỹ năng
            NativeMethods.PostMessage(_gameWindowHandle, WM_USE_SKILL, new IntPtr(target.Id), IntPtr.Zero);
        }

        /// <summary>
        /// Kiểm tra và tự động sử dụng dược phẩm hồi phục HP/MP.
        /// </summary>
        public void CheckAndAutoHeal(PlayerState player, CombatConfig config)
        {
            if (player == null || config == null)
            {
                return;
            }

            // Kiểm tra máu (HP)
            if (player.HpPercent > 0 && player.HpPercent < config.AutoHpPotionPercent)
            {
                _luaService.UseBagItem(config.HpPotionBagSlot);
            }

            // Kiểm tra khí (MP)
            if (player.MpPercent > 0 && player.MpPercent < config.AutoMpPotionPercent)
            {
                _luaService.UseBagItem(config.MpPotionBagSlot);
            }
        }
    }
}
