using MiniStore.Products;
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
    public partial class ctrlPOSPage : UserControl
    {
        public ctrlPOSPage()
        {
            InitializeComponent();
        }
        public void RemoveProductFromCart(int productID)
        {
            ctrlCart1.RemoveItem(productID);
        }
        private void ctrlPOSPage_Load(object sender, EventArgs e)
        {
            ctrlCart1.OnRecalc += ctrlCart1_OnRecalc;

            ctrlSearchProducts1.OnProductSelecte += ctrlCart1.AddCart;
            ctrlInvoiceSummary1.OnCancel += ctrlCart1.ResetTheCart;
            ctrlInvoiceSummary1.OnOrderCreate += ctrlCart1.InsertItemsOnDatabase;
            ctrlSearchProducts1.OnCustomerSelecte += ctrlInvoiceSummary1.SetCustomerID;
            ctrlInvoiceSummary1.OnOrderCreate += ctrlSearchProducts1.Reset;
        }    
        private void ctrlCart1_OnRecalc(decimal price)
        {
            ctrlInvoiceSummary1.AddPrice(price);
        }
    }
}
