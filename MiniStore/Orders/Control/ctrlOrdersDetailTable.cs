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

namespace MiniStore.Orders.Control
{
    public partial class ctrlOrdersDetailTable : UserControl
    {
        public ctrlOrdersDetailTable()
        {
            InitializeComponent();
        }
        public void DataLoad(int customerID)
        {
            DataTable dt = clsOrderDetails.GetOrdersDetailForCustomer(customerID);
            dgvOrders.DataSource = dt;
            if(dgvOrders.Rows.Count > 0 )
            {
                dgvOrders.Columns[0].HeaderText = "Order ID";
                dgvOrders.Columns[0].Width = 100;

                dgvOrders.Columns[1].HeaderText = "Total Products";
                dgvOrders.Columns[1].Width = 111;

                dgvOrders.Columns[0].HeaderText = "Profits";
                dgvOrders.Columns[0].Width = 207;

                dgvOrders.Columns[0].HeaderText = "Date";
                dgvOrders.Columns[0].Width = 207;

                dgvOrders.Columns[0].HeaderText = "Created By";
                dgvOrders.Columns[0].Width = 100;
            }
        }
    }
}
