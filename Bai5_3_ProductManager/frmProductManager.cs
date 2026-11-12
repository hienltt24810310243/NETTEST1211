using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Bai5_3_ProductManager
{
    public partial class frmProductManager : Form
    {
        private BindingList<Product> allProducts = new BindingList<Product>();
        private BindingSource bindingSource = new BindingSource();

        public frmProductManager()
        {
            InitializeComponent();
        }

        private void frmProductManager_Load(object? sender, EventArgs e)
        {
            SetupCombobox();
            SetupDataGridView();
            LoadSampleProducts();
            ApplyFilter();
            UpdateClock();
        }

        private void SetupCombobox()
        {
            cboCategory.Items.Clear();
            cboCategory.Items.AddRange(new object[]
            {
                "Điện thoại",
                "Laptop",
                "Linh kiện máy tính",
                "Phụ kiện",
                "Thiết bị văn phòng"
            });
            cboCategory.SelectedIndex = 0;
        }

        private void SetupDataGridView()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.Columns.Clear();

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.ProductId),
                HeaderText = "Mã SP",
                Width = 90
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.ProductName),
                HeaderText = "Tên sản phẩm",
                Width = 200
            });

            var colPrice = new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.UnitPrice),
                HeaderText = "Đơn giá (VNĐ)",
                Width = 120
            };
            colPrice.DefaultCellStyle.Format = "N0";
            colPrice.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProducts.Columns.Add(colPrice);

            var colQty = new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.Quantity),
                HeaderText = "Số lượng",
                Width = 90
            };
            colQty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProducts.Columns.Add(colQty);

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.Category),
                HeaderText = "Danh mục",
                Width = 140
            });

            var colTotal = new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.TotalAmount),
                HeaderText = "Thành tiền (VNĐ)",
                Width = 140
            };
            colTotal.DefaultCellStyle.Format = "N0";
            colTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProducts.Columns.Add(colTotal);

            bindingSource.DataSource = allProducts;
            dgvProducts.DataSource = bindingSource;
        }

        private void LoadSampleProducts()
        {
            allProducts.Add(new Product("SP001", "iPhone 15 Pro Max 256GB", 29500000m, 12, "Điện thoại"));
            allProducts.Add(new Product("SP002", "Samsung Galaxy S24 Ultra", 26900000m, 8, "Điện thoại"));
            allProducts.Add(new Product("SP003", "Laptop Dell XPS 13 Plus", 34500000m, 5, "Laptop"));
            allProducts.Add(new Product("SP004", "MacBook Air M2 16GB", 24900000m, 10, "Laptop"));
            allProducts.Add(new Product("SP005", "Chuột Logitech MX Master 3S", 2250000m, 25, "Phụ kiện"));
            allProducts.Add(new Product("SP006", "Bàn phím cơ Keychron K2 Pro", 1950000m, 18, "Phụ kiện"));
            allProducts.Add(new Product("SP007", "Máy in HP LaserJet Pro M404dn", 5600000m, 6, "Thiết bị văn phòng"));
            allProducts.Add(new Product("SP008", "RAM Corsair Vengeance 32GB", 2100000m, 30, "Linh kiện máy tính"));
        }

        private void ApplyFilter()
        {
            string keyword = txtSearch.Text.Trim().ToLowerInvariant();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                bindingSource.DataSource = allProducts;
            }
            else
            {
                var filtered = allProducts.Where(p => p.ProductName.ToLowerInvariant().Contains(keyword)).ToList();
                bindingSource.DataSource = new BindingList<Product>(filtered);
            }

            UpdateStatusStrip();
        }

        private void UpdateStatusStrip()
        {
            int totalCount = bindingSource.Count;
            sslTotalProducts.Text = $"Tổng số sản phẩm: {totalCount}";

            decimal totalVal = 0m;
            foreach (var item in bindingSource)
            {
                if (item is Product p)
                {
                    totalVal += p.TotalAmount;
                }
            }

            sslTotalValue.Text = $"Tổng giá trị tồn kho: {totalVal:N0} VNĐ";
        }

        private void UpdateClock()
        {
            sslClock.Text = "Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void timerClock_Tick(object? sender, EventArgs e)
        {
            UpdateClock();
        }

        private void dgvProducts_SelectionChanged(object? sender, EventArgs e)
        {
            PopulateInputsFromSelectedRow();
        }

        private void dgvProducts_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            PopulateInputsFromSelectedRow();
        }

        private void PopulateInputsFromSelectedRow()
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                Product? selected = dgvProducts.SelectedRows[0].DataBoundItem as Product;
                if (selected != null)
                {
                    txtProductId.Text = selected.ProductId;
                    txtProductName.Text = selected.ProductName;
                    txtUnitPrice.Text = selected.UnitPrice.ToString("G0");
                    numQuantity.Value = selected.Quantity;
                    cboCategory.SelectedItem = selected.Category;
                }
            }
        }

        private bool ValidateInputs(bool isAdding, out string id, out string name, out decimal price, out int qty, out string category)
        {
            errorProvider1.Clear();
            bool hopLe = true;

            id = txtProductId.Text.Trim();
            name = txtProductName.Text.Trim();
            price = 0m;
            qty = (int)numQuantity.Value;
            category = cboCategory.SelectedItem != null ? cboCategory.SelectedItem.ToString()! : string.Empty;

            if (string.IsNullOrWhiteSpace(id))
            {
                errorProvider1.SetError(txtProductId, "Mã sản phẩm không được để trống!");
                hopLe = false;
            }
            else
            {
                string checkId = id;
                if (isAdding)
                {
                    if (allProducts.Any(p => p.ProductId.Equals(checkId, StringComparison.OrdinalIgnoreCase)))
                    {
                        errorProvider1.SetError(txtProductId, "Mã sản phẩm đã tồn tại trong danh sách!");
                        hopLe = false;
                    }
                }
                else
                {
                    if (dgvProducts.SelectedRows.Count > 0)
                    {
                        Product? current = dgvProducts.SelectedRows[0].DataBoundItem as Product;
                        if (current != null && !current.ProductId.Equals(checkId, StringComparison.OrdinalIgnoreCase))
                        {
                            if (allProducts.Any(p => p.ProductId.Equals(checkId, StringComparison.OrdinalIgnoreCase)))
                            {
                                errorProvider1.SetError(txtProductId, "Mã sản phẩm mới bị trùng với sản phẩm khác!");
                                hopLe = false;
                            }
                        }
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                errorProvider1.SetError(txtProductName, "Tên sản phẩm không được để trống!");
                hopLe = false;
            }

            string rawPrice = txtUnitPrice.Text.Trim().Replace(",", "").Replace(".", "");
            if (string.IsNullOrWhiteSpace(rawPrice))
            {
                errorProvider1.SetError(txtUnitPrice, "Đơn giá không được để trống!");
                hopLe = false;
            }
            else if (!decimal.TryParse(rawPrice, out price) || price <= 0)
            {
                errorProvider1.SetError(txtUnitPrice, "Đơn giá phải là số dương lớn hơn 0!");
                hopLe = false;
            }

            if (qty <= 0)
            {
                errorProvider1.SetError(numQuantity, "Số lượng sản phẩm phải lớn hơn 0!");
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(category))
            {
                errorProvider1.SetError(cboCategory, "Vui lòng chọn danh mục sản phẩm!");
                hopLe = false;
            }

            return hopLe;
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateInputs(true, out string id, out string name, out decimal price, out int qty, out string category))
            {
                return;
            }

            Product newProd = new Product(id, name, price, qty, category);
            allProducts.Add(newProd);

            ApplyFilter();
            SelectRowById(id);
            MessageBox.Show($"Thêm mới sản phẩm [{id} - {name}] thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs(false, out string id, out string name, out decimal price, out int qty, out string category))
            {
                return;
            }

            Product? selected = dgvProducts.SelectedRows[0].DataBoundItem as Product;
            if (selected != null)
            {
                selected.ProductId = id;
                selected.ProductName = name;
                selected.UnitPrice = price;
                selected.Quantity = qty;
                selected.Category = category;

                bindingSource.ResetBindings(false);
                ApplyFilter();
                SelectRowById(id);
                MessageBox.Show($"Cập nhật sản phẩm [{id}] thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Product? selected = dgvProducts.SelectedRows[0].DataBoundItem as Product;
            if (selected == null) return;

            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa sản phẩm [{selected.ProductId} - {selected.ProductName}] khỏi danh sách không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                allProducts.Remove(selected);
                ApplyFilter();
                ClearInputs();
                MessageBox.Show("Đã xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            errorProvider1.Clear();
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            numQuantity.Value = 1;
            cboCategory.SelectedIndex = 0;
            txtProductId.Focus();
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void SelectRowById(string id)
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.DataBoundItem is Product p && p.ProductId == id)
                {
                    row.Selected = true;
                    dgvProducts.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }
    }
}
