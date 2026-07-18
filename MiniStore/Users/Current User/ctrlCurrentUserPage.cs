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

namespace MiniStore.Users.Current_User
{
    public partial class ctrlCurrentUserPage : UserControl
    {
        public ctrlCurrentUserPage()
        {
            InitializeComponent();
        }

        public delegate void UserEditEventHandler();
        public event UserEditEventHandler OnUserDataChange;

        void LoadData(int UserID)
        {
            clsCurrentUser.CurrentUser = clsUsers.Find(UserID);
            ctrlUserInfo1.LoadData(clsCurrentUser.CurrentUser);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser(clsCurrentUser.CurrentUser, frmAddUpdateUser.enStatus.Update);
            frm.OnUserCreate += LoadData;
            frm.ShowDialog();
            OnUserDataChange?.Invoke();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser(clsCurrentUser.CurrentUser, frmAddUpdateUser.enStatus.UpdateWithPassword);
            frm.OnUserCreate += LoadData;
            frm.ShowDialog();
            OnUserDataChange?.Invoke();
        }
    }
}
