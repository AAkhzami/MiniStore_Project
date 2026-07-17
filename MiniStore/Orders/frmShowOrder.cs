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
            sb.AppendLine("========================================================");
            sb.AppendLine("\nMini Store");
            sb.AppendLine("\nDate : " + _order.OrderDate.ToString("mm/dd/yyyy"));
            if(_customer.CustomerID != 1)
            {
                sb.AppendLine("\nFriend Name : " + _customer.CustomerName);
                sb.AppendLine("\nPhone       : " + _customer.PhoneNumber);
            }
            sb.AppendLine("\n========================================================");

            DataTable dt = clsOrders.GetBillInfo(_order.OrderID ?? -1);
            foreach(DataRow item in dt.Rows )
            {
                sb.AppendLine($"Name           : {item["Name"]}");
                sb.AppendLine($"Quantity       : {item["Quantity"]}");

                sb.AppendLine($"Price Per unit : {((decimal)item["PricePerUnit"]):N2} OMR ");

                sb.AppendLine($"Total Amount   : {((decimal)item["TotalAmount"]):N2} OMR ");
                sb.AppendLine("--------------------------------------------------------");
            }
            sb.AppendLine($"Total          : {_order.TotalAmount:N2} OMR");

            txbBill_Info.Text = sb.ToString();
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
