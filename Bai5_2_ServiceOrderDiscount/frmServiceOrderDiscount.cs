using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bai5_2_ServiceOrderDiscount
{
    public partial class frmServiceOrderDiscount : Form
    {
        private List<ServiceItem> allServices = new List<ServiceItem>();

        public frmServiceOrderDiscount()
        {
            InitializeComponent();
        }

        private void frmServiceOrderDiscount_Load(object? sender, EventArgs e)
        {
            KhoiTaoDuLieuMau();
            NapDanhSachLoaiDichVu();
            TinhToanHoaDon();
        }

        private void KhoiTaoDuLieuMau()
        {
            allServices = new List<ServiceItem>
            {
                // Khám bệnh
                new ServiceItem("KB01", "Khám bệnh tổng quát", "Khám bệnh", 150000m),
                new ServiceItem("KB02", "Khám chuyên khoa Nội", "Khám bệnh", 200000m),
                new ServiceItem("KB03", "Khám chuyên khoa Ngoại", "Khám bệnh", 200000m),
                new ServiceItem("KB04", "Khám Nhi khoa", "Khám bệnh", 180000m),
                new ServiceItem("KB05", "Khám Mắt & Đo thị lực", "Khám bệnh", 120000m),

                // Xét nghiệm
                new ServiceItem("XN01", "Xét nghiệm máu tổng quát", "Xét nghiệm", 250000m),
                new ServiceItem("XN02", "Xét nghiệm nước tiểu", "Xét nghiệm", 100000m),
                new ServiceItem("XN03", "Sinh hóa máu 10 chỉ số", "Xét nghiệm", 350000m),
                new ServiceItem("XN04", "Xét nghiệm đường huyết", "Xét nghiệm", 80000m),
                new ServiceItem("XN05", "Xét nghiệm chức năng gan", "Xét nghiệm", 220000m),

                // Chụp X-Quang
                new ServiceItem("XQ01", "Chụp X-Quang tim phổi", "Chụp X-Quang", 180000m),
                new ServiceItem("XQ02", "Chụp X-Quang cột sống", "Chụp X-Quang", 220000m),
                new ServiceItem("XQ03", "Chụp X-Quang khớp gối", "Chụp X-Quang", 200000m),
                new ServiceItem("XQ04", "Chụp CT Scanner sọ não", "Chụp X-Quang", 1200000m),

                // Vắc-xin
                new ServiceItem("VX01", "Vắc-xin Cúm mùa", "Vắc-xin", 320000m),
                new ServiceItem("VX02", "Vắc-xin Viêm gan B", "Vắc-xin", 250000m),
                new ServiceItem("VX03", "Vắc-xin Thủy đậu", "Vắc-xin", 680000m),
                new ServiceItem("VX04", "Vắc-xin Sởi - Quai bị - Rubella", "Vắc-xin", 400000m)
            };
        }

        private void NapDanhSachLoaiDichVu()
        {
            cboCategory.Items.Clear();
            cboCategory.Items.AddRange(new object[]
            {
                "Khám bệnh",
                "Xét nghiệm",
                "Chụp X-Quang",
                "Vắc-xin"
            });
            cboCategory.SelectedIndex = 0;
        }

        private void cboCategory_SelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadAvailableServicesByCategory();
        }

        private void LoadAvailableServicesByCategory()
        {
            string selectedCategory = cboCategory.SelectedItem != null ? cboCategory.SelectedItem.ToString()! : string.Empty;
            lstAvailableServices.Items.Clear();

            var filtered = allServices.Where(s => s.Category == selectedCategory).ToList();
            foreach (var item in filtered)
            {
                lstAvailableServices.Items.Add(item);
            }
        }

        private void btnSelect_Click(object? sender, EventArgs e)
        {
            ChuyenDichVuSangDaChon();
        }

        private void lstAvailableServices_DoubleClick(object? sender, EventArgs e)
        {
            ChuyenDichVuSangDaChon();
        }

        private void ChuyenDichVuSangDaChon()
        {
            if (lstAvailableServices.SelectedItem is ServiceItem selected)
            {
                lstSelectedServices.Items.Add(selected);
                TinhToanHoaDon();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dịch vụ từ danh sách khả dụng!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemove_Click(object? sender, EventArgs e)
        {
            XoaDichVuKhoiDaChon();
        }

        private void lstSelectedServices_DoubleClick(object? sender, EventArgs e)
        {
            XoaDichVuKhoiDaChon();
        }

        private void XoaDichVuKhoiDaChon()
        {
            if (lstSelectedServices.SelectedIndex != -1)
            {
                lstSelectedServices.Items.RemoveAt(lstSelectedServices.SelectedIndex);
                TinhToanHoaDon();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ muốn hủy trong danh sách đã chọn!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearAll_Click(object? sender, EventArgs e)
        {
            if (lstSelectedServices.Items.Count > 0)
            {
                lstSelectedServices.Items.Clear();
                TinhToanHoaDon();
            }
        }

        private void numDiscount_ValueChanged(object? sender, EventArgs e)
        {
            TinhToanHoaDon();
        }

        private void TinhToanHoaDon()
        {
            decimal subTotal = 0m;
            foreach (var item in lstSelectedServices.Items)
            {
                if (item is ServiceItem svc)
                {
                    subTotal += svc.Price;
                }
            }

            decimal discountRate = numDiscount.Value;
            if (discountRate < 0) discountRate = 0;
            if (discountRate > 100) discountRate = 100;

            decimal discountAmount = subTotal * (discountRate / 100m);
            decimal totalAmount = subTotal - discountAmount;

            txtSubTotal.Text = $"{subTotal:N0} VNĐ";
            txtTotalAmount.Text = $"{totalAmount:N0} VNĐ";
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();
            numDiscount.Value = 0;
            cboCategory.SelectedIndex = 0;
            TinhToanHoaDon();
        }
    }
}
