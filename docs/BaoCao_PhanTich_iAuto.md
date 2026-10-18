# Báo cáo phân tích ngược iAuto (thư mục E:\TLBB\iAuto.x64)

Phân tích tĩnh (không chạy tool): đọc PE header, metadata .NET (dnfile), heap chuỗi #US và chuỗi trong các DLL native. Không đụng tới cơ chế bản quyền/kích hoạt. Ghidra không cần dùng vì phần lõi là .NET; Ghidra chỉ hữu ích nếu muốn đào sâu DLL x86.

## 1. Tổng quan các file

| File | Định dạng | Ngôn ngữ / framework | Vai trò |
|---|---|---|---|
| `iAuto.exe` (15 MB) | PE32+ x64, GUI, có CLR header | C# / .NET Framework 4.x (runtime v4.0.30319), WinForms | Chương trình chính: giao diện, logic auto, điều khiển game |
| `iAuto.tieudattai.x86.dll` (864 KB) | PE32 x86 DLL native | C++ (MSVC, ATL/STL), PDB `E:\iAuto x96 - Copy\Source\tieudattai\Release\tieudattai.pdb` | DLL được tiêm vào `Game.exe` (client TLBB 32-bit) để chạy lệnh Lua trong game |
| `iAuto.tieudattai.dll` (13 KB) | PE32+ x64 DLL native | C++ (MSVC), PDB `...\x64\Release\Hook.pdb` | Hook message cửa sổ (`SetWindowsHookExW`), export `SetHook/UnHook/GetMSG`, message `WM_SIMPLE_HOOK_WRITE` |
| `iAuto.Update.exe` (60 KB) | PE32+ x64, .NET | C# WinForms, không làm rối | Trình cập nhật |
| `-iAuto.ini` | INI | | Cấu hình: tài khoản iAuto, đường dẫn Game.exe, chuỗi tùy chọn đã mã hóa (`xxxx`, `yyyy`), bảng `[Fake]` |
| `iAuto.Login/#0.xml` | XML | | Danh sách tài khoản game cho auto đăng nhập (user, mật khẩu, server, nhân vật, cấp, môn phái...) |
| `iAuto.Go.json` | JSON | | Danh sách điểm đến/bãi train: tên bãi → `x,y,mapId` |

Thông tin phiên bản: AssemblyVersion `11.180.0.0`, ProductName `tieudattai`, Copyright 2025. TimeDateStamp của iAuto.exe là giá trị giả (build deterministic), không dùng được làm ngày build.

## 2. Packer / obfuscator

- `iAuto.exe` **không bị pack** kiểu native (chỉ có 2 section `.text` + `.rsrc`, không có overlay, entropy `.text` 6.54 là bình thường cho .NET lớn).
- Làm rối bằng **ConfuserEx v1.0.0** (thấy chuỗi `ConfusedByAttribute` và `ConfuserEx v1.0.0` trong file).
  - Đổi tên: 874/883 type nằm ở namespace rỗng, tên là chuỗi ký tự ASCII ngẫu nhiên 25 ký tự hoặc chuỗi ký tự Unicode vô hình (U+200B–U+206F), đúng kiểu rename của ConfuserEx. 20 resource `.resources` cũng bị đổi tên.
  - **Chuỗi hằng không bị mã hóa**: heap #US có ~9.600 chuỗi đọc được trực tiếp (Lua script, URL, nhãn giao diện tiếng Việt). Không thấy `DynamicMethod`/`ILGenerator`, nên nhiều khả năng không bật constants/anti-tamper mạnh; 11.144/11.429 method có thân IL bình thường.
  - Thư viện đi kèm bị merge vào: **websocket-sharp** (namespace `WebSocketSharp`, `WebSocketSharp.Net`).
- Muốn đọc code C#: dùng de4dot (hỗ trợ ConfuserEx 1.0) để gỡ rename/control-flow rồi mở bằng dnSpy/ILSpy. Máy hiện chưa có các tool này.
- `iAuto.Update.exe` không làm rối. Hai DLL native không pack.

## 3. Kiến trúc và luồng hoạt động

