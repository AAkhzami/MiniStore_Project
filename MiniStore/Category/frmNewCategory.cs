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

namespace MiniStore.Category
{
    public partial class frmNewCategory : Form
    {
        public delegate void DataSavedEventHandler(string NewCategory);
        public event DataSavedEventHandler DataSaved;
        public frmNewCategory()
        {
            InitializeComponent();
        }

        private void txbProductName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbCategoryName.Text))
            {
                errorProvider1.SetError(txbCategoryName, "Please enter a category name.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txbCategoryName, string.Empty);
            }
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string categoryName = txbCategoryName.Text.Trim();

            clsCategories category = new clsCategories();
            category.Name = categoryName;
            
            if(category.Save())
            {
                MessageBox.Show("Category saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataSaved?.Invoke(categoryName);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
