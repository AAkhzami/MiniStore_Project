using Guna.UI2.WinForms;
using MiniStore.Customers;
using MiniStoreDB_Business_Layer;
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

namespace MiniStore.POS_Page
{
    public partial class ctrlSearchProducts : UserControl
    {
        
        public ctrlSearchProducts()
        {
            InitializeComponent();
        }

        public delegate void SelectProductEventHandler(int productID, string productName, decimal price);
        public event SelectProductEventHandler OnProductSelecte;

        public delegate void SelectCustomerEventHandler(int customerID);
        public event SelectCustomerEventHandler OnCustomerSelecte;

        private void ctrlSearchProducts_Load(object sender, EventArgs e)
        {

        }
        public void Reset(int id)
        {
            cbCustomerType.TabIndex = 0;
            txbProductSearch.Text = "";
        }
        private void btnInsertProduct_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txbProductSearch.Text))
            {
                MessageBox.Show("It appears that you did not enter any value in the search box.", "Not allowed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txbProductSearch.Focus();
                return;
            }
            int productID = Convert.ToInt32(txbProductSearch.Text);
            clsProducts product = clsProducts.Find(productID);

            if (product != null)
            {
                if (!product.IsActive || product.StockQuantity == 0)
                {
                    MessageBox.Show("Product unavailable (inactive or out of stock)", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                OnProductSelecte?.Invoke(productID, product.Name, product.Price);
            }
            else
            {
                MessageBox.Show("Product not found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CustomerSelected(int customerID)
        {
            OnCustomerSelecte?.Invoke(customerID);
        }

        private void cbCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCustomerType.Text == "Registered Customer")
            {
                frmCustomerInfo frm = new frmCustomerInfo();
                frm.OnCustomerSelect += CustomerSelected;
                frm.ShowDialog();
                return;
            }
            else if (cbCustomerType.Text == "New Customer")
            {
                frmAddUpdateCustomer frm = new frmAddUpdateCustomer();
                frm.OnCustomerCreate += CustomerSelected;
                frm.ShowDialog();
                return;
            }
            else
            {
                CustomerSelected(1);
                return;
            }
        }

        private void txbProductSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
