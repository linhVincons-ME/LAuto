# LAuto

Bản sao làm việc của mã nguồn iAuto đã dịch ngược. Mã nguồn chính là `src\`; không cần file `iAuto.exe` gốc.

## Thư mục

| Thư mục | Nội dung |
|---|---|
| `src\` | Mã nguồn C# build được (git), mở `src\solution.sln` |
| `bin\` | Bản build để chạy + DLL, updater, cấu hình |
| `native\` | Mã C do Ghidra xuất từ 2 DLL native |
| `docs\` | Báo cáo phân tích |
| `scripts\` | Script build và dịch ngược |
| `work\` | Log và file trung gian (tự tạo, có thể xoá) |

## Quy trình hằng ngày

1. Sửa code trong `src\` (bằng Visual Studio hoặc editor bất kỳ).
2. Build:

   ```bash
   bash scripts/build_only.sh
   ```

   Kết quả: `src\iAuto\bin\Release\iAuto.exe`. Lỗi build (nếu có) nằm ở `work\errors.txt`.
3. Chép `iAuto.exe` vừa build vào `bin\` để chạy (chạy bằng quyền admin).
4. Commit thay đổi trong `src\` bằng git để có thể quay lại khi cần.

`rebuild.sh` và các script `fix_*.py`, `loopexit*.py` chỉ dùng khi muốn dịch ngược lại từ đầu một bản iAuto mới; quy trình hằng ngày không cần đến chúng.

## Yêu cầu

- Visual Studio hoặc Build Tools có MSBuild (script tự tìm qua `vswhere`), .NET Framework 4.8.
- Git Bash để chạy script `.sh`.
- Đặt biến môi trường `MSBUILD`, `LAUTO_SRC`, `LAUTO_WORK`... nếu muốn dùng đường dẫn khác mặc định (xem `scripts\config.sh`).
