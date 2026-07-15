using Guna.UI2.WinForms;
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
        }
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
                errorProvider1.SetError(txbCustomerName, "");
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(txbCustomerName, "");
                e.Cancel = true;
            }
        }

        private void txbPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbPhoneNumber.Text))
            {
                errorProvider1.SetError(txbPhoneNumber, "");
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(txbPhoneNumber, "");
                e.Cancel = true;
            }
        }
        void ChangingTheChoice()
        {
            if (rbActive.Checked)
            {
                rbActive.Checked = false;
                rbInActive.Checked = true;

                pInActive.BorderColor = Color.DodgerBlue;
                pInActive.FillColor = Color.AliceBlue;
                pInActive.FillColor2 = Color.AliceBlue;
                pInActive.FillColor3 = Color.AliceBlue;
                pInActive.FillColor4 = Color.AliceBlue;

                pActive.BorderColor = Color.Silver;
                pActive.FillColor = Color.White;
                pActive.FillColor2 = Color.White;
                pActive.FillColor3 = Color.White;
                pActive.FillColor4 = Color.White;
            }
            else
            {
                rbActive.Checked = true;
                rbInActive.Checked = false;

                pInActive.BorderColor = Color.Silver;
                pInActive.FillColor = Color.White;
                pInActive.FillColor2 = Color.White;
                pInActive.FillColor3 = Color.White;
                pInActive.FillColor4 = Color.White;

                pActive.BorderColor = Color.DodgerBlue;
                pActive.FillColor = Color.AliceBlue;
                pActive.FillColor2 = Color.AliceBlue;
                pActive.FillColor3 = Color.AliceBlue;
                pActive.FillColor4 = Color.AliceBlue;
            }
        }

        private void frmAddUpdateCustomer_Click(object sender, EventArgs e)
        {
            ChangingTheChoice();
        }

        private void pInActive_Click(object sender, EventArgs e)
        {
            ChangingTheChoice();
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            clsCustomers customer = new clsCustomers();
            customer.CustomerName = txbCustomerName.Text;
            customer.PhoneNumber = txbPhoneNumber.Text;
            customer.IsActive = rbActive.Checked;   
            if(customer.Save())
            {
                MessageBox.Show("Customer details saved successfully!","Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
                lblCustomerID.Text = customer.CustomerID.ToString();
                btnSaveCustomer.Enabled = false;
                txbCustomerName.Enabled = false;
                txbPhoneNumber.Enabled = false;
                rbActive.Enabled = false;
                rbInActive.Enabled = false;
                OnCustomerCreate?.Invoke(customer.CustomerID ?? -1);
                return;
            }
            else
            {
                MessageBox.Show("Customer details saved failed! try again","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }
    }
}
