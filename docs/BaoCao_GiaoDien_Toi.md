# Rà soát giao diện tối của LAuto v2 (2026-10-18)

Phạm vi: `src/iAuto` tại commit `aedf48a`. Tôi chỉ đọc code, không sửa file nào.

## 1. Nguyên nhân gốc

Toàn bộ theme nằm trong `GUI.ApplyModernDarkCyberTheme()` và `StyleAllChildControls()` (`GUI.cs` từ dòng 12074). Cách làm hiện tại là duyệt cây control **một lần** và chỉ tô màu cho 7 loại: `ListView`, `ComboBox`, `TextBox`, `CheckBox`, `RadioButton`, `Label`, `Panel`. Cách này hỏng vì bốn lý do:

1. **Đổi màu chữ nhưng không đổi màu nền.** `CheckBox`, `RadioButton` và `Label` được đặt chữ sáng (241,245,249), trong khi nền thật nằm ở control cha (UserControl, GroupBox, Button) và vẫn trắng. Kết quả là **chữ trắng trên nền trắng**.
2. **UserControl không phải `Panel`, nên bị bỏ qua.** Bản thân `Setting`, `TabLogin`, `Univer`, `TabChat`, `ToDoi`, `AutoMap`, `CanQuet`, `Alarm`, `CheckBoxNumberControl`, `CheckBoxComboControl` đều kế thừa `UserControl`. Trong designer, nhiều control đặt cứng `this.BackColor = Color.White` (`Setting.Designer.cs`, `TabLogin.Designer.cs`, `Univer.Designer.cs`, `GUI.Designer.cs`), nên các tab này vẫn trắng.
3. **`ForeColor` được kế thừa từ control cha.** Mọi control không tự đặt màu chữ đều nhận chữ sáng từ TabPage. Những control mà hệ thống vẽ nền sáng (Button, NumericUpDown, TrackBar, header ListView) vì vậy cũng thành chữ trắng trên nền sáng.
4. **Theme chỉ chạy khi gọi tay.** Nó chạy ở `GUI.cs:124`, `:6618` và khi bấm nút Làm mới. Control tạo sau thời điểm đó không được tô, ví dụ `CanQuet` tạo ở `GUI.cs:6985`, các form phụ, các dòng thêm sau. Toàn bộ hàm còn bọc trong `try { } catch { }`, nên một lỗi bất kỳ sẽ âm thầm bỏ qua phần còn lại.

## 2. Bảng kiểm control chưa đồng bộ

Đếm theo các file `*.Designer.cs`:

