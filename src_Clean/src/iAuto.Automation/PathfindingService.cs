using System;
using System.Diagnostics;
using iAuto.Core.Models;
using iAuto.Game.Lua;

namespace iAuto.Automation
{
    /// <summary>
    /// Quản lý tìm đường, di chuyển và xử lý kẹt nhân vật.
    /// Chuẩn hóa từ Class106.method_325()
    /// </summary>
    public class PathfindingService
    {
        private readonly LuaCommandService _luaService;
        private readonly Stopwatch _stuckTimer;
        private float _lastX;
        private float _lastY;

        public PathfindingService(LuaCommandService luaService)
        {
            if (luaService == null)
            {
                throw new ArgumentNullException("luaService");
            }

            _luaService = luaService;
            _stuckTimer = Stopwatch.StartNew();
            _lastX = 0f;
            _lastY = 0f;
        }

        /// <summary>
        /// Ra lệnh cho nhân vật tự động di chuyển đến tọa độ đích (X, Y) tại MapId.
        /// </summary>
        public void MoveTo(float x, float y, int mapId)
        {
            string command = string.Format("AutoRunToTargetEx({0},{1},{2})", (int)x, (int)y, mapId);
            _luaService.ExecuteLua(command);
        }

        /// <summary>
        /// Kiểm tra xem nhân vật đã đến gần tọa độ đích chưa.
        /// </summary>
        public bool IsAtLocation(float currentX, float currentY, float targetX, float targetY, float threshold)
        {
            float dx = currentX - targetX;
            float dy = currentY - targetY;
            return Math.Sqrt(dx * dx + dy * dy) <= threshold;
        }

        /// <summary>
        /// Kiểm tra kẹt: nếu nhân vật đang di chuyển nhưng vị trí không đổi trong 4 giây.
        /// </summary>
        public bool CheckIfStuck(PlayerState player)
        {
            if (player == null)
            {
                return false;
            }

            float dx = player.X - _lastX;
            float dy = player.Y - _lastY;
            double distanceMoved = Math.Sqrt(dx * dx + dy * dy);

            if (distanceMoved < 1.0)
            {
                if (_stuckTimer.Elapsed.TotalSeconds >= 4.0)
                {
                    _stuckTimer.Restart();
                    return true;
                }
            }
            else
            {
                _lastX = player.X;
                _lastY = player.Y;
                _stuckTimer.Restart();
            }

            return false;
        }

        /// <summary>
        /// Giải kẹt bằng cách nhảy hoặc dịch chuyển nhẹ.
        /// </summary>
        public void Unstick()
        {
            _luaService.ExecuteLua("Jump();");
        }
    }
}
