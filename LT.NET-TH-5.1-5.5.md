**BÀI 5.1: FORM ĐĂNG KÝ TÀI KHOẢN VÀ BẮT LỖI GIAO DIỆN  (ERRORPROVIDER)** 

• **Mục tiêu:** Sử dụng các Control nhập liệu cơ bản (TextBox, DateTimePicker,  RadioButton, CheckBox) và kiểm tra tính hợp lệ của dữ liệu đầu vào bằng  ErrorProvider. 

• **Mô tả giao diện:** 

o Nhóm thông tin cá nhân: **Tên đăng nhập**, **Mật khẩu**, **Xác nhận mật  khẩu** (TextBox với UseSystemPasswordChar \= true). 

o Nhóm thông tin bổ sung: **Ngày sinh** (DateTimePicker), **Giới tính** (RadioButton), **Điều khoản dịch vụ** (CheckBox). 

o ErrorProvider (epCheck) dùng để gắn thông báo lỗi trực tiếp bên cạnh  các ô nhập liệu. 

o Button **Đăng Ký** và **Làm Mới**. 

• **Yêu cầu chức năng:** 

1\. Khi người dùng nhấn nút **Đăng Ký**, kiểm tra các điều kiện: 

▪ Tên đăng nhập và Mật khẩu không được để trống. 

▪ Mật khẩu nhập lại phải khớp với Mật khẩu ban đầu. 

▪ Độ tuổi tính từ Ngày sinh phải ≥ 18 tuổi. 

▪ Phải tích chọn đồng ý Điều khoản dịch vụ. 

2\. Nếu có ô nhập liệu sai, hiển thị biểu tượng cảnh báo bằng  

ErrorProvider tại đúng ô đó. Nếu tất cả hợp lệ, hiển thị MessageBox  thông báo thành công. 

**BÀI 5.2: BẢNG TÍNH TIỀN DỊCH VỤ VÀ CHIẾT KHẤU ĐƠN HÀNG  (LISTBOX & COMBOBOX)** 

• **Mục tiêu:** Quản lý danh sách phần tử động bằng ListBox và ComboBox,  thực hiện tính toán tổng tiền, áp dụng mã giảm giá.  
• **Mô tả giao diện:** 

o ComboBox (cboCategory): Danh sách loại dịch vụ (Khám bệnh, Xét  nghiệm, Chụp X-Quang, Vắc-xin). 

o ListBox (lstAvailableServices): Hiển thị danh sách dịch vụ thuộc loại  được chọn. 

o ListBox (lstSelectedServices): Hiển thị danh sách dịch vụ người dùng  đã chọn. 

o Các Button thao tác: btnSelect (\>), btnRemove (\<), btnClearAll (\<\<). 

o Nhóm tính tiền: **Tổng tiền chưa giảm**, **Tỷ lệ chiết khấu (%)**, **Thành  tiền thanh toán**. 

• **Yêu cầu chức năng:** 

1\. Khi thay đổi mục chọn trên ComboBox, load danh sách món/dịch vụ tương ứng vào lstAvailableServices. 

2\. Khi nhấn nút \> hoặc Double Click vào một item ở 

lstAvailableServices, chuyển item đó sang lstSelectedServices. 

3\. Tự động tính lại tổng chi phí dựa trên đơn giá của các dịch vụ nằm  trong lstSelectedServices mỗi khi có sự thay đổi danh sách. 

**BÀI 5.3: FORM QUẢN LÝ DANH SÁCH SẢN PHẨM TRONG BỘ NHỚ (DATAGRIDVIEW CƠ BẢN)** 

• **Mục tiêu:** Định nghĩa Lớp (Class) đối tượng Product, sử dụng  List\<Product\> làm dữ liệu nguồn (BindingSource) hiển thị trên  DataGridView. 

• **Mô tả giao diện:** 

o GroupBox **Thông tin sản phẩm**: Mã SP, Tên SP, Đơn giá, Số lượng,  Danh mục. 

o GroupBox **Chức năng**: Các nút **Thêm**, **Sửa**, **Xóa**, **Tìm kiếm** (theo  Tên SP).  
o DataGridView (dgvProducts): Cho phép hiển thị các thuộc tính của  đối tượng Product. 

• **Yêu cầu chức năng:** 

1\. Khởi tạo một lớp Product gồm các thuộc tính: ProductId,  

ProductName, UnitPrice, Quantity, Category. 

2\. Nút **Thêm**: Khởi tạo đối tượng Product từ các ô nhập liệu, thêm vào  List\<Product\> và làm mới giao diện DataGridView. 

3\. Khi Click vào một dòng trong DataGridView, đẩy ngược dữ liệu dòng  đó lên các ô nhập liệu tương ứng. 

4\. Nút **Xóa**: Xóa đối tượng đang được chọn ra khỏi danh sách sau khi  người dùng xác nhận qua MessageBox. 

**BÀI 5.4: TRÌNH QUẢN LÝ TẬP TIN DẠNG CHUYÊN NGHIỆP  (TREEVIEW & LISTVIEW)** 

• **Mục tiêu:** Sử dụng kết hợp TreeView để phân cấp dữ liệu tổ chức (Phòng  ban/Thư mục) và ListView để hiển thị danh sách chi tiết ở nhiều chế độ xem  (LargeIcon, Details, List). 

• **Mô tả giao diện:** 

o SplitContainer: 

▪ **Bên trái:** TreeView (tvDepartments) hiển thị cây phân cấp  

(Công ty \-\> Phòng ban \-\> Nhóm). 

▪ **Bên phải:** ListView (lsvEmployees) hiển thị danh sách nhân  viên thuộc nhóm/phòng ban đang chọn. 

o ImageList: Chứa biểu tượng đại diện cho các Node trên TreeView và  Icon trên ListView. 

o ComboBox cho phép chuyển đổi chế độ xem của ListView (Details,  SmallIcon, LargeIcon, Tile). 

• **Yêu cầu chức năng:**  
1\. Xây dựng cấu trúc cây dữ liệu mẫu cho TreeView khi khởi chạy ứng  dụng. 

2\. Khi người dùng click chọn một Node trên TreeView, lọc danh sách  nhân viên tương ứng thuộc Node đó và nạp vào ListView. 

3\. ListView ở chế độ Details phải hiển thị rõ các cột: **Mã NV**, **Họ Tên**,  **Chức vụ**, **Ngày vào làm**.