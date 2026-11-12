namespace Bai5_1_AccountRegistration
{
    partial class frmAccountRegistration
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpPersonalInfo = new GroupBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            grpAdditionalInfo = new GroupBox();
            lblBirthDate = new Label();
            dtpBirthDate = new DateTimePicker();
            lblGender = new Label();
            pnlGender = new Panel();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            chkAgreeTerms = new CheckBox();
            btnRegister = new Button();
            btnClear = new Button();
            epCheck = new ErrorProvider(components);
            grpPersonalInfo.SuspendLayout();
            grpAdditionalInfo.SuspendLayout();
            pnlGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).BeginInit();
            SuspendLayout();
            // 
            // grpPersonalInfo
            // 
            grpPersonalInfo.Controls.Add(txtConfirmPassword);
            grpPersonalInfo.Controls.Add(lblConfirmPassword);
            grpPersonalInfo.Controls.Add(txtPassword);
            grpPersonalInfo.Controls.Add(lblPassword);
            grpPersonalInfo.Controls.Add(txtUsername);
            grpPersonalInfo.Controls.Add(lblUsername);
            grpPersonalInfo.Location = new Point(20, 20);
            grpPersonalInfo.Name = "grpPersonalInfo";
            grpPersonalInfo.Size = new Size(460, 160);
            grpPersonalInfo.TabIndex = 0;
            grpPersonalInfo.TabStop = false;
            grpPersonalInfo.Text = "Thông tin cá nhân";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(20, 35);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(110, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Tên đăng nhập:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(170, 32);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 27);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(20, 75);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(170, 72);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(20, 115);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(137, 20);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Xác nhận mật khẩu:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(170, 112);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(250, 27);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // grpAdditionalInfo
            // 
            grpAdditionalInfo.Controls.Add(chkAgreeTerms);
            grpAdditionalInfo.Controls.Add(pnlGender);
            grpAdditionalInfo.Controls.Add(lblGender);
            grpAdditionalInfo.Controls.Add(dtpBirthDate);
            grpAdditionalInfo.Controls.Add(lblBirthDate);
            grpAdditionalInfo.Location = new Point(20, 195);
            grpAdditionalInfo.Name = "grpAdditionalInfo";
            grpAdditionalInfo.Size = new Size(460, 160);
            grpAdditionalInfo.TabIndex = 1;
            grpAdditionalInfo.TabStop = false;
            grpAdditionalInfo.Text = "Thông tin bổ sung";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(20, 35);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(77, 20);
            lblBirthDate.TabIndex = 0;
            lblBirthDate.Text = "Ngày sinh:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(170, 32);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(250, 27);
            dtpBirthDate.TabIndex = 1;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(20, 75);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(68, 20);
            lblGender.TabIndex = 2;
            lblGender.Text = "Giới tính:";
            // 
            // pnlGender
            // 
            pnlGender.Controls.Add(rdoFemale);
            pnlGender.Controls.Add(rdoMale);
            pnlGender.Location = new Point(170, 70);
            pnlGender.Name = "pnlGender";
            pnlGender.Size = new Size(250, 30);
            pnlGender.TabIndex = 3;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Checked = true;
            rdoMale.Location = new Point(0, 3);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(62, 24);
            rdoMale.TabIndex = 0;
            rdoMale.TabStop = true;
            rdoMale.Text = "Nam";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(90, 3);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(50, 24);
            rdoFemale.TabIndex = 1;
            rdoFemale.Text = "Nữ";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // chkAgreeTerms
            // 
            chkAgreeTerms.AutoSize = true;
            chkAgreeTerms.Location = new Point(20, 118);
            chkAgreeTerms.Name = "chkAgreeTerms";
            chkAgreeTerms.Size = new Size(270, 24);
            chkAgreeTerms.TabIndex = 4;
            chkAgreeTerms.Text = "Tôi đồng ý với Điều khoản dịch vụ";
            chkAgreeTerms.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(140, 375);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 35);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Đăng Ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(310, 375);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 35);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm Mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // epCheck
            // 
            epCheck.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            epCheck.ContainerControl = this;
            // 
            // frmAccountRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 435);
            Controls.Add(btnClear);
            Controls.Add(btnRegister);
            Controls.Add(grpAdditionalInfo);
            Controls.Add(grpPersonalInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmAccountRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 5.1: Đăng ký tài khoản và bắt lỗi giao diện (ErrorProvider)";
            grpPersonalInfo.ResumeLayout(false);
            grpPersonalInfo.PerformLayout();
            grpAdditionalInfo.ResumeLayout(false);
            grpAdditionalInfo.PerformLayout();
            pnlGender.ResumeLayout(false);
            pnlGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPersonalInfo;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private GroupBox grpAdditionalInfo;
        private Label lblBirthDate;
        private DateTimePicker dtpBirthDate;
        private Label lblGender;
        private Panel pnlGender;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private CheckBox chkAgreeTerms;
        private Button btnRegister;
        private Button btnClear;
        private ErrorProvider epCheck;
    }
}
