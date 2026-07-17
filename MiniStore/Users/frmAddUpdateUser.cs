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
        public enum enStatus { New, Update}
        enStatus _status = enStatus.New;

        clsUsers _user;

        public delegate void UserCreatedEventHandler(int UserID);
        public event UserCreatedEventHandler OnUserCreate;
        public frmAddUpdateUser()
        {
            InitializeComponent();
            _status = enStatus.New;
        }
        public frmAddUpdateUser(clsUsers user)
        {
            InitializeComponent();
            _user = user;
            _status = enStatus.Update;
        }


        private void txbUserName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txbUserName.Text))
            {
                errorProvider1.SetError(txbUserName, "This field must not be empty!");
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

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("We are experiencing difficulty completing this procedure. Please ensure that all requirements and conditions are met.",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsUsers user = new clsUsers();
            switch(_status)
            {
                case enStatus.New:
                    if (clsUsers.IsUserNameExist(txbUserName.Text))
                    {
                        errorProvider1.SetError(txbUserName, "This username exists! Choose another one!");
                        return;
                    }
                    break;
                case enStatus.Update:
                    user = _user;                    
                    break;
            }
            user.UserName = txbUserName.Text.Trim();
            user.FullName = txbFullName.Text.Trim();
            user.Password = txbPassword.Text.Trim();
            user.IsActive = true;
            

            if (user.Save())
            {
                MessageBox.Show("User Created Successfully!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblUserD.Text = user.UserID.ToString();
                btnSaveUser.Enabled = false;
            }
            else
            {
                MessageBox.Show("User Created Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OnUserCreate?.Invoke(user.UserID ?? -1);
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            switch(_status)
            {
                case enStatus.New:
                    this.Text = "New User";
                    lblTitle.Text = "Add New User";
                    break;
                case enStatus.Update:
                    this.Text = "Edit User";
                    lblTitle.Text = "Update User";
                    lblUserD.Text = _user.UserID.ToString();
                    txbUserName.Text = _user.UserName;
                    txbFullName.Text = _user.FullName;                    
                    break;
            }
        }
    }
}