| Loại control | Số lượng | Hiện trạng | Triệu chứng | Cách sửa |
|---|---|---|---|---|
| `Button` | 77 (38 trong GUI, nhiều trong Setting/TabLogin) | `UseVisualStyleBackColor = true`, chưa được tô | Nút trắng, chữ trắng (Pay: Send/Use/Change; nút bên phải tab Login) | `FlatStyle.Flat`, `UseVisualStyleBackColor = false`, nền (30,41,59), chữ (241,245,249), viền (51,65,85); hover/pressed qua `FlatAppearance.MouseOverBackColor` và `MouseDownBackColor` |
| `CheckBox` | 114 (77 trong Setting) | Chỉ đổi chữ; 77 cái trong Setting có `UseVisualStyleBackColor = true` | Chữ trắng trên nền UserControl trắng (Tự Động, Phụ Bản, Hiệu Suất; Stop/Wait/Relog) | Xử lý nền cha (mục 3); đặt `BackColor = Transparent` và `UseVisualStyleBackColor = false` |
| UserControl (`Setting`, `TabLogin`, `Univer`, `TabChat`, `ToDoi`, `AutoMap`, `CanQuet`, `Alarm`, `LoginUser`, `MessBox`, `CheckBoxNumberControl` ×17, `CheckBoxComboControl` ×7) | ~40 | Không được tô (không phải `Panel`); designer đặt cứng `White` | Nền trắng toàn tab Setting, Login, Config | Thêm nhánh `UserControl` / `ContainerControl` vào bộ tô |
| `GroupBox` + `Class286` (GroupBox tự viết) | 14 + 10 | Không được tô; viền do visual style vẽ màu sáng | Viền trắng quanh groupbox (tab Pay/Info, Setting) | Tự vẽ GroupBox: `Class286` override `OnPaint`, tô nền, viền (51,65,85) và tiêu đề màu cyan; GroupBox thường thay bằng `Class286` |
| `NumericUpDown` | 30 | Không được tô | Ô số trắng, chữ trắng | `BackColor` (15,23,42), `ForeColor` sáng, `BorderStyle.FixedSingle`; nút lên/xuống phải dùng `SetWindowTheme` (mục 3.3) |
| `Control0` (TrackBar tự viết) | 8 | Bảng màu cứng `Color.White`, `Gainsboro`, `Silver` (`Control0.cs:19-46`) | Thanh Delay Auto nền trắng | Thêm bảng màu tối vào mảng màu, hoặc cho property chọn palette |
| `ListView` / `ListViewEx` | 15+ | Thân đã tối; **header cột** và **thanh cuộn** do hệ thống vẽ | Header trắng, thanh cuộn ngang trắng (tab Login) | `OwnerDraw = true` + `DrawColumnHeader` (DrawItem/DrawSubItem đặt `DrawDefault = true`), hoặc `SetWindowTheme(header, "DarkMode_ItemsView")`; thanh cuộn dùng `SetWindowTheme(lv.Handle, "DarkMode_Explorer", null)` |
| `RichTextBox` | 1 | Kế thừa `TextBoxBase`, không phải `TextBox`, nên bị bỏ qua | Khung trắng | Đổi nhánh `TextBox` thành `TextBoxBase` |
| `ListBox` / `TreeView` / `DataGridView` / `PropertyGrid` | 2 / 1 / 1 / 5 | Không được tô | Khung list trắng (Setting, Config) | Tô `BackColor` và `ForeColor`; DataGridView cần `DefaultCellStyle`, `ColumnHeadersDefaultCellStyle`, `EnableHeadersVisualStyles = false`, `GridColor`; PropertyGrid cần `ViewBackColor`, `LineColor`, `HelpBackColor`… |
| `SplitContainer` | 13 | Hai panel được tô vì là `Panel`, nhưng thanh chia lấy màu của SplitContainer | Vạch trắng giữa hai khung | Tô `BackColor` của SplitContainer (51,65,85) |
| `LinkLabel` | 1 | Đã đổi `LinkColor` ở tab Info; các LinkLabel khác giữ màu xanh mặc định | Chữ xanh đậm khó đọc | Đặt `LinkColor` (56,189,248) cho mọi LinkLabel trong bộ tô |
| `Label` màu `GrayText` | 12 | Bộ tô chỉ đổi Label đen; GrayText (109,109,109) trên nền tối thì tương phản thấp | Chữ xám mờ | Đổi `GrayText` thành (148,163,184) |
| `GClass35` (ProgressBar) | 1 | Visual style vẽ xanh lá trên nền trắng | Thanh trắng | Tự vẽ, hoặc `SetWindowTheme(handle, "", "")` rồi đặt `ForeColor`/`BackColor` |
| `Control3` (editor script) và `Class307` | 1 / 1 | Code đặt cứng `BackColor = Color.White` (`Control3.cs:45`, `Class307.cs:19`) | Khung soạn script trắng | Đổi màu nền, chữ, dòng chọn, lề số dòng |
| `ContextMenuStrip` (menu chuột phải) | ~25 (GUI 12, TabLogin 3, ToDoi 4, …) | Chỉ `menuMain` có renderer tối | Menu chuột phải nền trắng | Gán `ModernDarkToolStripRenderer` cho mọi ToolStrip, hoặc đặt `ToolStripManager.Renderer` một lần lúc khởi động |
| Menu hàng 2 (Player/Hourly/Quest/Fuben/All/i/Go) | 668 mục | Đã tối, nhưng `OnRenderItemText` luôn ép chữ sáng; `ModernDarkColorTable` chưa có màu cho mục được tick | Mục bị khoá trông như mục bật; ô tick màu xanh nhạt mặc định | Chữ xám (100,116,139) khi `!e.Item.Enabled`; override `CheckBackground`, `CheckSelectedBackground`, `CheckPressedBackground`, `ButtonCheckedGradient*` |
| Form phụ (`Debug`, `ScriptManager`, `FindForm`, `ReplaceForm`, `HotkeysEditorForm`, `GoToForm`, `Code`, `AutoPkEx`) | 8 form | Không gọi theme | Toàn bộ form trắng | Gọi chung một hàm `Theme.Apply(form)` trong `OnLoad` của từng form |
| Mọi control bị `Enabled = false` | — | WinForms vẽ chữ bằng `SystemColors.GrayText`, bỏ qua `ForeColor` | Chữ xám trên nền tối, rất mờ | Với CheckBox/Label bị khoá, tự vẽ chữ bằng màu (100,116,139); hoặc giữ `Enabled` và chặn tương tác bằng `AutoCheck = false` |

