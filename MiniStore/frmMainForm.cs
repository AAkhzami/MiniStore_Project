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

namespace MiniStore
{
    public partial class frmMainForm : Form
    {
        frmLogin frmLogin = null;
        public frmMainForm(frmLogin login)
        {
            InitializeComponent();
            frmLogin = login;
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            lblCustomers.Text = clsCustomers.GetCustomersCount().ToString();

            lblUserName.Text = clsCurrentUser.CurrentUser.UserName;
            btnUserButtonName.Text = clsCurrentUser.CurrentUser.UserName.Substring(0,2).ToUpper();
        }

        private void frmMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin.Close();
        }
    }
}
