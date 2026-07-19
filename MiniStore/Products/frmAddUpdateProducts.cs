using MiniStore.Category;
using MiniStore.Global;
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
    public partial class frmAddUpdateProducts : Form
    {
        public enum enStatus { AddProduct, UpdateProduct }
        enStatus _status = enStatus.AddProduct;
        int _productID = -1;
        clsProducts _ProductInfo;
        public frmAddUpdateProducts()
        {
            InitializeComponent();
            _status = enStatus.AddProduct;
        }
        public frmAddUpdateProducts(int ProductID)
        {
            InitializeComponent();
            _productID = ProductID;
            _status = enStatus.UpdateProduct;
        }
        private void rbActive_Click(object sender, EventArgs e)
        {
            ChangingTheChoice();
        }

        private void rbInActive_Click(object sender, EventArgs e)
        {
            ChangingTheChoice();
        }
        void ChangingTheChoice()
        {
            if (rbActive.Checked)
            {
                rbActive.Checked = false;
                rbInActive.Checked = true;

                pInActive.BorderColor = Color.DodgerBlue;
                pInActive.FillColor = Color.AliceBlue;
                pInActive.FillColor2 = Color.AliceBlue;
                pInActive.FillColor3 = Color.AliceBlue;
                pInActive.FillColor4 = Color.AliceBlue;

                pActive.BorderColor = Color.Silver;
                pActive.FillColor = Color.White;
                pActive.FillColor2 = Color.White;
                pActive.FillColor3 = Color.White;
                pActive.FillColor4 = Color.White;
            }
            else
            {
                rbActive.Checked = true;
                rbInActive.Checked = false;

                pInActive.BorderColor = Color.Silver;
                pInActive.FillColor = Color.White;
                pInActive.FillColor2 = Color.White;
                pInActive.FillColor3 = Color.White;
                pInActive.FillColor4 = Color.White;

                pActive.BorderColor = Color.DodgerBlue;
                pActive.FillColor = Color.AliceBlue;
                pActive.FillColor2 = Color.AliceBlue;
                pActive.FillColor3 = Color.AliceBlue;
                pActive.FillColor4 = Color.AliceBlue;
            }
        }
        private void pActive_Click(object sender, EventArgs e)
        {
            ChangingTheChoice();
        }

        private void pInActive_Click(object sender, EventArgs e)
        {
            ChangingTheChoice();
        }

        private void txbProductName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbProductName.Text))
            {
                errorProvider1.SetError(txbProductName, "Product name is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txbProductName, "");
            }
        }

        private void frmAddUpdateProducts_Load(object sender, EventArgs e)
        {

            DataTable dt = clsCategories.GetAllCategories();

            foreach (DataRow row in dt.Rows)
            {
                cbCategory.Items.Add(row["Name"].ToString());
            }
            cbCategory.SelectedIndex = 0;

            switch (_status)
            {
                case enStatus.AddProduct:
                    this.Text = "Add Product";
                    lblTitle.Text = "Add New Product";
                    lblSubtitle.Text = "Enter the product details below to add it to your inventory.";
                    txbProductName.Text = "";
                    nudEstStockQuantity.Value = 0;
                    nudPrice.Value = 0;
                    _ProductInfo = new clsProducts();
                    break;
                case enStatus.UpdateProduct:
                    this.Text = "Update Product";
                    lblTitle.Text = "Update Product";
                    lblSubtitle.Text = "Enter the product details below to update.";
                    _ProductInfo = clsProducts.Find(_productID);
                    txbProductName.Text = _ProductInfo.Name.ToString();
                    nudEstStockQuantity.Value = _ProductInfo.StockQuantity;
                    nudPrice.Value = _ProductInfo.Price;
                    rbActive.Checked = !_ProductInfo.IsActive;
                    ChangingTheChoice();
                    break;
            }

            txbProductName.Focus();

        }
        private bool AddNewProduct()
        {

            string ProductName = txbProductName.Text.Trim();
            string CategoryName = cbCategory.SelectedItem.ToString();
            decimal Price = nudPrice.Value;
            int StockQuantity = (int)nudEstStockQuantity.Value;

            clsProducts p = new clsProducts();
            p.Name = ProductName;
            p.CategoryID = clsCategories.Find(CategoryName).CategoryID ?? -1;
            p.Price = Price;
            p.StockQuantity = StockQuantity;
            p.IsActive = rbActive.Checked;
            p.CreatedByUserID = clsCurrentUser.CurrentUser.UserID ?? -1;

            if (p.Save())
            {
                _ProductInfo = p;
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool UpdateProduct()
        {

            string ProductName = txbProductName.Text.Trim();
            decimal Price = nudPrice.Value;
            int StockQuantity = (int)nudEstStockQuantity.Value;


            _ProductInfo.Name = ProductName;
            _ProductInfo.Price = Price;
            _ProductInfo.StockQuantity = StockQuantity;
            _ProductInfo.IsActive = rbActive.Checked;

            if (_ProductInfo.Save())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (_status)
            {
                case enStatus.AddProduct:
                    if (AddNewProduct())
                    {
                        MessageBox.Show("Product saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case enStatus.UpdateProduct:
                    if (UpdateProduct())
                    {
                        MessageBox.Show("Product update successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

            }

        }
        void Frm_NewCategoryDataSaved(string NewCategory)
        {
            cbCategory.Items.Clear();
            DataTable dt = clsCategories.GetAllCategories();
            foreach (DataRow row in dt.Rows)
            {
                cbCategory.Items.Add(row["Name"].ToString());
            }
            cbCategory.SelectedIndex = cbCategory.Items.IndexOf(NewCategory);
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            frmNewCategory frm = new frmNewCategory();
            frm.DataSaved += Frm_NewCategoryDataSaved;
            frm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
