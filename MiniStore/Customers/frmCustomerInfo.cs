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
    public partial class frmCustomerInfo : Form
    {
        public frmCustomerInfo()
        {
            InitializeComponent();
        }
        public clsCustomers customer;
        public delegate void SelectedCustomerIDEventHandler(int CustomerID);
        public event SelectedCustomerIDEventHandler OnCustomerSelect;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(!customer.IsActive)
            {
                MessageBox.Show("Customer is not active! Choose another one that is an active customer.", "Not allowed",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txbSearchOnCustomer.Focus();
                return;
            }

            OnCustomerSelect?.Invoke(customer.CustomerID ?? -1);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txbSearchOnCustomer.Text))
            {
                string customerPhone = txbSearchOnCustomer.Text;

                customer = clsCustomers.Find(customerPhone);
                if(customer != null)
                {
                    ctrlCustomerInfo1.LoadData(customer);
                    btnSelect.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Customer is not exist!", "Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
