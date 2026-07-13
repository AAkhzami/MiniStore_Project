using MiniStore.Global;
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

namespace MiniStore
{
    public partial class frmMainForm : Form
    {
        frmLogin frmLogin = null;
        int _totalProducts = clsProducts.GetAllProducts().Rows.Count;
        private static DataTable _dtGetAllProducts;

        public frmMainForm(frmLogin login)
        {
            InitializeComponent();
            frmLogin = login;
        }
        private async Task LoadDataToTopSellingProducts()
        {
            DataTable dtGetAllTopProducts = await clsProducts.GetReportOfProducts();
            DataTable dtFormat = dtGetAllTopProducts.DefaultView.ToTable(false, "ProductName", "Price",
                                                             "CategoryName", "StockQuantity", "Revenue", "CategoryRank");
            dgvTopSellingProducts.DataSource = dtFormat;
            if (dgvTopSellingProducts.Rows.Count > 0)
            {

                dgvTopSellingProducts.Columns[0].HeaderText = "Product";
                dgvTopSellingProducts.Columns[0].Width = 200;

                dgvTopSellingProducts.Columns[1].HeaderText = "Price";
                dgvTopSellingProducts.Columns[1].Width = 160;

                dgvTopSellingProducts.Columns[2].HeaderText = "Category";
                dgvTopSellingProducts.Columns[2].Width = 199;

                dgvTopSellingProducts.Columns[3].HeaderText = "Sold Qty";
                dgvTopSellingProducts.Columns[3].Width = 160;


                dgvTopSellingProducts.Columns[4].HeaderText = "Revenue";
                dgvTopSellingProducts.Columns[4].Width = 160;

                dgvTopSellingProducts.Columns[5].HeaderText = "Rank";
                dgvTopSellingProducts.Columns[5].Width = 160;
            }
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
        private async Task InventoryPage()
        {
            await LoadProductsDataForInventoryPage();
        }
        private async Task DashboardInfo()
        {
            lblCustomers.Text = clsCustomers.GetCustomersCount().ToString();
            lblLowStock.Text = clsProducts.GetLowStockProductsCount().ToString();
            int totalOrders = 0;
            decimal totalSales = 0;
            clsOrders.GetOrdersInformationAtDate(DateTime.Now, ref totalOrders, ref totalSales);
            lblTodayOrders.Text = totalOrders.ToString();
            lblTodaySales.Text = totalSales.ToString() + " OMR";

            await LoadDataToTopSellingProducts();
        }
        private async void frmMainForm_Load(object sender, EventArgs e)
        {
            await DashboardInfo();

            lblUserName.Text = clsCurrentUser.CurrentUser.UserName;
            btnUserButtonName.Text = clsCurrentUser.CurrentUser.UserName.Substring(0, 2).ToUpper();

            DataTable dt = clsCategories.GetAllCategories();
            foreach(DataRow row in dt.Rows)
            {
                cbInventory_Categories.Items.Add(row["Name"].ToString());
            }
        }

        private void frmMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin.Close();
        }
        private void btnNextPage(object sender, EventArgs e)
        {
            int pageIndex = Convert.ToInt32(((Guna.UI2.WinForms.Guna2Button)sender).Tag);
            tcMainScreen.SelectedIndex = pageIndex;
            PageSetting(pageIndex);
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

        private async Task PageSetting(int pageNumner)
        {
            switch(pageNumner)
            {
                case 0:
                    await DashboardInfo();
                    break;
                case 1:
                    await InventoryPage();
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }

        private async void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbInventorySearch.Text = "";
            if(cbSearchType.Text != "None")
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

        private async void txbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txbInventorySearch.Text.Trim();
            string FilterColumn = cbSearchType.Text;
            string CategoryFilter = cbInventory_Categories.SelectedItem.ToString();

            if (string.IsNullOrEmpty(searchText))
            {
                _dtGetAllProducts.DefaultView.RowFilter = "";
                return;
            }

            switch(FilterColumn)
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
            else if(FilterColumn == "ProductName" && CategoryFilter == "All Categories")
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
            
        }
    }
}
