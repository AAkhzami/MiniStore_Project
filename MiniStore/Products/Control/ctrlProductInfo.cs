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

namespace MiniStore.Products.Control
{
    public partial class ctrlProductInfo : UserControl
    {
        int _productId = -1;
        public ctrlProductInfo()
        {
            InitializeComponent();
        }

        public void LoadData(int ProductID)
        {
            _productId = ProductID;
            clsProducts product = clsProducts.Find(_productId);

            if (product != null)
            {
                lblProductName.Text = product.Name;
                lblCategory.Text = clsCategories.Find(product.CategoryID).Name;
                lblPrice.Text = product.Price + " OMR";
                lblStockQty.Text = product.StockQuantity.ToString();
                lblIsActive.Text = product.IsActive.ToString();
                lblCreatedBy.Text = clsUsers.Find(product.CreatedByUserID).UserName;
            }
            else
            {
                MessageBox.Show("Product not found!","Not found", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void Reset()
        {
            lblProductName.Text = "NULL";
            lblCategory.Text = "NULL";
            lblPrice.Text = "00 OMR";
            lblStockQty.Text = "0000";
            lblIsActive.Text = "NULL";
            lblCreatedBy.Text = "NULL";
        }
    }
}
