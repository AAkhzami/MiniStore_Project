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

        private static DataTable _dtGetAllUsers = clsUsers.GetAllUsers();
        DataTable _dtUsers = _dtGetAllUsers.DefaultView.ToTable(false, "UserID","FullName","UserName","IsActive");

        private void ctrlListUsers_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = _dtUsers;
            if(_dtUsers.Rows.Count > 0 )
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
        public void SearchOnUser(string searchType, string searchText)
        {            
            if (string.IsNullOrWhiteSpace(searchText))
            {
                _dtUsers.DefaultView.RowFilter = "";
                dgvUsers.DataSource = _dtUsers;
                return;
            }

            if(searchText == "UserID")
            {
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}",searchType,searchText);
            }
            else if (searchText == "FullName" || searchText == "UserName")
            {
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", searchType, searchText);
            }

            dgvUsers.DataSource = _dtUsers;
            lblUsersCounter.Text = $"Showing {dgvUsers.Rows.Count} Users";
        }
    }
}
