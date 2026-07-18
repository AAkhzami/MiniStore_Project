using MiniStore.Products;
using MiniStoreDB_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore.Inventory_Page
{
    public partial class ctrl_InventoryPage : UserControl
    {
        public ctrl_InventoryPage()
        {
            InitializeComponent();
        }
        private static DataTable _dtGetAllProducts;
        int _totalProducts = clsProducts.GetAllProducts().Rows.Count;

        public delegate void ProductDeactivatedEventHandler(int productID);
        public event ProductDeactivatedEventHandler OnProductDeactivated;
        private async void ctrl_InventoryPage_Load(object sender, EventArgs e)
        {
            DataTable dt = clsCategories.GetAllCategories();
            foreach (DataRow row in dt.Rows)
            {
                cbInventory_Categories.Items.Add(row["Name"].ToString());
            }
            await LoadProductsDataForInventoryPage();
        }
        private async Task LoadProductsDataForInventoryPage()
        {
            int pageNumber = int.Parse(lbl_Inventory_PageNumber.Text),
                ItemPerPage = int.Parse(cbItemPerPage_Inventory.Text);
            _dtGetAllProducts = await clsProducts.GetProductsInformationPerPage(pageNumber, ItemPerPage);

            dgvInventoryProducts.DataSource = _dtGetAllProducts;
            if (dgvInventoryProducts.Rows.Count > 0)
            {
                dgvInventoryProducts.Columns[0].HeaderText = "Product ID";
                dgvInventoryProducts.Columns[0].Width = 202;

                dgvInventoryProducts.Columns[1].HeaderText = "Product Name";
                dgvInventoryProducts.Columns[1].Width = 202;

                dgvInventoryProducts.Columns[2].HeaderText = "Category";
                dgvInventoryProducts.Columns[2].Width = 201;

                dgvInventoryProducts.Columns[3].HeaderText = "Price (OMR)";
                dgvInventoryProducts.Columns[3].Width = 202;

                dgvInventoryProducts.Columns[4].HeaderText = "Stock Qty";
                dgvInventoryProducts.Columns[4].Width = 202;

                dgvInventoryProducts.Columns[5].HeaderText = "Status";
                dgvInventoryProducts.Columns[5].Width = 202;
            }
            uint NumberOfProductsDisplayed = (uint)(_totalProducts - (_totalProducts - (pageNumber * int.Parse(cbItemPerPage_Inventory.Text))));
            NumberOfProductsDisplayed = (NumberOfProductsDisplayed > _totalProducts) ? (uint)_totalProducts : NumberOfProductsDisplayed;
            lblCounterProductsPerPage.Text = "Showing " + (NumberOfProductsDisplayed) + " of " + _totalProducts.ToString() + " products";
        }
        private async void cbItemPerPage_Inventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadProductsDataForInventoryPage();
        }

        private async void btnNextPageProducts_Click(object sender, EventArgs e)
        {
            int currentPage = int.Parse(lbl_Inventory_PageNumber.Text);
            int totalProducts = _totalProducts;
            int productPerPage = int.Parse(cbItemPerPage_Inventory.Text);
            if (dgvInventoryProducts.Rows.Count == productPerPage &&
                ((currentPage * productPerPage) < totalProducts))
            {
                lbl_Inventory_PageNumber.Text = (currentPage + 1).ToString();
                await LoadProductsDataForInventoryPage();
            }
        }

        private async void btnPreviesPageProducts_Click(object sender, EventArgs e)
        {
            int currentPage = int.Parse(lbl_Inventory_PageNumber.Text);
            int totalProducts = clsProducts.GetAllProducts().Rows.Count;
            if (currentPage > 1)
            {
                lbl_Inventory_PageNumber.Text = (currentPage - 1).ToString();
                await LoadProductsDataForInventoryPage();
            }
        }
        private async void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbInventorySearch.Text = "";
            if (cbSearchType.Text != "None")
            {
                txbInventorySearch.Visible = true;
                txbInventorySearch.Focus();
                _dtGetAllProducts = await clsProducts.GetReportOfProducts();
                dgvInventoryProducts.DataSource = _dtGetAllProducts;
                dgvInventoryProducts.Sort(dgvInventoryProducts.Columns[0], ListSortDirection.Ascending);

                btnNextPageProducts.Visible = false;
                btnPreviesPageProducts.Visible = false;
                lbl_Inventory_PageNumber.Visible = false;
                lbl_Inventory_Text_For_Item_Per_Page.Visible = false;
                cbItemPerPage_Inventory.Visible = false;

                lblCounterProductsPerPage.Text = "Showing Products : " + dgvInventoryProducts.Rows.Count.ToString();
            }
            else
            {
                await LoadProductsDataForInventoryPage();
                btnNextPageProducts.Visible = false;
                btnPreviesPageProducts.Visible = false;
                lbl_Inventory_PageNumber.Visible = false;
                lbl_Inventory_Text_For_Item_Per_Page.Visible = false;
                cbItemPerPage_Inventory.Visible = false;
                txbInventorySearch.Visible = false;
            }
        }
        private void txbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblCounterProductsPerPage.Text = "Showing Products : " + dgvInventoryProducts.Rows.Count.ToString();

            if (cbSearchType.Text == "Product ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txbInventorySearch.Text.Trim();
            string FilterColumn = cbSearchType.Text;
            string CategoryFilter = cbInventory_Categories.SelectedItem.ToString();

            if (string.IsNullOrEmpty(searchText))
            {
                _dtGetAllProducts.DefaultView.RowFilter = "";
                dgvInventoryProducts.DataSource = _dtGetAllProducts.DefaultView;
                lblCounterProductsPerPage.Text = "Showing Products : " + dgvInventoryProducts.Rows.Count.ToString();
                return;
            }

            switch (FilterColumn)
            {
                case "Product Name":
                    FilterColumn = "ProductName";
                    break;
                case "Product ID":
                    FilterColumn = "ProductID";
                    break;
            }

            if (FilterColumn == "ProductID" && CategoryFilter == "All Categories")
            {
                _dtGetAllProducts.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, searchText);
            }
            else if (FilterColumn == "ProductName" && CategoryFilter == "All Categories")
            {
                _dtGetAllProducts.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, searchText);
            }
            else if (FilterColumn == "ProductID" && CategoryFilter != "All Categories")
            {
                _dtGetAllProducts.DefaultView.RowFilter = string.Format("[{0}] = {1} And [CategoryName] = '{2}'", FilterColumn, searchText, CategoryFilter);
            }
            else if (FilterColumn == "ProductName" && CategoryFilter != "All Categories")
            {
                _dtGetAllProducts.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%' And [CategoryName] = '{2}'", FilterColumn, searchText, CategoryFilter);
            }

            dgvInventoryProducts.DataSource = _dtGetAllProducts.DefaultView;
            lblCounterProductsPerPage.Text = "Showing Products : " + dgvInventoryProducts.Rows.Count.ToString();

        }
        private async void cbInventory_Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cbInventory_Categories.SelectedItem.ToString();
            txbInventorySearch.Text = "";

            if (selectedCategory == "All Categories" && cbSearchType.Text == "None")
            {
                await LoadProductsDataForInventoryPage();
            }
            else if (selectedCategory == "All Categories" && cbSearchType.Text != "None")
            {
                _dtGetAllProducts.DefaultView.RowFilter = "";
            }
            else
            {
                _dtGetAllProducts.DefaultView.RowFilter = string.Format("[CategoryName] Like '{0}%'", selectedCategory);
            }

            dgvInventoryProducts.DataSource = _dtGetAllProducts.DefaultView;
            lblCounterProductsPerPage.Text = "Showing Products : " + dgvInventoryProducts.Rows.Count.ToString();
        }
        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            frmAddUpdateProducts AddProduct = new frmAddUpdateProducts();
            AddProduct.ShowDialog();
            ctrl_InventoryPage_Load(null, null);
        }
        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int productID = (int)dgvInventoryProducts.CurrentRow.Cells[0].Value;
            frmAddUpdateProducts EditProduct = new frmAddUpdateProducts(productID);
            EditProduct.ShowDialog();
            ctrl_InventoryPage_Load(null, null);
        }
        private void disableDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int productID = (int)dgvInventoryProducts.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure you want to disable this product? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                DialogResult.Yes)
            {
                if (clsProducts.DeleteProducts(productID))
                {
                    MessageBox.Show("Product disabled successfully", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrl_InventoryPage_Load(null, null);
                    OnProductDeactivated?.Invoke(productID);
                    return;
                }
                else
                {
                    MessageBox.Show("Product disabled failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void cmsInventoryPage_Opening(object sender, CancelEventArgs e)
        {
            int productID = (int)dgvInventoryProducts.CurrentRow.Cells[0].Value;
            if (clsProducts.Find(productID).IsActive)
            {
                tsmAtiveProduct.Enabled = false;
                disableDeleteToolStripMenuItem.Enabled = true;
            }
            else
            {
                tsmAtiveProduct.Enabled = true;
                disableDeleteToolStripMenuItem.Enabled = false;
            }
        }
        private void tsmActiveProduct_Click(object sender, EventArgs e)
        {
            int productID = (int)dgvInventoryProducts.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure you want to activation this product? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                DialogResult.Yes)
            {
                if (clsProducts.ProductActivation(productID))
                {
                    MessageBox.Show("The product has been successfully activated.", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrl_InventoryPage_Load(null, null);
                    return;
                }
                else
                {
                    MessageBox.Show("Product activation failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int productID = (int)dgvInventoryProducts.CurrentRow.Cells[0].Value;

            frmAddStock frm = new frmAddStock(productID);
            frm.ShowDialog();
            ctrl_InventoryPage_Load(null,null);
        }
        private void viewDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int productID = (int)dgvInventoryProducts.CurrentRow.Cells[0].Value;
            frmProductDetails frm = new frmProductDetails(productID);
            frm.ShowDialog();
        }
    }
}
