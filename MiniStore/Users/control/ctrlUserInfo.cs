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

namespace MiniStore.Users.control
{
    public partial class ctrlUserInfo : UserControl
    {
        clsUsers _user;
        public ctrlUserInfo()
        {
            InitializeComponent();
        }
        public void LoadData(clsUsers user)
        {
            _user = user;
            if(_user != null)
            {
                lblUserID.Text = _user.UserID.ToString();
                lblUserName.Text = _user.UserName;
                lblFullName.Text = _user.FullName;
                lblCreatedAt.Text = _user.CreatedAt.ToString("dd/MM/YYYY");
                lblIsActive.Text = _user.IsActive.ToString();
            }
            else
            {
                MessageBox.Show("User Not Found!","Not Found",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }
        public void Reset()
        {
            lblUserID.Text = "NULL";
            lblUserName.Text = "NULL";
            lblFullName.Text = "NULL";
            lblCreatedAt.Text = "NULL";
            lblIsActive.Text = "NULL";
        }
    }
}
