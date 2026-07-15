using Guna.UI2.WinForms;
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

        private void ctrlSearchProducts_Load(object sender, EventArgs e)
        {

        }
        
        private void btnInsertProduct_Click(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(txbProductSearch.Text);
            clsProducts product = clsProducts.Find(productID);
            if(!product.IsActive || product.StockQuantity == 0)
            {
                MessageBox.Show("Product unavailable (inactive or out of stock)", "Unavailable", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (product != null)
            {
                //MessageBox.Show($"Product Name : {product.Name} -- Price : {product.Price} OMR");
                OnProductSelecte?.Invoke(productID, product.Name, product.Price);
            }
            else
            {
                MessageBox.Show("Product not found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
