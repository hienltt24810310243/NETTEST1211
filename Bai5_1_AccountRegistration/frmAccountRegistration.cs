using System;
using System.Windows.Forms;

namespace Bai5_1_AccountRegistration
{
    public partial class frmAccountRegistration : Form
    {
        public frmAccountRegistration()
        {
            InitializeComponent();
            ResetForm();
        }

        private void btnRegister_Click(object? sender, EventArgs e)
        {
            if (KiemTraDuLieuDauVao())
            {
                string gender = rdoMale.Checked ? "Nam" : "Nữ";
                string thongTin = $"Đăng ký tài khoản thành công!\n\n" +
                                  $"- Tên đăng nhập: {txtUsername.Text.Trim()}\n" +
                                  $"- Ngày sinh: {dtpBirthDate.Value:dd/MM/yyyy}\n" +
                                  $"- Giới tính: {gender}";

                MessageBox.Show(thongTin, "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool KiemTraDuLieuDauVao()
        {
            epCheck.Clear();
            bool hopLe = true;

            // 1. Kiểm tra Tên đăng nhập
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                epCheck.SetError(txtUsername, "Tên đăng nhập không được để trống!");
                hopLe = false;
            }

            // 2. Kiểm tra Mật khẩu
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                epCheck.SetError(txtPassword, "Mật khẩu không được để trống!");
                hopLe = false;
            }

            // 3. Kiểm tra Xác nhận mật khẩu
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                epCheck.SetError(txtConfirmPassword, "Vui lòng nhập lại mật khẩu!");
                hopLe = false;
            }
            else if (!string.IsNullOrEmpty(txtPassword.Text) && txtConfirmPassword.Text != txtPassword.Text)
            {
                epCheck.SetError(txtConfirmPassword, "Mật khẩu nhập lại không khớp với mật khẩu ban đầu!");
                hopLe = false;
            }

            // 4. Kiểm tra Độ tuổi >= 18
            DateTime birthDate = dtpBirthDate.Value.Date;
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age))
            {
                age--;
            }

            if (age < 18)
            {
                epCheck.SetError(dtpBirthDate, "Độ tuổi người dùng phải từ 18 tuổi trở lên (Hiện tại: " + age + " tuổi)!");
                hopLe = false;
            }

            // 5. Kiểm tra Điều khoản dịch vụ
            if (!chkAgreeTerms.Checked)
            {
                epCheck.SetError(chkAgreeTerms, "Bạn phải tích chọn đồng ý với Điều khoản dịch vụ để tiếp tục!");
                hopLe = false;
            }

            return hopLe;
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            epCheck.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            dtpBirthDate.Value = DateTime.Today.AddYears(-18); // Mặc định 18 tuổi
            rdoMale.Checked = true;
            chkAgreeTerms.Checked = false;
            txtUsername.Focus();
        }
    }
}
