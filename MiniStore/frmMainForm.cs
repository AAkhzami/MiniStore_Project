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
        int _NumberOfProductsDisplayed = 0;
        int _totalProducts = clsProducts.GetAllProducts().Rows.Count;
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
            DataTable dtGetAllProducts = await clsProducts.GetProductsInformationPerPage(pageNumber, ItemPerPage);

            dgvInventoryProducts.DataSource = dtGetAllProducts;
            if (dgvInventoryProducts.Rows.Count > 0)
            {
                dgvInventoryProducts.Columns[0].HeaderText = "Products ID";
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
            lblCounterProductsPerPage.Text = "Showing " + _NumberOfProductsDisplayed + " of " + _totalProducts.ToString() + " products";
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
        private void frmMainForm_Load(object sender, EventArgs e)
        {
            DashboardInfo();

            lblUserName.Text = clsCurrentUser.CurrentUser.UserName;
            btnUserButtonName.Text = clsCurrentUser.CurrentUser.UserName.Substring(0, 2).ToUpper();
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

        private void cbItemPerPage_Inventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductsDataForInventoryPage();

        }

        private void btnNextPageProducts_Click(object sender, EventArgs e)
        {
            int currentPage = int.Parse(lbl_Inventory_PageNumber.Text);
            int totalProducts = _totalProducts;
            int productPerPage = int.Parse(cbItemPerPage_Inventory.Text);
            if (dgvInventoryProducts.Rows.Count == productPerPage && 
                ((currentPage * productPerPage) < totalProducts))
            {
                lbl_Inventory_PageNumber.Text = (currentPage + 1).ToString();
                LoadProductsDataForInventoryPage();
            }
            //if ((totalProducts-(currentPage * dgvInventoryProducts.Rows.Count)) > 0 )

        }

        private void btnPreviesPageProducts_Click(object sender, EventArgs e)
        {
            int currentPage = int.Parse(lbl_Inventory_PageNumber.Text);
            int totalProducts = clsProducts.GetAllProducts().Rows.Count;
            if (currentPage > 1)
            {
                lbl_Inventory_PageNumber.Text = (currentPage - 1).ToString();
                LoadProductsDataForInventoryPage();
            }
        }

        private void PageSetting(int pageNumner)
        {
            switch(pageNumner)
            {
                case 0:
                    DashboardInfo();
                    break;
                case 1:
                    _NumberOfProductsDisplayed = _totalProducts;
                    InventoryPage();
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }
    }
}
