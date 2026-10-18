using System;
using System.Collections.Generic;
using iAuto.Core.Enums;
using iAuto.Core.Models;

namespace iAuto.Game.Memory
{
    /// <summary>
    /// Đọc toàn bộ dữ liệu thời gian thực của game từ RAM (nhân vật, quái, NPC, túi đồ).
    /// Chuẩn hóa từ Class527.cs
    /// </summary>
    public class GameStateReader
    {
        private readonly ProcessMemoryReader _memoryReader;
        private readonly GameProfileOffsets _offsets;

        public GameStateReader(ProcessMemoryReader memoryReader, GameProfileOffsets offsets)
        {
            if (memoryReader == null)
            {
                throw new ArgumentNullException("memoryReader");
            }
            if (offsets == null)
            {
                throw new ArgumentNullException("offsets");
            }

            _memoryReader = memoryReader;
            _offsets = offsets;
        }

        /// <summary>
        /// Đọc thông tin nhân vật chính hiện tại từ RAM.
        /// </summary>
        public PlayerState ReadPlayerState()
        {
            PlayerState player = new PlayerState();
            long playerPtr = _memoryReader.ReadPointer(_offsets.PlayerBaseAddress);
            if (playerPtr == 0)
            {
                return player;
            }

            // Đọc tên nhân vật
            player.CharacterName = _memoryReader.ReadString(playerPtr + 0x20, 32, null);

            // Đọc máu và khí
            player.CurrentHp = _memoryReader.ReadInt32(playerPtr + _offsets.OffsetHp);
            player.MaxHp = _memoryReader.ReadInt32(playerPtr + _offsets.OffsetMaxHp);
            player.CurrentMp = _memoryReader.ReadInt32(playerPtr + _offsets.OffsetMp);
            player.MaxMp = _memoryReader.ReadInt32(playerPtr + _offsets.OffsetMaxMp);

            // Đọc tọa độ
            player.X = _memoryReader.ReadFloat(playerPtr + _offsets.OffsetX);
            player.Y = _memoryReader.ReadFloat(playerPtr + _offsets.OffsetY);
            player.MapId = _memoryReader.ReadInt32(playerPtr + _offsets.OffsetMapId);

            // Đọc môn phái & cấp độ
            int menpaiId = _memoryReader.ReadInt32(playerPtr + _offsets.OffsetMenpai);
            player.Menpai = Enum.IsDefined(typeof(MenpaiType), menpaiId) ? (MenpaiType)menpaiId : MenpaiType.None;
            player.Level = _memoryReader.ReadInt32(playerPtr + _offsets.OffsetLevel);

            // Đọc tiền tệ
            int totalCopper = _memoryReader.ReadInt32(playerPtr + _offsets.OffsetMoneyGold);
            if (totalCopper > 0)
            {
                player.Gold = totalCopper / 10000;
                player.Silver = (totalCopper % 10000) / 100;
                player.Bronze = totalCopper % 100;
            }

            player.Knb = _memoryReader.ReadInt32(playerPtr + _offsets.OffsetKnb);

            return player;
        }

        /// <summary>
        /// Đọc danh sách các thực thể (Quái vật, NPC, Người chơi) xung quanh vị trí nhân vật.
        /// </summary>
        public List<GameEntity> ReadSurroundingEntities(PlayerState currentPlayer)
        {
            List<GameEntity> entities = new List<GameEntity>();
            long actorListPtr = _memoryReader.ReadPointer(_offsets.ActorListBaseAddress);
            if (actorListPtr == 0)
            {
                return entities;
            }

            // Quét tối đa 128 đối tượng xung quanh
            for (int i = 0; i < 128; i++)
            {
                long actorAddr = actorListPtr + (i * _offsets.ActorStructSize);
                int actorId = _memoryReader.ReadInt32(actorAddr + _offsets.ActorOffsetId);
                if (actorId <= 0)
                {
                    continue;
                }

                string name = _memoryReader.ReadString(actorAddr + _offsets.ActorOffsetName, 32, null);
                if (string.IsNullOrEmpty(name))
                {
                    continue;
                }

                GameEntity entity = new GameEntity();
                entity.Id = actorId;
                entity.Name = name;
                entity.CurrentHp = _memoryReader.ReadInt32(actorAddr + _offsets.ActorOffsetHp);
                entity.MaxHp = _memoryReader.ReadInt32(actorAddr + _offsets.ActorOffsetMaxHp);
                entity.X = _memoryReader.ReadFloat(actorAddr + _offsets.ActorOffsetX);
                entity.Y = _memoryReader.ReadFloat(actorAddr + _offsets.ActorOffsetY);

                // Tính khoảng cách Euclidean tới người chơi
                if (currentPlayer != null)
                {
                    float dx = entity.X - currentPlayer.X;
                    float dy = entity.Y - currentPlayer.Y;
                    entity.DistanceToPlayer = Math.Sqrt(dx * dx + dy * dy);
                }

                // Phân loại thực thể
                int typeFlag = _memoryReader.ReadInt32(actorAddr + _offsets.ActorOffsetType);
                if (typeFlag == 1)
                {
                    entity.Type = EntityType.Monster;
                }
                else if (typeFlag == 2)
                {
                    entity.Type = EntityType.Npc;
                }
                else if (typeFlag == 3)
                {
                    entity.Type = EntityType.Player;
                }
                else
                {
                    entity.Type = EntityType.Unknown;
                }

                entities.Add(entity);
            }

            return entities;
        }

        /// <summary>
        /// Đọc danh sách vật phẩm trong túi đồ của nhân vật.
        /// </summary>
        public List<GameItem> ReadInventoryItems()
        {
            List<GameItem> items = new List<GameItem>();
            long bagPtr = _memoryReader.ReadPointer(_offsets.BagBaseAddress);
            if (bagPtr == 0)
            {
                return items;
            }

            // Túi đồ cơ bản TLBB có 60 ô (3 trang x 20 ô)
            for (int slot = 0; slot < 60; slot++)
            {
                long itemAddr = bagPtr + (slot * 48); // 48 bytes mỗi struct item
                int itemId = _memoryReader.ReadInt32(itemAddr + 0x00);
                if (itemId <= 0)
                {
                    continue;
                }

                GameItem item = new GameItem();
                item.SlotIndex = slot;
                item.ItemId = itemId;
                item.Count = _memoryReader.ReadInt32(itemAddr + 0x04);
                item.ItemName = _memoryReader.ReadString(itemAddr + 0x08, 32, null);
                item.IsLocked = _memoryReader.ReadByte(itemAddr + 0x28) == 1;

                items.Add(item);
            }

            return items;
        }
    }
}
