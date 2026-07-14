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
        clsProducts _product;
        public ctrlProductInfo()
        {
            InitializeComponent();
        }

        public void LoadData(clsProducts ProductInfo)
        {
            this._product = ProductInfo;

            if (_product != null)
            {
                lblProductName.Text = _product.Name;
                lblCategory.Text = clsCategories.Find(_product.CategoryID).Name;
                lblPrice.Text = _product.Price + " OMR";
                lblStockQty.Text = _product.StockQuantity.ToString();
                lblIsActive.Text = _product.IsActive.ToString();
                lblCreatedBy.Text = clsUsers.Find(_product.CreatedByUserID).UserName;
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
