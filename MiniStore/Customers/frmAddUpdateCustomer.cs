using Guna.UI2.WinForms;
using MiniStore.Global;
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
    public partial class frmAddUpdateCustomer : Form
    {
        public frmAddUpdateCustomer()
        {
            InitializeComponent();
            _status = enStatus.Add;
        }
        public frmAddUpdateCustomer(clsCustomers customer)
        {
            InitializeComponent();
            _status = enStatus.Update;
            _customer = customer;
        }
        clsCustomers _customer;
        public enum enStatus { Add, Update };
        private enStatus _status = enStatus.Add;

        public delegate void CustomerCreatedEventHandler(int customerID);
        public event CustomerCreatedEventHandler OnCustomerCreate;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void  txbCustomerName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbCustomerName.Text))
            {
                errorProvider1.SetError(txbCustomerName, "This field must not be empty");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txbCustomerName, "");
                e.Cancel = false;
            }
        }

        private void txbPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbPhoneNumber.Text))
            {
                errorProvider1.SetError(txbPhoneNumber, "This field must not be empty");
                e.Cancel = true;
            }
            else if (txbPhoneNumber.Text.Length != 8)
            {
                errorProvider1.SetError(txbPhoneNumber, "The phone number must consist of 8 numbers");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txbPhoneNumber, "");
                e.Cancel = false;
            }
        }
        

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (clsCustomers.IsPhoneNumberExist(txbPhoneNumber.Text) && (txbPhoneNumber.Text.Trim() != _customer.PhoneNumber))
            {
                errorProvider1.SetError(txbPhoneNumber, "This phone number exist allread!");
                return;
            }

            clsCustomers customer = new clsCustomers();
            switch (_status)
            {
                case enStatus.Add:
                    customer.CreatedByUserID = clsCurrentUser.CurrentUser.UserID ?? -1;
                    break;
                case enStatus.Update:
                    customer = _customer;

                    break;
            }

            customer.CustomerName = txbCustomerName.Text;
            customer.PhoneNumber = txbPhoneNumber.Text;
            customer.IsActive = true;


            if(customer.Save())
            {
                MessageBox.Show("Customer details saved successfully!","Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
                lblCustomerID.Text = customer.CustomerID.ToString();

                btnSaveCustomer.Enabled = false;
                OnCustomerCreate?.Invoke(customer.CustomerID ?? -1);
            }
            else
            {
                MessageBox.Show("Customer details saved failed! try again","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void frmAddUpdateCustomer_Load(object sender, EventArgs e)
        {
            txbCustomerName.Focus();
            switch (_status)
            {
                case enStatus.Add:
                    this.Text = "Add New Customer";
                    lblTitle.Text = "Add New Customer";
                    break;
                case enStatus.Update:
                    this.Text = "Update Customer";
                    lblTitle.Text = "Update Customer";
                    lblCustomerID.Text = _customer.CustomerID.ToString();
                    txbCustomerName.Text = _customer.CustomerName;
                    txbPhoneNumber.Text = _customer.PhoneNumber;

                    break;
            }
        }
    }
}
