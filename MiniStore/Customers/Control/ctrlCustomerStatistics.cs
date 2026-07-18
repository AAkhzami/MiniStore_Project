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

namespace MiniStore.Customers
{
    public partial class ctrlCustomerStatistics : UserControl
    {
        public ctrlCustomerStatistics()
        {
            InitializeComponent();
        }
        public void LoadData(int CustomerID)
        {
            int OrderCount = 0 , ProductsPurchased = 0, LastPurchase = 0;
            decimal TotalSpent = 0;
            DateTime LastPusrchaseDate = DateTime.Now;

            if(clsCustomers.GetCustomerStatistics(CustomerID,ref OrderCount, ref TotalSpent, ref ProductsPurchased, ref LastPurchase, ref LastPusrchaseDate))
            {
                lblOrdersCount.Text = OrderCount.ToString();
                lblTotalSpent.Text = $"{TotalSpent:N3} OMR";
                lblProductsPurchased.Text = ProductsPurchased.ToString();
                if(ProductsPurchased != 0)
                {
                    if (LastPurchase == 0)
                    {
                        lblLastPurchase.Text = "Today";
                    }
                    else
                    {
                        lblLastPurchase.Text = LastPurchase.ToString() + "Day(s)";
                    }
                    lblLastPurchaseDate.Text = LastPusrchaseDate.ToString("dd/MM/yyyy");
                }
                else
                {
                    lblLastPurchase.Text = "Nothing";
                    lblLastPurchaseDate.Text = "Nothing";
                }
            }
            else
            {
                MessageBox.Show("Customer Not Found!","Not Found", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }
    }
}
