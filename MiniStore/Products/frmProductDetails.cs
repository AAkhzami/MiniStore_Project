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
    public partial class frmProductDetails : Form
    {
        clsProducts _product;
        public frmProductDetails(int prodcutID)
        {
            InitializeComponent();
            _product = clsProducts.Find(prodcutID);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            ctrlProductInfo1.LoadData(_product);
        }
    }
}