Theo từng tab:
- **Game:** ListView chính có header trắng; các nút dưới tab Key/Life/Craft là Button chưa tô; NumericUpDown % HP/MP.
- **Login (`TabLogin`):** nền UserControl trắng, nên Stop/Wait/Relog thành chữ trắng trên nền trắng; nút bên phải; thanh cuộn ngang và header ListView; menu chuột phải.
- **Pay/Info:** GroupBox vẫn để visual style vẽ viền sáng; các nút không có trong danh sách tô tay (Send/Use/Change…) vẫn mặc định; ô "+35 Days" và "Sign Out" là Button/TextBox với `Enabled = false`, nên chữ bị vẽ bằng màu xám hệ thống.
- **inbox:** ListView header và thanh cuộn.
- **Setting (`Setting`):** 77 CheckBox trên nền UserControl trắng (lỗi nặng nhất); TrackBar `Control0`; NumericUpDown; ListBox.
- **Config (`Univer` + `ToDoi`/`AutoMap`/`CanQuet`/`Alarm`):** UserControl trắng; TreeView; PropertyGrid; DataGridView; `CanQuet` tạo lúc chạy nên không được tô.
- **Chat (`TabChat`):** RichTextBox; nút Send.

## 3. Cách sửa triệt để (đề xuất)

### 3.1 Gom theme vào một lớp riêng, chạy tự động
Tạo `DarkTheme.cs` (static) với bảng màu đặt tên rõ ràng: `Bg` (18,24,36), `Surface` (26,34,52), `Input` (15,23,42), `Border` (51,65,85), `Text` (241,245,249), `TextMuted` (148,163,184), `TextDisabled` (100,116,139), `Accent` (56,189,248). Hàm `Apply(Control root)`:
- Duyệt đệ quy và chọn cách tô theo kiểu control bằng `switch`. Đặt **cả `BackColor` lẫn `ForeColor`** cho mọi control, và đặt nhánh kiểu cụ thể (Button, NumericUpDown…) trước nhánh `UserControl`/`ContainerControl`.
- Đăng ký `ControlAdded` trên mỗi container, để control thêm sau (như `CanQuet`, dòng mới, form con) tự được tô.
- Không nuốt lỗi bằng `catch {}`. Ghi log, rồi bỏ qua đúng control bị lỗi.

### 3.2 Không để màu trắng cứng trong designer
Các `this.BackColor = Color.White` ở `Setting`, `TabLogin`, `Univer`, `GUI` và `UseVisualStyleBackColor = true` sẽ đè lên theme. Có hai cách:
- **Gọn nhất:** sửa trong code theme (bước 3.1 đã ghi đè lúc chạy), không đụng designer.
- **Sạch hơn:** xoá các dòng đó trong designer để màu được kế thừa từ TabPage.

