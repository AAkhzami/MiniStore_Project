using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MiniStore.Customers.Control.Page
{
    public partial class ctrlSearchOnCustomer : UserControl
    {
        public ctrlSearchOnCustomer()
        {
            InitializeComponent();
        }
        
        public delegate void SearchingChangeEventHandler(string SearchText, byte SearchType);
        public SearchingChangeEventHandler OnSearch;

        private void cbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchType = cbSearchType.SelectedItem.ToString();
            switch(searchType)
            {
                case "Customer Name":
                    txbCustomerSearch.PlaceholderText = "Search by name..";
                    break;
                case "Customer ID":
                    txbCustomerSearch.PlaceholderText = "Search by customer ID..";
                    break;
                case "Customer Phone Number":
                    txbCustomerSearch.PlaceholderText = "Search by phone number..";
                    break;
            }
        }
        private byte GetSearchAsNumber(string searchType)
        {
            byte SearchType = 2;
            switch (searchType)
            {
                case "Customer ID":
                    SearchType = 1;
                    break;
                case "Customer Name":
                    SearchType = 2;
                    break;
                case "Customer Phone Number":
                    SearchType = 3;
                    break;
            }
            return SearchType;
        }
        private void txbCustomerSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbSearchType.Text != "Customer Name")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
;
        }
        public void Reset(int id)
        {
            txbCustomerSearch.Text = "";
            cbSearchType.StartIndex = 0;
            OnSearch?.Invoke(txbCustomerSearch.Text, 2);
        }
        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frm = new frmAddUpdateCustomer();
            frm.OnCustomerCreate += Reset;
            frm.ShowDialog();
        }
        public void FocusOnTextSearch()
        {
            txbCustomerSearch.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string SearchText = txbCustomerSearch.Text;
            byte SearchType = GetSearchAsNumber(cbSearchType.Text);

            OnSearch?.Invoke(SearchText, SearchType);
        }

        private void txbCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txbCustomerSearch.Text;
            byte SearchType = GetSearchAsNumber(cbSearchType.Text);
            OnSearch?.Invoke(searchText, SearchType);
        }
    }
}
