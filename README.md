# Báo Cáo Thực Hành Bài Tập Ngày 12/11 (Bài 5.1 - 5.4)

### THÔNG TIN SINH VIÊN
- **Họ và tên:** Lê Thị Thúy Hiền
- **Mã số sinh viên:** 24810310243
- **Lớp:** D19CNPM3
- **Tên môn học:** Lập trình C# / Windows Forms

---

## TỔNG HỢP DANH SÁCH BÀI TẬP & KẾT QUẢ THỰC HÀNH

### 1. [Bài 5.1: Form đăng ký tài khoản và bắt lỗi giao diện (ErrorProvider)](./Bai5_1_AccountRegistration)
- **Mục tiêu:** Sử dụng các Control cơ bản (TextBox, DateTimePicker, RadioButton, CheckBox) và kiểm tra tính hợp lệ của dữ liệu đầu vào bằng `ErrorProvider`.
- **Chức năng chính:**
  * Bắt lỗi Tên đăng nhập và Mật khẩu không được để trống.
  * Mật khẩu nhập lại phải khớp mật khẩu ban đầu (`UseSystemPasswordChar = true`).
  * Kiểm tra độ tuổi từ Ngày sinh $\ge 18$ tuổi.
  * Bắt buộc tích chọn đồng ý Điều khoản dịch vụ.
  * Nút Đăng ký (thành công báo MessageBox) và nút Làm mới.

---

### 2. [Bài 5.2: Bảng tính tiền dịch vụ và chiết khấu đơn hàng (ListBox & ComboBox)](./Bai5_2_ServiceOrderDiscount)
- **Mục tiêu:** Quản lý danh sách phần tử động bằng ListBox và ComboBox, tính toán tổng tiền và áp dụng chiết khấu đơn hàng.
- **Chức năng chính:**
  * ComboBox phân loại dịch vụ y tế: *Khám bệnh*, *Xét nghiệm*, *Chụp X-Quang*, *Vắc-xin*.
  * Chuyển đổi dịch vụ giữa danh sách khả dụng và danh sách đã chọn bằng nút `>` / `<` hoặc Double Click.
  * Nút `<<` xóa toàn bộ dịch vụ đã chọn.
  * Tự động tính toán lại Tổng tiền chưa giảm, Tỷ lệ chiết khấu (%) và Thành tiền thanh toán mỗi khi danh sách thay đổi.

---

### 3. [Bài 5.3: Form quản lý danh sách sản phẩm trong bộ nhớ (DataGridView cơ bản)](./Bai5_3_ProductManager)
- **Mục tiêu:** Định nghĩa Lớp `Product`, sử dụng `BindingSource` và `BindingList<Product>` hiển thị trên DataGridView.
- **Chức năng chính:**
  * Thêm, sửa, xóa sản phẩm có xác nhận qua MessageBox.
  * Click vào một dòng trong DataGridView đẩy ngược toàn bộ dữ liệu dòng đó lên các ô nhập liệu.
  * Định dạng đơn giá và thành tiền theo tiền tệ (`N0`, căn phải).
  * Tìm kiếm tức thời theo Tên sản phẩm.
  * Thanh StatusStrip thống kê tổng số lượng sản phẩm và tổng giá trị tồn kho.

---

### 4. [Bài 5.4: Trình quản lý tổ chức nhân sự dạng chuyên nghiệp (TreeView & ListView)](./Bai5_4_DepartmentEmployeeManager)
- **Mục tiêu:** Kết hợp `TreeView` để phân cấp dữ liệu tổ chức (Công ty $\rightarrow$ Khối $\rightarrow$ Phòng ban) và `ListView` hiển thị chi tiết ở nhiều chế độ xem.
- **Chức năng chính:**
  * Cấu trúc SplitContainer chuẩn: bên trái là TreeView cơ cấu tổ chức, bên phải là ListView nhân sự.
  * Chọn node trên TreeView lọc danh sách nhân sự tương ứng thuộc phòng ban đó.
  * Chế độ xem `Details` hiển thị rõ 4 cột: Mã NV, Họ Tên, Chức vụ, Ngày vào làm.
  * ComboBox chuyển đổi linh hoạt giữa các chế độ xem: Details, LargeIcon, SmallIcon, Tile, List.
  * ImageList đại diện trực quan cho các Node và nhân sự.
