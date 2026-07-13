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
        public frmAddUpdateProducts()
        {
            InitializeComponent();
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
            if(string.IsNullOrWhiteSpace(txbProductName.Text))
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
            foreach(DataRow row in dt.Rows)
            {
                cbCategory.Items.Add(row["Name"].ToString());
            }
            cbCategory.SelectedIndex = 0;
        }
    }
}
