namespace Bai5_2_ServiceOrderDiscount
{
    partial class frmServiceOrderDiscount
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
            grpServices = new GroupBox();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblAvailable = new Label();
            lstAvailableServices = new ListBox();
            btnSelect = new Button();
            btnRemove = new Button();
            btnClearAll = new Button();
            lblSelected = new Label();
            lstSelectedServices = new ListBox();
            grpPayment = new GroupBox();
            lblSubTotal = new Label();
            txtSubTotal = new TextBox();
            lblDiscount = new Label();
            numDiscount = new NumericUpDown();
            lblDiscountUnit = new Label();
            lblTotalAmount = new Label();
            txtTotalAmount = new TextBox();
            btnReset = new Button();
            grpServices.SuspendLayout();
            grpPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDiscount).BeginInit();
            SuspendLayout();
            // 
            // grpServices
            // 
            grpServices.Controls.Add(lstSelectedServices);
            grpServices.Controls.Add(lblSelected);
            grpServices.Controls.Add(btnClearAll);
            grpServices.Controls.Add(btnRemove);
            grpServices.Controls.Add(btnSelect);
            grpServices.Controls.Add(lstAvailableServices);
            grpServices.Controls.Add(lblAvailable);
            grpServices.Controls.Add(cboCategory);
            grpServices.Controls.Add(lblCategory);
            grpServices.Location = new Point(15, 15);
            grpServices.Name = "grpServices";
            grpServices.Size = new Size(650, 310);
            grpServices.TabIndex = 0;
            grpServices.TabStop = false;
            grpServices.Text = "Chọn dịch vụ y tế";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(15, 30);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(91, 20);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Loại dịch vụ:";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(115, 27);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(200, 28);
            cboCategory.TabIndex = 1;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Location = new Point(15, 65);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(137, 20);
            lblAvailable.TabIndex = 2;
            lblAvailable.Text = "Danh sách dịch vụ:";
            // 
            // lstAvailableServices
            // 
            lstAvailableServices.FormattingEnabled = true;
            lstAvailableServices.ItemHeight = 20;
            lstAvailableServices.Location = new Point(15, 90);
            lstAvailableServices.Name = "lstAvailableServices";
            lstAvailableServices.Size = new Size(260, 204);
            lstAvailableServices.TabIndex = 3;
            lstAvailableServices.DoubleClick += lstAvailableServices_DoubleClick;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(295, 110);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(60, 32);
            btnSelect.TabIndex = 4;
            btnSelect.Text = ">";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(295, 155);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(60, 32);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(295, 200);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(60, 32);
            btnClearAll.TabIndex = 6;
            btnClearAll.Text = "<<";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // lblSelected
            // 
            lblSelected.AutoSize = true;
            lblSelected.Location = new Point(375, 65);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(130, 20);
            lblSelected.TabIndex = 7;
            lblSelected.Text = "Dịch vụ đã chọn:";
            // 
            // lstSelectedServices
            // 
            lstSelectedServices.FormattingEnabled = true;
            lstSelectedServices.ItemHeight = 20;
            lstSelectedServices.Location = new Point(375, 90);
            lstSelectedServices.Name = "lstSelectedServices";
            lstSelectedServices.Size = new Size(260, 204);
            lstSelectedServices.TabIndex = 8;
            lstSelectedServices.DoubleClick += lstSelectedServices_DoubleClick;
            // 
            // grpPayment
            // 
            grpPayment.Controls.Add(btnReset);
            grpPayment.Controls.Add(txtTotalAmount);
            grpPayment.Controls.Add(lblTotalAmount);
            grpPayment.Controls.Add(lblDiscountUnit);
            grpPayment.Controls.Add(numDiscount);
            grpPayment.Controls.Add(lblDiscount);
            grpPayment.Controls.Add(txtSubTotal);
            grpPayment.Controls.Add(lblSubTotal);
            grpPayment.Location = new Point(15, 335);
            grpPayment.Name = "grpPayment";
            grpPayment.Size = new Size(650, 160);
            grpPayment.TabIndex = 1;
            grpPayment.TabStop = false;
            grpPayment.Text = "Tính tiền & Chiết khấu hóa đơn";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(20, 35);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(147, 20);
            lblSubTotal.TabIndex = 0;
            lblSubTotal.Text = "Tổng tiền chưa giảm:";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(190, 32);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(220, 27);
            txtSubTotal.TabIndex = 1;
            txtSubTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(20, 75);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(134, 20);
            lblDiscount.TabIndex = 2;
            lblDiscount.Text = "Tỷ lệ chiết khấu:";
            // 
            // numDiscount
            // 
            numDiscount.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numDiscount.Location = new Point(190, 72);
            numDiscount.Name = "numDiscount";
            numDiscount.Size = new Size(100, 27);
            numDiscount.TabIndex = 3;
            numDiscount.TextAlign = HorizontalAlignment.Right;
            numDiscount.ValueChanged += numDiscount_ValueChanged;
            // 
            // lblDiscountUnit
            // 
            lblDiscountUnit.AutoSize = true;
            lblDiscountUnit.Location = new Point(300, 75);
            lblDiscountUnit.Name = "lblDiscountUnit";
            lblDiscountUnit.Size = new Size(21, 20);
            lblDiscountUnit.TabIndex = 4;
            lblDiscountUnit.Text = "%";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalAmount.Location = new Point(20, 115);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(165, 20);
            lblTotalAmount.TabIndex = 5;
            lblTotalAmount.Text = "Thành tiền thanh toán:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtTotalAmount.Location = new Point(190, 112);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(220, 27);
            txtTotalAmount.TabIndex = 6;
            txtTotalAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(480, 70);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(140, 35);
            btnReset.TabIndex = 7;
            btnReset.Text = "Làm mới đơn";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // frmServiceOrderDiscount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 510);
            Controls.Add(grpPayment);
            Controls.Add(grpServices);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmServiceOrderDiscount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 5.2: Bảng tính tiền dịch vụ và chiết khấu đơn hàng (ListBox & ComboBox)";
            Load += frmServiceOrderDiscount_Load;
            grpServices.ResumeLayout(false);
            grpServices.PerformLayout();
            grpPayment.ResumeLayout(false);
            grpPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDiscount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpServices;
        private Label lblCategory;
        private ComboBox cboCategory;
        private Label lblAvailable;
        private ListBox lstAvailableServices;
        private Button btnSelect;
        private Button btnRemove;
        private Button btnClearAll;
        private Label lblSelected;
        private ListBox lstSelectedServices;
        private GroupBox grpPayment;
        private Label lblSubTotal;
        private TextBox txtSubTotal;
        private Label lblDiscount;
        private NumericUpDown numDiscount;
        private Label lblDiscountUnit;
        private Label lblTotalAmount;
        private TextBox txtTotalAmount;
        private Button btnReset;
    }
}
