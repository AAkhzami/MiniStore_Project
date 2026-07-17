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
    public partial class ctrlSearchOnUser : UserControl
    {
        public ctrlSearchOnUser()
        {
            InitializeComponent();
        }

        public delegate void SearchingChangeEventHandler(string SearchType, string SearchText);
        public SearchingChangeEventHandler OnSearch;
        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
            OnSearch?.Invoke("","");
        }

        private void txbCustomerSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbSearchType.Text == "User ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        private string GetSearchAsNumber(string searchType)
        {
            string _searchType = "";
            switch (searchType)
            {
                case "User ID":
                    _searchType = "UserID";
                    break;
                case "User Name":
                    _searchType = "UserName";
                    break;
                case "FullName":
                    _searchType = "FullName";
                    break;
            }
            return _searchType;
        }
        private void txbCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txbCustomerSearch.Text;
            string SearchType = GetSearchAsNumber(cbSearchType.Text);
            OnSearch?.Invoke(SearchType, searchText);
        }
    }
}
