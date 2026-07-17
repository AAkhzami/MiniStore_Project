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

namespace MiniStore.Users
{
    public partial class frmAddUpdateUser : Form
    {
        public frmAddUpdateUser()
        {
            InitializeComponent();
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {

        }

        private void txbUserName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txbUserName.Text))
            {
                errorProvider1.SetError(txbUserName, "This field must not be empty!");
                e.Cancel = true;
            }
            else if (clsUsers.IsUserNameExist(txbUserName.Text))
            {
                errorProvider1.SetError(txbUserName, "This username exists! Choose another one!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txbUserName, "");
                e.Cancel = false;
            }
        }

        private void txbFullName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbFullName.Text))
            {
                errorProvider1.SetError(txbFullName, "This field must not be empty!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txbFullName, "");
                e.Cancel = false;
            }
        }

        private void txbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbPassword.Text))
            {
                errorProvider1.SetError(txbPassword, "This field must not be empty!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txbPassword, "");
                e.Cancel = false;
            }
        }

        private void txbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbConfirmPassword.Text))
            {
                errorProvider1.SetError(txbPassword, "This field must not be empty!");
                e.Cancel = true;
            }
            else if (txbConfirmPassword.Text != txbPassword.Text)
            {
                errorProvider1.SetError(txbPassword, "Password does not match!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txbPassword, "");
                e.Cancel = false;
            }
        }
    }
}