```
iAuto.exe (x64, .NET)
 ├─ CreateProcess(Game.exe, suspended) / OpenProcess vào client đang chạy
 ├─ Tiêm iAuto.tieudattai.x86.dll vào Game.exe (WOW64):
 │    VirtualAllocEx + WriteProcessMemory + CreateRemoteThread(LoadLibraryA)
 │    (có code tự tìm kernel32 x86 trong tiến trình đích, tự parse PE để lấy địa chỉ hàm)
 ├─ Patch bộ nhớ game: phá mutex chống mở nhiều client, giả MAC/UUID
 │    (log: "Patch mutex", "fakeMac=", "uuid OK", "gai OK", "gaa OK", "git OK")
 ├─ Giao tiếp với DLL trong game qua message cửa sổ (WM_iAuto, SetWindowLong/CallWindowProc),
 │    shared memory (CreateFileMapping) → gửi chuỗi Lua cho game chạy, nhận kết quả về
 ├─ Đọc RAM game (ReadProcessMemory) lấy HP, toạ độ, map...
 └─ iAuto.tieudattai.dll (x64): hook message toàn cục, dùng cho phím tắt / điều khiển cửa sổ
```

DLL x86 nhận diện nhiều bản client qua tên lớp cửa sổ: `TianLongBaBu`, `TianLongBaBuHJ`, `TianLongBaBuPL`, `TianLongBaBuTK`, `TLBB_KIMDUNG`, `TL_BachChien`. Nó chứa sẵn các lệnh Lua như `AutoRunToTarget(x,y)`, `PlayerPackage:UseItem(n)`, `QuestFrameOptionClicked(...)`, `GameProduceLogin:MoveToCharacter(n)`, `DataPool:ReConnect()`, cùng các hàm `Set_XSCRIPT_*`/`Send_XSCRIPT()` để gọi script phía server.

P/Invoke đáng chú ý trong iAuto.exe: `OpenProcess`, `VirtualAllocEx`, `WriteProcessMemory`, `ReadProcessMemory`, `VirtualProtectEx`, `CreateRemoteThread`, `SuspendThread/ResumeThread`, `Get/SetThreadContext`, `NtQueryInformationProcess`, `NtQuerySystemInformation`, `NtQueryObject` + `DuplicateHandle` (tìm và đóng handle mutex của game), GDI `BitBlt/GetPixel` (đọc màu màn hình), `RegisterHotKey`, `mciSendString` (phát âm thanh cảnh báo).

## 4. Chức năng chính (suy ra từ chuỗi giao diện và Lua)

- **Quản lý nhiều tài khoản**: auto đăng nhập, chọn server/nhân vật, tự relog khi mất kết nối, ẩn/hiện/sắp xếp cửa sổ game, giới hạn số game mở.
- **Train/đánh quái**: đi tới bãi theo `iAuto.Go.json`, chỉ đánh/chỉ nhặt, ưu tiên mục tiêu, buff skill, hồi máu, về thành, sửa đồ, bán đồ theo danh sách (`SellName`).
- **Nhiệm vụ hằng ngày và cốt truyện**: nhiệm vụ sư môn, bang hội (thương nghiệp, khoa kỹ, xây dựng...), Tàng Bảo Đồ, Ác Bá/Mã Tặc, Thử Tài Vận May, nhận giờ x2, nhiệm vụ cốt truyện theo NPC và toạ độ ghi sẵn.
- **Phụ bản/boss**: kịch bản né chiêu cho từng boss (Ngũ Hành, Lý Thu Thủy, Thiên Sơn Đồng Lão, Mộ Dung Bác, Tiêu Viễn Sơn...): "Tản đội hình", "Né bẫy", "Gom đội".
- **Tổ đội**: tự nhận/duyệt đơn xin vào đội, đi theo trưởng nhóm, đánh theo key; phím tắt toàn cục (Ctrl+Q đánh theo key, Ctrl+U/D lên/xuống ngựa, Ctrl+K bật skill, Ctrl+Shift+O chỉ đánh...).
- **Chế tạo / cường hoá**: đục lỗ, khảm bảo thạch, học phối phương, luyện võ hồn, thần khí.
- **Trả lời câu hỏi chống auto của game** (các màn `TextValidate`, `Anti_GAuto`, "mã captcha", tính phép cộng/trừ/nhân).
- **Cảnh báo**: âm thanh/giọng nói khi bị PK, sắp hết máu, chết, mất kết nối. Có dùng API chuyển văn bản thành giọng nói (header `api-key`, `voice: lannhi`, kiểu FPT.AI).
- **Kết nối giữa các máy**: chat/gom tài khoản giữa nhiều máy qua WebSocket `wss://microauto.org:8443` ("Nhận gom máy khác").

