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

namespace MiniStore.Orders
{
    public partial class frmShowOrder : Form
    {
        clsOrders _order ;
        clsCustomers _customer;
        public frmShowOrder(clsOrders order, clsCustomers customerInfo)
        {
            InitializeComponent();
            _order = order;
            _customer = customerInfo;
        }
        public void LoadData()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=====================================================================");
            sb.AppendLine("\nMini Store");
            sb.AppendLine("\nDate : " + _order.OrderDate.ToString("mm/dd/yyyy"));
            if(_customer.CustomerID != 1)
            {
                sb.AppendLine("\nFriend Name : " + _customer.CustomerName);
                sb.AppendLine("\nPhone       : " + _customer.PhoneNumber);
            }
            sb.AppendLine("\n=====================================================================");

            txbBill_Info.Text = sb.ToString();

            int x = 40;
            int y = 180;

            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font normalFont = new Font("Arial", 10);

            Graphics g = txbBill_Info.CreateGraphics();
            g.DrawString("Product", headerFont, Brushes.Black, x, y);
            g.DrawString("Qty", headerFont, Brushes.Black, x + 220, y);
            g.DrawString("Price", headerFont, Brushes.Black, x + 320, y);
            g.DrawString("Total", headerFont, Brushes.Black, x + 450, y);

            y += 25;
            g.DrawLine(Pens.Black, x, y, x + 550, y);
            y += 10;

            DataTable dt = clsOrders.GetBillInfo(_order.OrderID ?? -1);
            foreach (DataRow item in dt.Rows)
            {
                g.DrawString(item["Name"].ToString(), normalFont, Brushes.Black, x, y);
                g.DrawString(item["Quantity"].ToString(),
                             normalFont,
                             Brushes.Black,
                             x + 230,
                             y);

                g.DrawString(((decimal)item["PricePerUnit"]).ToString("N2"),
                             normalFont,
                             Brushes.Black,
                             x + 320,
                             y);

                g.DrawString(((decimal)item["TotalAmount"]).ToString("N2"),
                             normalFont,
                             Brushes.Black,
                             x + 450,
                             y);

                y += 25;
            }
            g.DrawString($"Total : {_order.TotalAmount:N2} OMR",
                 headerFont,
                 Brushes.Black,
                 x + 320,
                 y);

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowOrder_Load(object sender, EventArgs e)
        {
            if(_customer != null && _order != null)
            {
                LoadData();
            }
            else
            {
                MessageBox.Show("No Data To Show!","Inform",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }
    }
}
