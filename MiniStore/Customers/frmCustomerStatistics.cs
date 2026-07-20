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
    public partial class frmCustomerStatistics : Form
    {
        int _CustomerID = -1;
        public frmCustomerStatistics(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
        }

        private async void frmCustomerStatistics_Load(object sender, EventArgs e)
        {
            if(_CustomerID != -1)
            {
                ctrlCustomerInfo1.LoadData(clsCustomers.Find(_CustomerID));
                ctrlCustomerStatistics1.LoadData(_CustomerID);
                await ctrlOrdersDetailTable1.DataLoad(_CustomerID);
            }
        }
    }
}
