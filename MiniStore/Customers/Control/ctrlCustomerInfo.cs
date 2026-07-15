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
    public partial class ctrlCustomerInfo : UserControl
    {
        clsCustomers _Customer;
        public ctrlCustomerInfo()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            _Customer = null;
            lblCustomerID.Text = "NULL";
            lblCustomerName.Text = "NULL";
            lblPhoneNumber.Text = "NULL";
            lblIsActive.Text = "NULL";
            lblCreatedBy.Text = "NULL";
        }
        public void LoadData(clsCustomers customer)
        {
            _Customer = customer;
            if( _Customer != null )
            {
                lblCustomerID.Text = _Customer.CustomerID.ToString();
                lblCustomerName.Text = _Customer.CustomerName;
                lblPhoneNumber.Text = _Customer.PhoneNumber;
                lblIsActive.Text = _Customer.IsActive.ToString();
                lblCreatedBy.Text = clsUsers.Find(_Customer.CreatedByUserID).UserName;
            }
            else
            {
                MessageBox.Show("Customer Not Found!", "Not Found",MessageBoxButtons.OK,MessageBoxIcon.Error );
                return;
            }
        }
    }
}