## 5. Mạng, tài khoản và bản quyền (chỉ mô tả)

- Đăng nhập tài khoản iAuto bằng email/mật khẩu; có màn đăng ký, đổi mật khẩu, nhập giftcode, thanh toán qua mã VietQR.
- Máy chủ: `tieudattai.org` (ví dụ `s4.php?email=...`), `microauto.org`, và vài IP cứng (68.183.181.185, 157.230.46.175, 14.225.202.84, 222.255.217.199...).
- Gửi kèm **HWID** lấy qua WMI: UUID mainboard (`Win32_ComputerSystemProduct`), serial `Win32_BaseBoard`, `Win32_BIOS`, `ProcessorId`, serial ổ đĩa, `MachineGuid` trong registry.
- Có khoảng 80 email gắn cứng trong code, xen kẽ với logic tính năng, nhiều khả năng là các tuỳ biến riêng cho từng khách.

## 6. Trình cập nhật

`iAuto.Update.exe` tải `http://68.183.181.185/iAuto.x64.zip` qua **HTTP thường** (không mã hoá, không kiểm tra chữ ký), giải nén đè vào thư mục rồi chạy `iAuto.exe` với quyền admin (`runas`). Ai chặn được đường truyền đều có thể thay file thực thi.

## 7. Lưu ý bảo mật cho bạn

- `-iAuto.ini` lưu **mật khẩu tài khoản iAuto dạng chữ thường**, và `iAuto.Login/#0.xml` lưu **mật khẩu các tài khoản game dạng chữ thường**. Không nên chia sẻ thư mục này; nếu đã từng chia sẻ thì nên đổi mật khẩu.
- Tool tiêm DLL, sửa bộ nhớ game và giả MAC/HWID, nên phần mềm diệt virus có thể báo động, và việc dùng có thể vi phạm điều khoản của game.
- Cơ chế cập nhật qua HTTP rồi chạy với quyền admin là rủi ro thật.

## 8. Mã nguồn đã dịch ngược (cập nhật 18/10/2026)

