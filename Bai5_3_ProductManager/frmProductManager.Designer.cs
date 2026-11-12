namespace Bai5_3_ProductManager
{
    partial class frmProductManager
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
            grpProductInfo = new GroupBox();
            cboCategory = new ComboBox();
            lblCategory = new Label();
            numQuantity = new NumericUpDown();
            lblQuantity = new Label();
            txtUnitPrice = new TextBox();
            lblUnitPrice = new Label();
            txtProductName = new TextBox();
            lblProductName = new Label();
            txtProductId = new TextBox();
            lblProductId = new Label();
            grpActions = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            grpGrid = new GroupBox();
            dgvProducts = new DataGridView();
            statusStrip1 = new StatusStrip();
            sslTotalProducts = new ToolStripStatusLabel();
            sslTotalValue = new ToolStripStatusLabel();
            sslClock = new ToolStripStatusLabel();
            errorProvider1 = new ErrorProvider(components);
            timerClock = new System.Windows.Forms.Timer(components);
            grpProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            grpActions.SuspendLayout();
            grpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // grpProductInfo
            // 
            grpProductInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpProductInfo.Controls.Add(cboCategory);
            grpProductInfo.Controls.Add(lblCategory);
            grpProductInfo.Controls.Add(numQuantity);
            grpProductInfo.Controls.Add(lblQuantity);
            grpProductInfo.Controls.Add(txtUnitPrice);
            grpProductInfo.Controls.Add(lblUnitPrice);
            grpProductInfo.Controls.Add(txtProductName);
            grpProductInfo.Controls.Add(lblProductName);
            grpProductInfo.Controls.Add(txtProductId);
            grpProductInfo.Controls.Add(lblProductId);
            grpProductInfo.Location = new Point(15, 12);
            grpProductInfo.Name = "grpProductInfo";
            grpProductInfo.Size = new Size(850, 115);
            grpProductInfo.TabIndex = 0;
            grpProductInfo.TabStop = false;
            grpProductInfo.Text = "Thông tin sản phẩm";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(625, 27);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(195, 28);
            cboCategory.TabIndex = 9;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(535, 30);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(79, 20);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Danh mục:";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(380, 67);
            numQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(130, 27);
            numQuantity.TabIndex = 7;
            numQuantity.TextAlign = HorizontalAlignment.Right;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(300, 70);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 20);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Số lượng:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(115, 67);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(165, 27);
            txtUnitPrice.TabIndex = 5;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(20, 70);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(65, 20);
            lblUnitPrice.TabIndex = 4;
            lblUnitPrice.Text = "Đơn giá:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(380, 27);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(130, 27);
            txtProductName.TabIndex = 3;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(300, 30);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(55, 20);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Tên SP:";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(115, 27);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(165, 27);
            txtProductId.TabIndex = 1;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(20, 30);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(53, 20);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "Mã SP:";
            // 
            // grpActions
            // 
            grpActions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpActions.Controls.Add(btnClear);
            grpActions.Controls.Add(btnDelete);
            grpActions.Controls.Add(btnUpdate);
            grpActions.Controls.Add(btnAdd);
            grpActions.Controls.Add(txtSearch);
            grpActions.Controls.Add(lblSearch);
            grpActions.Location = new Point(15, 135);
            grpActions.Name = "grpActions";
            grpActions.Size = new Size(850, 75);
            grpActions.TabIndex = 1;
            grpActions.TabStop = false;
            grpActions.Text = "Chức năng";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.Location = new Point(745, 26);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(85, 32);
            btnClear.TabIndex = 5;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(650, 26);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 32);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.Location = new Point(555, 26);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(85, 32);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(460, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 32);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(165, 29);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập tên sản phẩm để tìm kiếm tức thời...";
            txtSearch.Size = new Size(275, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(20, 32);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(133, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm kiếm (Tên SP):";
            // 
            // grpGrid
            // 
            grpGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpGrid.Controls.Add(dgvProducts);
            grpGrid.Location = new Point(15, 218);
            grpGrid.Name = "grpGrid";
            grpGrid.Padding = new Padding(8);
            grpGrid.Size = new Size(850, 280);
            grpGrid.TabIndex = 2;
            grpGrid.TabStop = false;
            grpGrid.Text = "Danh sách sản phẩm (DataGridView)";
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(8, 28);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 35;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(834, 244);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { sslTotalProducts, sslTotalValue, sslClock });
            statusStrip1.Location = new Point(0, 508);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(880, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // sslTotalProducts
            // 
            sslTotalProducts.BorderSides = ToolStripStatusLabelBorderSides.Right;
            sslTotalProducts.Name = "sslTotalProducts";
            sslTotalProducts.Size = new Size(140, 20);
            sslTotalProducts.Text = "Tổng số sản phẩm: 0";
            // 
            // sslTotalValue
            // 
            sslTotalValue.Name = "sslTotalValue";
            sslTotalValue.Size = new Size(585, 20);
            sslTotalValue.Spring = true;
            sslTotalValue.Text = "Tổng giá trị tồn kho: 0 VNĐ";
            sslTotalValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sslClock
            // 
            sslClock.Name = "sslClock";
            sslClock.Size = new Size(140, 20);
            sslClock.Text = "Thời gian: 00:00:00";
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // frmProductManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 534);
            Controls.Add(statusStrip1);
            Controls.Add(grpGrid);
            Controls.Add(grpActions);
            Controls.Add(grpProductInfo);
            MinimumSize = new Size(800, 500);
            Name = "frmProductManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 5.3: Form quản lý danh sách sản phẩm trong bộ nhớ (DataGridView cơ bản)";
            Load += frmProductManager_Load;
            grpProductInfo.ResumeLayout(false);
            grpProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            grpActions.ResumeLayout(false);
            grpActions.PerformLayout();
            grpGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpProductInfo;
        private Label lblProductId;
        private TextBox txtProductId;
        private Label lblProductName;
        private TextBox txtProductName;
        private Label lblUnitPrice;
        private TextBox txtUnitPrice;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private Label lblCategory;
        private ComboBox cboCategory;
        private GroupBox grpActions;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private GroupBox grpGrid;
        private DataGridView dgvProducts;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel sslTotalProducts;
        private ToolStripStatusLabel sslTotalValue;
        private ToolStripStatusLabel sslClock;
        private ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timerClock;
    }
}
