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

namespace MiniStore.Customers.Control.Page
{
    public partial class ctrlTableOfCustomers : UserControl
    {
        private static DataTable _dtCustomers;
        public enum enSearchType { CustomerID = 1, CustomerName = 2, CustomerPhone =3}
        enSearchType _SearchType = enSearchType.CustomerID;
        public ctrlTableOfCustomers()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            _dtCustomers = clsCustomers.GetAllCustomers();
            dgvTableCustomers.DataSource = _dtCustomers;
            if(_dtCustomers.Rows.Count > 0)
            {
                dgvTableCustomers.Columns[0].HeaderText = "Customer ID";
                dgvTableCustomers.Columns[0].Width = 416;

                dgvTableCustomers.Columns[1].HeaderText = "Full Name";
                dgvTableCustomers.Columns[1].Width = 417;

                dgvTableCustomers.Columns[2].HeaderText = "Phone Number";
                dgvTableCustomers.Columns[2].Width = 416;
            }

            lblCustomersCounter.Text = $"Showing {_dtCustomers.Rows.Count} customers";
        }
        public void SearchBy(string Text, byte searchType = 1)
        {
            _SearchType = (enSearchType)searchType;
            string FilterColumn = "";
            if(string.IsNullOrWhiteSpace(Text))
            {
                _dtCustomers.DefaultView.RowFilter = "";
                dgvTableCustomers.DataSource = _dtCustomers;
                return;
            }

            switch(_SearchType)
            {
                case enSearchType.CustomerID:
                    FilterColumn = "CustomerID";
                    break;
                case enSearchType.CustomerName:
                    FilterColumn = "CustomerName";
                    break;
                case enSearchType.CustomerPhone:
                    FilterColumn = "PhoneNumber";
                    break;
            }

            if (FilterColumn == "CustomerID")
            {
                _dtCustomers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, Text);
            }
            else if (FilterColumn == "CustomerName" || FilterColumn == "PhoneNumber")
            {
                _dtCustomers.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, Text);
            }

            dgvTableCustomers.DataSource = _dtCustomers.DefaultView;
            dgvTableCustomers.Text = "Showing Products : " + dgvTableCustomers.Rows.Count.ToString();
        }

        private void ctrlTableOfCustomers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void editCustToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CustomerID = (int)dgvTableCustomers.CurrentRow.Cells[0].Value;
            frmAddUpdateCustomer frm = new frmAddUpdateCustomer(clsCustomers.Find(CustomerID));
            frm.ShowDialog();
            ctrlTableOfCustomers_Load(null,null);
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CustomerID = (int)dgvTableCustomers.CurrentRow.Cells[0].Value;
            if(clsCustomers.DeleteCustomers(CustomerID))
            {
                MessageBox.Show("Customer Delete Successfully!","Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ctrlTableOfCustomers_Load(null, null);
                return;
            }
            else
            {
                MessageBox.Show("Customer Delete Failed!","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        private void customerInfoStripMenuItem1_Click(object sender, EventArgs e)
        {
            int CustomerID = (int)dgvTableCustomers.CurrentRow.Cells[0].Value;
            frmCustomerStatistics frm = new frmCustomerStatistics(CustomerID);
            frm.ShowDialog();
        }
    }
}
