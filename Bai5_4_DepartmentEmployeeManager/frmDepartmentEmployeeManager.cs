using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bai5_4_DepartmentEmployeeManager
{
    public partial class frmDepartmentEmployeeManager : Form
    {
        private List<Employee> allEmployees = new List<Employee>();

        public frmDepartmentEmployeeManager()
        {
            InitializeComponent();
        }

        private void frmDepartmentEmployeeManager_Load(object? sender, EventArgs e)
        {
            KhoiTaoDanhSachNhanVien();
            KhoiTaoImageLists();
            KhoiTaoCacCheDoXem();
            KhoiTaoCayPhongBan();
            if (tvDepartments.Nodes.Count > 0)
            {
                HienThiDanhSachNhanVien(tvDepartments.Nodes[0]);
            }
            UpdateClock();
        }

        private void KhoiTaoImageLists()
        {
            // 1. ImageList cho TreeView (16x16)
            imgListTree.Images.Add("company", CreateIconBitmap(16, Color.Navy, "C"));
            imgListTree.Images.Add("division", CreateIconBitmap(16, Color.DarkOrange, "K"));
            imgListTree.Images.Add("department", CreateIconBitmap(16, Color.ForestGreen, "P"));
            imgListTree.Images.Add("team", CreateIconBitmap(16, Color.SteelBlue, "N"));
            tvDepartments.ImageList = imgListTree;

            // 2. ImageList Small cho ListView (16x16)
            imgListSmall.Images.Add("male", CreateAvatarBitmap(16, Color.RoyalBlue, "M"));
            imgListSmall.Images.Add("female", CreateAvatarBitmap(16, Color.DeepPink, "F"));
            lsvEmployees.SmallImageList = imgListSmall;

            // 3. ImageList Large cho ListView (32x32)
            imgListLarge.Images.Add("male", CreateAvatarBitmap(32, Color.RoyalBlue, "M"));
            imgListLarge.Images.Add("female", CreateAvatarBitmap(32, Color.DeepPink, "F"));
            lsvEmployees.LargeImageList = imgListLarge;
        }

        private Bitmap CreateIconBitmap(int size, Color color, string letter)
        {
            Bitmap bmp = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                using (Brush brush = new SolidBrush(color))
                {
                    g.FillRectangle(brush, 1, 1, size - 2, size - 2);
                }
                using (Pen pen = new Pen(Color.White, 1))
                {
                    g.DrawRectangle(pen, 1, 1, size - 3, size - 3);
                }
                using (Font font = new Font("Segoe UI", size > 20 ? 12 : 7, FontStyle.Bold))
                using (Brush textBrush = new SolidBrush(Color.White))
                {
                    StringFormat sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    g.DrawString(letter, font, textBrush, new RectangleF(0, 0, size, size), sf);
                }
            }
            return bmp;
        }

        private Bitmap CreateAvatarBitmap(int size, Color color, string letter)
        {
            Bitmap bmp = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                using (Brush brush = new SolidBrush(color))
                {
                    g.FillEllipse(brush, 1, 1, size - 2, size - 2);
                }
                using (Pen pen = new Pen(Color.White, 1))
                {
                    g.DrawEllipse(pen, 1, 1, size - 3, size - 3);
                }
                using (Font font = new Font("Segoe UI", size > 20 ? 12 : 7, FontStyle.Bold))
                using (Brush textBrush = new SolidBrush(Color.White))
                {
                    StringFormat sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    g.DrawString(letter, font, textBrush, new RectangleF(0, 0, size, size), sf);
                }
            }
            return bmp;
        }

        private void KhoiTaoCacCheDoXem()
        {
            cboViewMode.Items.Clear();
            cboViewMode.Items.AddRange(new object[]
            {
                "Details (Chi tiết)",
                "SmallIcon (Biểu tượng nhỏ)",
                "LargeIcon (Biểu tượng lớn)",
                "Tile (Dạng ô lát)",
                "List (Danh sách)"
            });
            cboViewMode.SelectedIndex = 0; // Details

            // Khởi tạo cột cho chế độ Details
            lsvEmployees.Columns.Clear();
            lsvEmployees.Columns.Add("Mã NV", 100, HorizontalAlignment.Left);
            lsvEmployees.Columns.Add("Họ Tên", 190, HorizontalAlignment.Left);
            lsvEmployees.Columns.Add("Chức vụ", 170, HorizontalAlignment.Left);
            lsvEmployees.Columns.Add("Ngày vào làm", 130, HorizontalAlignment.Center);
        }

        private void KhoiTaoCayPhongBan()
        {
            tvDepartments.Nodes.Clear();

            // Gốc Công ty
            TreeNode root = new TreeNode("Công ty Cổ phần Công nghệ VinaTech")
            {
                ImageKey = "company",
                SelectedImageKey = "company",
                Tag = "ROOT"
            };

            // Ban Giám đốc
            TreeNode nodeBGD = new TreeNode("Ban Giám đốc")
            {
                ImageKey = "division",
                SelectedImageKey = "division",
                Tag = "BGD"
            };
            root.Nodes.Add(nodeBGD);

            // Khối Kỹ thuật & Công nghệ
            TreeNode nodeTech = new TreeNode("Khối Kỹ thuật & Công nghệ")
            {
                ImageKey = "division",
                SelectedImageKey = "division",
                Tag = "TECH"
            };
            nodeTech.Nodes.Add(new TreeNode("Phòng Phát triển Phần mềm") { ImageKey = "department", SelectedImageKey = "department", Tag = "TECH_DEV" });
            nodeTech.Nodes.Add(new TreeNode("Phòng Kiểm thử & QA") { ImageKey = "department", SelectedImageKey = "department", Tag = "TECH_QA" });
            nodeTech.Nodes.Add(new TreeNode("Phòng Hạ tầng & DevOps") { ImageKey = "department", SelectedImageKey = "department", Tag = "TECH_INFRA" });
            root.Nodes.Add(nodeTech);

            // Khối Kinh doanh & Tiếp thị
            TreeNode nodeBiz = new TreeNode("Khối Kinh doanh & Tiếp thị")
            {
                ImageKey = "division",
                SelectedImageKey = "division",
                Tag = "BIZ"
            };
            nodeBiz.Nodes.Add(new TreeNode("Phòng Bán hàng Doanh nghiệp") { ImageKey = "department", SelectedImageKey = "department", Tag = "BIZ_SALES" });
            nodeBiz.Nodes.Add(new TreeNode("Phòng Tiếp thị số (Marketing)") { ImageKey = "department", SelectedImageKey = "department", Tag = "BIZ_MKT" });
            root.Nodes.Add(nodeBiz);

            // Khối Hành chính & Nhân sự
            TreeNode nodeHr = new TreeNode("Khối Hành chính & Nhân sự")
            {
                ImageKey = "division",
                SelectedImageKey = "division",
                Tag = "HR"
            };
            nodeHr.Nodes.Add(new TreeNode("Phòng Nhân sự & Đào tạo") { ImageKey = "department", SelectedImageKey = "department", Tag = "HR_TRAIN" });
            nodeHr.Nodes.Add(new TreeNode("Phòng Tài chính & Kế toán") { ImageKey = "department", SelectedImageKey = "department", Tag = "HR_ACC" });
            root.Nodes.Add(nodeHr);

            tvDepartments.Nodes.Add(root);
            tvDepartments.ExpandAll();
            tvDepartments.SelectedNode = root;
        }

        private void KhoiTaoDanhSachNhanVien()
        {
            allEmployees = new List<Employee>
            {
                // Ban Giám đốc
                new Employee("NV001", "Nguyễn Văn Hùng", "Tổng Giám đốc (CEO)", new DateTime(2018, 1, 15), "BGD", "Nam"),
                new Employee("NV002", "Trần Thị Mai", "Phó Tổng Giám đốc", new DateTime(2019, 3, 10), "BGD", "Nữ"),

                // TECH - Phát triển phần mềm
                new Employee("NV101", "Lê Ngọc Quyền", "Kỹ sư Phần mềm Senior", new DateTime(2021, 6, 1), "TECH_DEV", "Nam"),
                new Employee("NV102", "Phạm Quốc Tuấn", "Lập trình viên Backend", new DateTime(2022, 8, 15), "TECH_DEV", "Nam"),
                new Employee("NV103", "Vũ Hoàng My", "Lập trình viên Frontend", new DateTime(2023, 2, 20), "TECH_DEV", "Nữ"),

                // TECH - QA
                new Employee("NV104", "Hoàng Thu Thảo", "Trưởng nhóm Kiểm thử QA", new DateTime(2021, 11, 1), "TECH_QA", "Nữ"),
                new Employee("NV105", "Đặng Minh Tâm", "Kỹ sư Tự động hóa Test", new DateTime(2023, 5, 10), "TECH_QA", "Nam"),

                // TECH - Infra
                new Employee("NV106", "Bùi Văn An", "Kỹ sư Hạ tầng Cloud / DevOps", new DateTime(2022, 4, 12), "TECH_INFRA", "Nam"),

                // BIZ - Sales
                new Employee("NV201", "Đỗ Tuấn Khang", "Trưởng phòng Kinh doanh", new DateTime(2020, 9, 1), "BIZ_SALES", "Nam"),
                new Employee("NV202", "Lê Thanh Thảo", "Chuyên viên Tư vấn Doanh nghiệp", new DateTime(2023, 7, 15), "BIZ_SALES", "Nữ"),

                // BIZ - Marketing
                new Employee("NV203", "Trịnh Thùy Linh", "Chuyên viên Digital Marketing", new DateTime(2022, 10, 5), "BIZ_MKT", "Nữ"),
                new Employee("NV204", "Nguyễn Đức Anh", "Thiết kế Sáng tạo (Designer)", new DateTime(2024, 1, 10), "BIZ_MKT", "Nam"),

                // HR - Nhân sự & Đào tạo
                new Employee("NV301", "Võ Thị Bích Ngọc", "Trưởng phòng Nhân sự", new DateTime(2019, 5, 20), "HR_TRAIN", "Nữ"),
                new Employee("NV302", "Lý Thiên Kim", "Chuyên viên Tuyển dụng & C&B", new DateTime(2023, 3, 1), "HR_TRAIN", "Nữ"),

                // HR - Kế toán
                new Employee("NV303", "Ngô Phương Lan", "Kế toán trưởng", new DateTime(2018, 7, 1), "HR_ACC", "Nữ"),
                new Employee("NV304", "Dương Quốc Dũng", "Kế toán tổng hợp", new DateTime(2022, 12, 1), "HR_ACC", "Nam")
            };
        }

        private void tvDepartments_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                HienThiDanhSachNhanVien(e.Node);
            }
        }

        private void HienThiDanhSachNhanVien(TreeNode selectedNode)
        {
            lsvEmployees.BeginUpdate();
            lsvEmployees.Items.Clear();

            string nodeTag = selectedNode.Tag?.ToString() ?? string.Empty;
            string nodeText = selectedNode.Text;

            lblSelectedDept.Text = $"Danh sách nhân sự: [{nodeText}]";
            sslSelectedNode.Text = $"Đơn vị đang chọn: {nodeText}";

            // Lọc nhân sự thuộc node hoặc các node con
            List<string> validTags = GetDescendantTags(selectedNode);

            var filtered = allEmployees.Where(emp => validTags.Contains(emp.DepartmentPath) || nodeTag == "ROOT").ToList();

            foreach (var emp in filtered)
            {
                ListViewItem item = new ListViewItem(emp.EmployeeId)
                {
                    ImageKey = emp.Gender == "Nam" ? "male" : "female",
                    Tag = emp
                };

                item.SubItems.Add(emp.FullName);
                item.SubItems.Add(emp.Position);
                item.SubItems.Add(emp.StartDate.ToString("dd/MM/yyyy"));

                lsvEmployees.Items.Add(item);
            }

            lsvEmployees.EndUpdate();

            sslEmployeeCount.Text = $"Số lượng nhân sự hiển thị: {filtered.Count} người (Tổng công ty: {allEmployees.Count})";
        }

        private List<string> GetDescendantTags(TreeNode node)
        {
            List<string> tags = new List<string>();
            if (node.Tag != null)
            {
                tags.Add(node.Tag.ToString()!);
            }

            foreach (TreeNode child in node.Nodes)
            {
                tags.AddRange(GetDescendantTags(child));
            }

            return tags;
        }

        private void cboViewMode_SelectedIndexChanged(object? sender, EventArgs e)
        {
            switch (cboViewMode.SelectedIndex)
            {
                case 0:
                    lsvEmployees.View = View.Details;
                    break;
                case 1:
                    lsvEmployees.View = View.SmallIcon;
                    break;
                case 2:
                    lsvEmployees.View = View.LargeIcon;
                    break;
                case 3:
                    lsvEmployees.View = View.Tile;
                    break;
                case 4:
                    lsvEmployees.View = View.List;
                    break;
                default:
                    lsvEmployees.View = View.Details;
                    break;
            }
        }

        private void UpdateClock()
        {
            sslClock.Text = "Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void timerClock_Tick(object? sender, EventArgs e)
        {
            UpdateClock();
        }
    }
}
