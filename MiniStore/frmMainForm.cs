using MiniStore.Global;
using MiniStore.Products;
using MiniStoreDB_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore
{
    public partial class frmMainForm : Form
    {
        frmLogin frmLogin = null;


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
        private void CurrentUserDataChange()
        {
            lblUserName.Text = clsCurrentUser.CurrentUser.UserName;
            btnUserButtonName.Text = clsCurrentUser.CurrentUser.UserName.Substring(0, 2).ToUpper();
            lblUserGreeting.Text = clsCurrentUser.CurrentUser.UserName;
        }
        private async Task DashboardInfo()
        {
            lblCustomers.Text = clsCustomers.GetCustomersCount().ToString();
            lblLowStock.Text = clsProducts.GetLowStockProductsCount().ToString();
            lblTodayOrders.Text = clsOrders.GetTotalOrders(DateTime.Now).ToString();
            lblTodaySales.Text = "OMR ~" + clsOrders.GetTotalSales(DateTime.Now).ToString();

            await LoadDataToTopSellingProducts();
        }
        private async void frmMainForm_Load(object sender, EventArgs e)
        {
            await DashboardInfo();

            lblUserName.Text = clsCurrentUser.CurrentUser.UserName;
            btnUserButtonName.Text = clsCurrentUser.CurrentUser.UserName.Substring(0, 2).ToUpper();            
            lblUserGreeting.Text = clsCurrentUser.CurrentUser.UserName;
            ctrlCurrentUserPage1.LoadData(clsCurrentUser.CurrentUser.UserID ?? -1);
            ctrlCurrentUserPage1.OnUserDataChange += CurrentUserDataChange;
        }


        private void frmMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin.Close();
        }
        private async void btnNextPage(object sender, EventArgs e)
        {
            int pageIndex = Convert.ToInt32(((Guna.UI2.WinForms.Guna2Button)sender).Tag);
            ChangePage(pageIndex);
        }
        
        private async Task PageSetting(int pageNumner)
        {
            switch(pageNumner)
            {
                case 0:
                    await DashboardInfo();
                    break;
                case 1:
                    //ctrl_InventoryPage1
                    break;
                case 2:
                    //SalesPage();
                    break;
                case 3:
                    break;
            }
        }

        private async void ChangePage(int pagenumber)
        {
            tcMainScreen.SelectedIndex = pagenumber;
            await PageSetting(pagenumber);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            ChangePage(Convert.ToInt32(panel3.Tag));
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {
            ChangePage(Convert.ToInt32(lblUserName.Tag));
        }

        private void btnUserButtonName_Click(object sender, EventArgs e)
        {
            ChangePage(Convert.ToInt32(btnUserButtonName.Tag));
        }
    }
}