### 3.3 Phần do Windows tự vẽ
Header ListView, thanh cuộn, nút của NumericUpDown, TreeView và ComboBox dropdown đều do Windows vẽ. Trên Windows 10 1809+ và Windows 11, gọi:
```csharp
[DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
static extern int SetWindowTheme(IntPtr hwnd, string app, string idList);
// sau khi handle được tạo:
SetWindowTheme(ctrl.Handle, "DarkMode_Explorer", null);
```
Gọi trong `HandleCreated`, vì handle có thể được tạo lại. Riêng header ListView cần lấy handle qua `LVM_GETHEADER` (0x101F), rồi `SetWindowTheme(header, "DarkMode_ItemsView", null)`. Thanh tiêu đề cửa sổ có thể làm tối bằng `DwmSetWindowAttribute(hwnd, 20 /*DWMWA_USE_IMMERSIVE_DARK_MODE*/, ref 1, 4)`.

### 3.4 Control tự viết
- `Control0` (TrackBar): thêm bộ màu tối vào mảng màu ở `Control0.cs:19`.
- `Class286` (GroupBox): override `OnPaint` để tự vẽ viền và tiêu đề.
- `GClass35` (ProgressBar), `Control3` (editor), `Class307`: đổi màu nền cứng.

### 3.5 Menu
Gán renderer một lần qua `ToolStripManager.Renderer = new ModernDarkToolStripRenderer()` lúc khởi động. Trong `OnRenderItemText`, dùng màu xám cho mục bị khoá. Thêm màu cho ô tick trong `ModernDarkColorTable`.

### 3.6 Kiểm tra sau khi sửa
Thêm một hàm debug duyệt toàn bộ cây control và ghi ra log mọi control có tương phản giữa `ForeColor` và `BackColor` hiệu dụng (đi ngược lên cha khi nền là `Transparent`) dưới 4.5:1. Chạy hàm này cho từng tab của cả 2 hàng, cộng các form phụ. Nhờ vậy không phải dò bằng mắt.

Thứ tự làm đề xuất: 3.1 và 3.2 (gỡ được phần lớn lỗi chữ trắng trên nền trắng), rồi 3.4 (TrackBar, GroupBox), 3.3 (header, thanh cuộn), 3.5 (menu), cuối cùng là các form phụ.

## 4. Vì sao tiêu đề hiện "Free" chứ không phải "Pro"

Tiêu đề chỉ thêm " - Pro" khi `GUI.double_0 > 0` (`GUI.cs:5062`). Biến này **chỉ được gán từ phản hồi của máy chủ bản quyền iAuto**: trường thứ 4 trong chuỗi trả về, ở `GUI.cs:11928` (`Class493.method_0`). Sau 5 lần làm mới thất bại liên tiếp, nó bị đặt lại về 0 (`GUI.cs:6510`).

Commit `58ac6d3` và `aedf48a` đã bỏ qua màn hình đăng nhập iAuto (`LoginiAuto`), nên app không còn nhận phản hồi đó. `double_0` vì vậy giữ giá trị 0, và tiêu đề hiện Free. Trước đây tiêu đề hiện Pro vì khi ấy app vẫn đăng nhập tài khoản iAuto và nhận số dư từ máy chủ.

Tôi không đề xuất cách ép hiện Pro hay mở tính năng Pro. Làm vậy là vượt qua cơ chế bản quyền của iAuto, nằm ngoài phạm vi Sandy đặt ra từ đầu (dịch ngược nhưng không đụng tới bản quyền). Cách hợp lệ để có Pro là khôi phục bước đăng nhập `LoginiAuto` và đăng nhập bằng tài khoản iAuto Pro còn hạn.

Lưu ý thêm: tab Info hiện ghi cứng "Bản Quyền: Trọn Đời", "VIP", "Hạn Dùng …: Vĩnh Viễn" (`GUI.cs`, trong `ApplyModernDarkCyberTheme`). Các dòng này không khớp với trạng thái thật (Free), nên được đề xuất đổi thành nội dung trung lập hoặc hiển thị đúng dữ liệu từ máy chủ.
