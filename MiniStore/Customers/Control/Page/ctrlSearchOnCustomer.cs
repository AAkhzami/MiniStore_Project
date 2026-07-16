using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MiniStore.Customers.Control.Page
{
    public partial class ctrlSearchOnCustomer : UserControl
    {
        public ctrlSearchOnCustomer()
        {
            InitializeComponent();
        }

        private void cbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchType = cbSearchType.SelectedItem.ToString();
            switch(searchType)
            {
                case "Customer Name":
                    txbCustomerSearch.PlaceholderText = "Search by name..";
                    break;
                case "Customer ID":
                    txbCustomerSearch.PlaceholderText = "Search by customer ID..";
                    break;
                case "Customer Phone Number":
                    txbCustomerSearch.PlaceholderText = "Search by phone number..";
                    break;
            }
        }

        private void txbCustomerSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbSearchType.Text != "Customer Name")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frm = new frmAddUpdateCustomer();
            frm.ShowDialog();
        }
        public void FocusOnTextSearch()
        {
            txbCustomerSearch.Focus();
        }
    }
}
