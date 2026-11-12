namespace Bai5_4_DepartmentEmployeeManager
{
    partial class frmDepartmentEmployeeManager
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
            splitContainer1 = new SplitContainer();
            tvDepartments = new TreeView();
            pnlTreeHeader = new Panel();
            lblTreeHeader = new Label();
            lsvEmployees = new ListView();
            pnlListHeader = new Panel();
            cboViewMode = new ComboBox();
            lblViewMode = new Label();
            lblSelectedDept = new Label();
            imgListTree = new ImageList(components);
            imgListSmall = new ImageList(components);
            imgListLarge = new ImageList(components);
            statusStrip1 = new StatusStrip();
            sslSelectedNode = new ToolStripStatusLabel();
            sslEmployeeCount = new ToolStripStatusLabel();
            sslClock = new ToolStripStatusLabel();
            timerClock = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            pnlTreeHeader.SuspendLayout();
            pnlListHeader.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pnlTreeHeader);
            splitContainer1.Panel1.Controls.Add(tvDepartments);
            splitContainer1.Panel1.Padding = new Padding(6);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pnlListHeader);
            splitContainer1.Panel2.Controls.Add(lsvEmployees);
            splitContainer1.Panel2.Padding = new Padding(6);
            splitContainer1.Size = new Size(980, 574);
            splitContainer1.SplitterDistance = 330;
            splitContainer1.TabIndex = 0;
            // 
            // tvDepartments
            // 
            tvDepartments.Dock = DockStyle.Fill;
            tvDepartments.HideSelection = false;
            tvDepartments.Location = new Point(6, 46);
            tvDepartments.Name = "tvDepartments";
            tvDepartments.Size = new Size(318, 522);
            tvDepartments.TabIndex = 1;
            tvDepartments.AfterSelect += tvDepartments_AfterSelect;
            // 
            // pnlTreeHeader
            // 
            pnlTreeHeader.Controls.Add(lblTreeHeader);
            pnlTreeHeader.Dock = DockStyle.Top;
            pnlTreeHeader.Location = new Point(6, 6);
            pnlTreeHeader.Name = "pnlTreeHeader";
            pnlTreeHeader.Size = new Size(318, 40);
            pnlTreeHeader.TabIndex = 0;
            // 
            // lblTreeHeader
            // 
            lblTreeHeader.AutoSize = true;
            lblTreeHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTreeHeader.Location = new Point(5, 10);
            lblTreeHeader.Name = "lblTreeHeader";
            lblTreeHeader.Size = new Size(207, 20);
            lblTreeHeader.TabIndex = 0;
            lblTreeHeader.Text = "Cơ cấu tổ chức doanh nghiệp";
            // 
            // lsvEmployees
            // 
            lsvEmployees.Dock = DockStyle.Fill;
            lsvEmployees.FullRowSelect = true;
            lsvEmployees.GridLines = true;
            lsvEmployees.Location = new Point(6, 46);
            lsvEmployees.MultiSelect = false;
            lsvEmployees.Name = "lsvEmployees";
            lsvEmployees.Size = new Size(634, 522);
            lsvEmployees.TabIndex = 1;
            lsvEmployees.UseCompatibleStateImageBehavior = false;
            lsvEmployees.View = View.Details;
            // 
            // pnlListHeader
            // 
            pnlListHeader.Controls.Add(cboViewMode);
            pnlListHeader.Controls.Add(lblViewMode);
            pnlListHeader.Controls.Add(lblSelectedDept);
            pnlListHeader.Dock = DockStyle.Top;
            pnlListHeader.Location = new Point(6, 6);
            pnlListHeader.Name = "pnlListHeader";
            pnlListHeader.Size = new Size(634, 40);
            pnlListHeader.TabIndex = 0;
            // 
            // cboViewMode
            // 
            cboViewMode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboViewMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cboViewMode.FormattingEnabled = true;
            cboViewMode.Location = new Point(484, 6);
            cboViewMode.Name = "cboViewMode";
            cboViewMode.Size = new Size(145, 28);
            cboViewMode.TabIndex = 2;
            cboViewMode.SelectedIndexChanged += cboViewMode_SelectedIndexChanged;
            // 
            // lblViewMode
            // 
            lblViewMode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblViewMode.AutoSize = true;
            lblViewMode.Location = new Point(380, 10);
            lblViewMode.Name = "lblViewMode";
            lblViewMode.Size = new Size(98, 20);
            lblViewMode.TabIndex = 1;
            lblViewMode.Text = "Chế độ xem:";
            // 
            // lblSelectedDept
            // 
            lblSelectedDept.AutoSize = true;
            lblSelectedDept.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSelectedDept.Location = new Point(5, 10);
            lblSelectedDept.Name = "lblSelectedDept";
            lblSelectedDept.Size = new Size(220, 20);
            lblSelectedDept.TabIndex = 0;
            lblSelectedDept.Text = "Danh sách nhân sự: [Tất cả]";
            // 
            // imgListTree
            // 
            imgListTree.ColorDepth = ColorDepth.Depth32Bit;
            imgListTree.ImageSize = new Size(16, 16);
            imgListTree.TransparentColor = Color.Transparent;
            // 
            // imgListSmall
            // 
            imgListSmall.ColorDepth = ColorDepth.Depth32Bit;
            imgListSmall.ImageSize = new Size(16, 16);
            imgListSmall.TransparentColor = Color.Transparent;
            // 
            // imgListLarge
            // 
            imgListLarge.ColorDepth = ColorDepth.Depth32Bit;
            imgListLarge.ImageSize = new Size(32, 32);
            imgListLarge.TransparentColor = Color.Transparent;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { sslSelectedNode, sslEmployeeCount, sslClock });
            statusStrip1.Location = new Point(0, 574);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(980, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // sslSelectedNode
            // 
            sslSelectedNode.BorderSides = ToolStripStatusLabelBorderSides.Right;
            sslSelectedNode.Name = "sslSelectedNode";
            sslSelectedNode.Size = new Size(200, 20);
            sslSelectedNode.Text = "Đơn vị đang chọn: Tất cả";
            // 
            // sslEmployeeCount
            // 
            sslEmployeeCount.Name = "sslEmployeeCount";
            sslEmployeeCount.Size = new Size(625, 20);
            sslEmployeeCount.Spring = true;
            sslEmployeeCount.Text = "Tổng số nhân sự: 0";
            sslEmployeeCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sslClock
            // 
            sslClock.Name = "sslClock";
            sslClock.Size = new Size(140, 20);
            sslClock.Text = "Thời gian: 00:00:00";
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // frmDepartmentEmployeeManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 600);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            MinimumSize = new Size(850, 500);
            Name = "frmDepartmentEmployeeManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 5.4: Trình quản lý tập tin / tổ chức nhân sự (TreeView & ListView)";
            Load += frmDepartmentEmployeeManager_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            pnlTreeHeader.ResumeLayout(false);
            pnlTreeHeader.PerformLayout();
            pnlListHeader.ResumeLayout(false);
            pnlListHeader.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private TreeView tvDepartments;
        private Panel pnlTreeHeader;
        private Label lblTreeHeader;
        private ListView lsvEmployees;
        private Panel pnlListHeader;
        private Label lblSelectedDept;
        private Label lblViewMode;
        private ComboBox cboViewMode;
        private ImageList imgListTree;
        private ImageList imgListSmall;
        private ImageList imgListLarge;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel sslSelectedNode;
        private ToolStripStatusLabel sslEmployeeCount;
        private ToolStripStatusLabel sslClock;
        private System.Windows.Forms.Timer timerClock;
    }
}
