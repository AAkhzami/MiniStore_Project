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

namespace MiniStore.Products
{
    public partial class frmAddStock : Form
    {
        clsProducts _product;
        public frmAddStock(int productID)
        {
            InitializeComponent();
            _product = clsProducts.Find(productID);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddStock_Load(object sender, EventArgs e)
        {
            ctrlProductInfo1.LoadData(_product);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int addBy = (int)nudAddQuantity.Value;
            if(addBy > 0)
            {
                _product.StockQuantity = _product.StockQuantity + addBy;
                if (_product.Save())
                {
                    MessageBox.Show("Quantity has been added successfully,\nNew quantity: " + _product.StockQuantity, "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrlProductInfo1.LoadData(_product);
                    nudAddQuantity.Value = 0;
                }
                else
                {
                    MessageBox.Show("Add the new quantity fail, try again", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nudAddQuantity.Focus();
                }
            }
            else
            {
                MessageBox.Show("You did not include any value!","Wrong",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            
        }
    }
}
