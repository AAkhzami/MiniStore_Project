using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore.Customers.Control.Page
{
    public partial class ctrlCustomersPage : UserControl
    {
        public ctrlCustomersPage()
        {
            InitializeComponent();
        }

        private void ctrlCustomersPage_Load(object sender, EventArgs e)
        {
            ctrlSearchOnCustomer1.FocusOnTextSearch();
            ctrlSearchOnCustomer1.OnSearch += ctrlTableOfCustomers1.SearchBy;
        }
    }
}
