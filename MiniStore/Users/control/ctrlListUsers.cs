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
    public partial class ctrlListUsers : UserControl
    {
        public ctrlListUsers()
        {
            InitializeComponent();
        }


        private async void ctrlListUsers_Load(object sender, EventArgs e)
        {
            DataTable dtGetAllUsers = await clsUsers.GetAllUsers();
            DataTable dtUsers = dtGetAllUsers.DefaultView.ToTable(false, "UserID", "FullName", "UserName", "IsActive");

            dgvUsers.DataSource = dtUsers;
            if(dtUsers.Rows.Count > 0 )
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 316;

                dgvUsers.Columns[1].HeaderText = "Full Name";
                dgvUsers.Columns[1].Width = 317;

                dgvUsers.Columns[0].HeaderText = "User Name";
                dgvUsers.Columns[0].Width = 316;

                dgvUsers.Columns[0].HeaderText = "Is Active";
                dgvUsers.Columns[0].Width = 300;
            }
            lblUsersCounter.Text = $"Showing {dgvUsers.Rows.Count} Users";
        }
        private async Task _LoadData()
        {
            DataTable dtGetAllUsers = await clsUsers.GetAllUsers();
            DataTable dtUsers = dtGetAllUsers.DefaultView.ToTable(false, "UserID", "FullName", "UserName", "IsActive");

            dgvUsers.DataSource = dtUsers;
            if (dtUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 316;

                dgvUsers.Columns[1].HeaderText = "Full Name";
                dgvUsers.Columns[1].Width = 317;

                dgvUsers.Columns[0].HeaderText = "User Name";
                dgvUsers.Columns[0].Width = 316;

                dgvUsers.Columns[0].HeaderText = "Is Active";
                dgvUsers.Columns[0].Width = 300;
            }
            lblUsersCounter.Text = $"Showing {dgvUsers.Rows.Count} Users";
        }
        public async void LoadData()
        {
            await _LoadData();
        }
        public async void SearchOnUser(string searchType, string searchText)
        {
            DataTable dtGetAllUsers = await clsUsers.GetAllUsers();
            DataTable dtUsers = dtGetAllUsers.DefaultView.ToTable(false, "UserID", "FullName", "UserName", "IsActive");

            if (string.IsNullOrWhiteSpace(searchText))
            {
                dtUsers.DefaultView.RowFilter = "";
                dgvUsers.DataSource = dtUsers;
                return;
            }

            if(searchType == "UserID")
            {
                dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}",searchType,searchText);
            }
            else if (searchType == "FullName" || searchType == "UserName")
            {
                dtUsers.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", searchType, searchText);
            }

            dgvUsers.DataSource = dtUsers;
            lblUsersCounter.Text = $"Showing {dgvUsers.Rows.Count} Users";
        }

        private async void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            frmAddUpdateUser frm = new frmAddUpdateUser(clsUsers.Find(userID),frmAddUpdateUser.enStatus.Update);
            frm.ShowDialog();
            await _LoadData();
        }

        private async void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int userID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            frmAddUpdateUser frm = new frmAddUpdateUser(clsUsers.Find(userID), frmAddUpdateUser.enStatus.UpdateWithPassword);
            frm.ShowDialog();
            await _LoadData();
        }

        private async void toggleActiveStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            clsUsers user = clsUsers.Find(userID);
            user.IsActive = !user.IsActive;
            if(user.Save())
            {
                MessageBox.Show("User status change successfully!","Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User status change failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            await _LoadData();
        }

        private async void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            if (
               MessageBox.Show("Are you sure that you want to delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == DialogResult.Yes
               )
            {
                if (clsUsers.DeleteUsers(userID))
                {
                    MessageBox.Show("User deleted successfully!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User deleted failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                await _LoadData();
            }
        }
    }
}