**Công cụ** (tải từ GitHub chính thức, để ở `E:\TLBB\tools`):
- `de4dot\` : de4dot-cex 4.0.0 (bản fork của de4dot chuyên cho ConfuserEx)
- `dnSpy\` : dnSpyEx 6.6.0 bản win64 (`dnSpy.exe` là giao diện, `dnSpy.Console.exe` dùng để xuất project)

**Các bước đã chạy** (trên bản sao, file gốc không bị sửa):
1. `de4dot-x64.exe iAuto.exe -o iAuto-clean.exe` → de4dot báo "Detected ConfuserEx v1.0.0", gỡ làm rối và đổi tên lại toàn bộ symbol.
2. `dnSpy.Console.exe -o src_iAuto iAuto-clean.exe` → 382 file `.cs` + `solution.sln`. Updater cũng được xuất ra `src_Update`.

**Kết quả** nằm ở `E:\TLBB\iAuto_decomp\`:
- `iAuto-clean.exe` : bản đã gỡ làm rối, mở bằng `E:\TLBB\tools\dnSpy\dnSpy.exe` để duyệt và debug
- `src_iAuto\solution.sln` : project C# mở được bằng Visual Studio
- `src_Update\` : mã updater

Mã sau khi gỡ đọc được tốt: control flow đã sạch, chuỗi giữ nguyên. Tên các Form/UserControl vẫn còn (GUI, TabLogin, Setting, Debug, ScriptManager, CanQuet, Univer, TabChat, LoginUser...). Các class nội bộ bị đổi tên thành `ClassNNN`/`GClassNN`, nên bảng dưới đây ghi vai trò mà mình suy ra từ code.

### Bản đồ module chính

| File | Vai trò |
|---|---|
| `Class273.cs` | Entry point `Main()`: tự xin quyền admin (runas), đóng instance cũ, mutex "iAuto", chạy form `GUI` |
| `GUI.cs` / `GUI.Designer.cs` | Cửa sổ chính, danh sách nhân vật, nạp `iAuto.Go.json`, `iAuto.Login` |
| `Class106.cs` (1,7 MB) | **Bộ não auto của từng nhân vật**: vòng lặp train, nhiệm vụ, phụ bản, né chiêu boss, nhặt đồ, thu thập (`Gather`), vào phụ bản (`GoEntry`, `InsideInstance`)... |
| `Class527.cs` | Trạng thái game của một nhân vật đọc từ RAM: HP/MP, map, toạ độ, danh sách object/NPC |
| `Class502.cs` | Dò chữ ký bộ nhớ (pattern `XXXX`, `??`) để tìm địa chỉ trong Game.exe theo từng profile client |
| `Class512.cs`, `Class520.cs` | Thư viện lệnh Lua gửi vào game (`PlayerPackage:UseItem`, `QuestFrameAcceptClicked`, `SelectTargetOfTarget`...) |
| `Class104.cs`, `Class296.cs`, `Class297.cs`, `Class515.cs`, `GClass41.cs` | Tiêm DLL x86 vào Game.exe: tìm kernel32 x86, tạo stub, `CreateRemoteThread(LoadLibraryA)` |
| `Class95.cs`, `GClass32.cs`, `GClass34.cs`, `Class88.cs`, `Class90.cs` | **Trình khởi động/patch game**: mở Game.exe ở trạng thái suspended, chờ ASPack tự giải nén, phá mutex chống mở nhiều client, hook `GetAdaptersInfo`/`GetAdaptersAddresses`/`GetIfTable`/`UuidCreateSequential` để mỗi client có MAC/UUID giả; ghi log `TnclGameLaunch.log`, `TnclPluginWatch.log` |
| `Class212.cs` | Xử lý plugin của client (`Plugin_ParticleFX3.dll`, `Plugin_ClientManager.dll`) |
| `Class226.cs` | Đọc/ghi `-iAuto.ini` (GamePath, Teams, GomName, TuyenChien...) |
| `TabLogin.cs` | Quản lý danh sách tài khoản game (`iAuto.Login/*.xml`), relog, reset 0h, fake name |
| `Setting.cs` | Tab cấu hình (hồi sinh, xuống ngựa, tổ đội tự động, Trim CPU...) |
| `CanQuet.cs` | "Càn quét" phụ bản hằng ngày (Phiêu Miễu Phong, Yến Tử Ô, Thiếu Thất Sơn, Tam Thần Huyễn Cảnh, Lang Hoàn Phúc Địa...) |
| `Univer.cs` | Thao tác hàng loạt: gom KNB, cất/lấy Thiên Cơ, treo shop, kết bạn |
| `ScriptManager.cs`, `Control3.cs`, `Class379.cs` | Trình soạn/chạy script tự viết; `Control3` là ô soạn code FastColoredTextBox |
| `Debug.cs` | Công cụ debug: liệt kê object trong game, xuất NPC thành code C# |
| `Class228.cs`, `Class238.cs`, `TabChat.cs` | Chat và "gom" tài khoản giữa nhiều máy qua WebSocket (lệnh `#IGOM|...`) |
| `GClass4`…`GClass29`, `Class31`, `Class53`, `Class59`, `Class62`, `Class81` | Thư viện websocket-sharp được merge vào |
| `Class530.cs`, `Class531.cs`, `Class572.cs`, `Class576.cs`, `Class584.cs`, `Class501.cs` | Dữ liệu tĩnh: NPC, toạ độ, map, bảng tra |
| `Class534.cs` | Xử lý cửa sổ game: ẩn/hiện, tự đóng hộp thoại lỗi |
| `LoginUser.cs`, `LoginiAuto.*`, `_i\Properties\Settings.Designer.cs` | Đăng nhập/đăng ký tài khoản iAuto và cấu hình máy chủ (`http://68.183.181.185/iauto/i.php`), kèm khoá dùng cho kiểm tra bản quyền. Mình chỉ ghi nhận vị trí, không phân tích hay sửa phần này |

### Còn thiếu
- DLL native `iAuto.tieudattai.x86.dll` (C++) chưa được decompile. Nếu cần, bước tiếp theo là đưa nó vào Ghidra.
- Project C# chưa được build lại; khi build có thể phải sửa lỗi nhỏ do decompiler sinh ra.

## 9. DLL native (Ghidra) và build lại C# (cập nhật 18/10/2026)

### 9.1 Decompile DLL bằng Ghidra
Công cụ: Ghidra 12.1.4 + JDK 21 (Temurin) ở `E:\TLBB\tools`. Chạy headless qua Task Scheduler bằng `E:\TLBB\iAuto_decomp\ghidra\run_ghidra.bat`, script xuất C là `ghidra\scripts\ExportDecompiled.java`.

Kết quả ở `E:\TLBB\iAuto_decomp\ghidra\`:
- `iAuto.tieudattai.x86.c` : 5.719 hàm (3 hàm lỗi). Phần lớn là CRT/STL của MSVC; code riêng của tác giả nằm quanh `0x10009c20`–`0x1000ce00` và `0x100140a0`.
- `iAuto.tieudattai.x64.c` : 63 hàm.

Cách DLL x86 hoạt động (đọc từ code Ghidra):
- **Cách nạp vào game**: export `SetHook(hwnd)` gọi `SetWindowsHookExA(WH_GETMESSAGE, FUN_10009c20, ...)` vào thread giao diện của Game.exe, nên Windows tự nạp DLL vào tiến trình game. `UnHook` gỡ hook.
- **Kênh lệnh**: `FUN_10009c20` thay WndProc của cửa sổ game (`SetWindowLongA`/`CallWindowProcA`) và nhận message `WM_iAuto` (`RegisterWindowMessage`). `wParam` là mã lệnh: khoảng 0x02–0x3d là các lệnh chạy Lua có sẵn (nhận nhiệm vụ, `SelectRole_EnterGame()`, `DataPool:ReConnect()`, cho pet ăn, chat, nhặt đồ...); 0x29a/0x29b/0x29c bật chặn gói tin; 0x71 gỡ hook; 0x478 tắt chặn recv.
- **Chạy Lua**: DLL gọi thẳng hàm script nội bộ của game qua con trỏ hàm (`DAT_100cdf20`, `DAT_100cffac`, `DAT_100cffd0`). Địa chỉ các hàm này do iAuto.exe dò trong RAM game (`Class502.cs`) rồi gửi sang.
- **Chặn gói tin mạng**: `InstallHook` ghi lệnh `JMP` đè lên đầu `ws2_32!send`. Lệnh 0x29a cho DLL kết nối TCP tới `127.0.0.1:34560` và móc `recv`/`send`, gửi bản sao gói tin về iAuto. Phía iAuto nghe cổng này ở `Class253.cs` (`TcpListener` port 34560) để đọc chat, toạ độ, thông báo NPC...
- DLL x64 nhỏ (`Hook.dll`) chỉ làm hook message `WM_SIMPLE_HOOK_WRITE` cho phía x64.

Ghi chú: `Res_369A2264` (Properties.Resources) của iAuto.exe nhúng sẵn `tieudattai`, `tieudattai_x86`, `Update`, `Game`, `INI`, `scripts`, `Missions`... tức là exe tự giải nén DLL và updater ra đĩa.

### 9.2 Build lại project C#
Kết quả: **build thành công, 0 lỗi** (2.718 cảnh báo vô hại). File build ra là `E:\TLBB\iAuto_decomp\src_build\iAuto\bin\Release\iAuto.exe` (13,3 MB, AssemblyVersion 11.180.0.0, resource của các form đúng tên).

Mã nguồn build được nằm ở `E:\TLBB\iAuto_decomp\src_build\` (mở `solution.sln`). Đây là bản nên dùng thay cho `src_iAuto` cũ.

Các bước đã làm:
1. `sanitize.ps1` (dnlib): đổi các tên ConfuserEx còn sót (ký tự vô hình, ký tự lạ) thành tên hợp lệ, đặt tên đúng cho các hàm implement interface/override, đánh số các hàm trùng tên trùng chữ ký, đổi tên resource → `iAuto-clean2.exe`.
2. dnSpy.Console với `--no-yield --no-async` → `src2`, sau đó copy sang `src_build`.
3. Sửa lỗi decompiler bằng script (`patch_src.py`, `fix_errors.py`, `loopexit_fix.py`, `loopexit2.py`, `manual_fixes.py`) và sửa tay khoảng 15 chỗ: các `goto` nhảy vào giữa khối, gọi `base..ctor()`, `??` trên kiểu bool, ép kiểu byte, `fieldof(...)`, `ref` local...
4. Build bằng MSBuild 2019 (`build_only.sh`), target .NET Framework 4.8.

Chạy lại từ đầu bằng: `sanitize.ps1` → `rebuild.sh` (decompile + build) → các script sửa ở trên.

**Chưa kiểm chứng lúc chạy**: mình không chạy bản build lại, vì nó đòi quyền admin, tiêm DLL vào game và kết nối server. Có vài chỗ mình viết lại luồng điều khiển cho tương đương: `GClass7.method_28` (vòng xử lý message websocket), `Class106.method_150`, `Class11.smethod_1`, `Class357.method_44`, `Control3.method_111`/`vmethod_60`, `Class90` (vòng chờ ASPack). Nếu bản build chạy sai, nên xem các chỗ này trước. Phần kiểm tra bản quyền được giữ nguyên, mình không sửa.

## 10. Đánh giá lại sau khi build (18/10/2026)

### Đã kiểm tra
- **So sánh IL** giữa bản gốc đã gỡ rối (`iAuto-clean2.exe`) và bản build lại: 11.390 so với 11.395 method; 171 method có số lệnh gọi khác nhau. Phần lớn là khác biệt bình thường giữa hai trình biên dịch (switch trên chuỗi, event accessor) hoặc do code bị nhân đôi khi gỡ `goto`. Cặp `Class52`/`Class53` (xác thực Basic/Digest) trông như bị lệch, nhưng mình đã đối chiếu từng chuỗi và xác nhận chúng khớp.
- **Rà lại 79 chỗ `goto` đã sửa** bằng `audit_gotos.py`: chỉ có 5 chỗ nhảy vào khối `try`. Bốn chỗ đã sửa đúng; chỗ còn lại là một lỗi thật, đã sửa:
  - `LoginiAuto.method_1` (đăng nhập iAuto): bản gốc thử lại liên tục mỗi 100 ms cho tới khi gọi được server. Bản build đầu chỉ thử thêm 1 lần, và lần đó không có try/catch, nên nếu mạng lỗi thì sẽ ném exception. Mình đã khôi phục vòng lặp (`fix_login_retry.py`) và build lại với 0 lỗi.
- **Cảnh báo biên dịch** (2.700): gần như toàn bộ là field không dùng hoặc không gán (CS0649/CS0169: cache lambda, struct P/Invoke, field thừa có sẵn trong bản gốc). 23 cảnh báo so sánh tham chiếu `Tag == "..."` (CS0252) giữ đúng hành vi của bản gốc.
- Mã nguồn `src_build` đã được đưa vào git cục bộ (commit đầu `9df0383`) để theo dõi các lần sửa sau.

### Các bước nên làm tiếp (theo thứ tự ưu tiên)
1. **Chạy thử chức năng thật** với game: đăng nhập, mở game, tiêm DLL, auto train/nhiệm vụ. Ưu tiên các hàm đã viết lại ở mục 9.2. Cách tốt nhất là chạy song song với bản gốc trên cùng một nhân vật.
2. **Thay bản đang chạy** (PID 7744) bằng bản mới có sửa lỗi đăng nhập. Bản đang chạy được build trước khi sửa.
3. **Đặt tên lại các class chính** (`Class106` → `CharacterBot`, `Class527` → `GameState`, `Class95` → `GameLauncher`...) bằng refactor trong Visual Studio, theo bảng ở mục 8. Khoảng 800 class `ClassNNN` hiện rất khó đọc.
4. **DLL x86**: cho Ghidra nhận diện thư viện MSVC/STL (Function ID / FLIRT) để loại khoảng 4.000 hàm thư viện. Sau đó đặt tên cho khoảng 30 hàm của tác giả (WndProc, hook send/recv, bảng lệnh Lua). Mã C xuất từ Ghidra chỉ để đọc, không biên dịch lại được.
5. **Lưu ý bảo mật** (không đổi so với mục 7): mật khẩu lưu dạng chữ thường, updater dùng HTTP rồi chạy với quyền admin, API key gắn cứng trong code.
