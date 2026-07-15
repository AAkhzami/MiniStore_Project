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

        private void ctrlPOSPage_Load(object sender, EventArgs e)
        {
            ctrlCart1.OnRecalc += ctrlCart1_OnRecalc;

            ctrlSearchProducts1.OnProductSelecte += ctrlCart1.AddCart;
            ctrlInvoiceSummary1.OnCancel += ctrlCart1.ResetTheCart;
            ctrlInvoiceSummary1.OnOrderCreate += ctrlCart1.InsertItemsOnDatabase;
            ctrlInvoiceSummary1.customerId = (ctrlSearchProducts1.CustomerType == "Cash Customer(Walk-in)" ? 1 : -1);

        }
    
        private void ctrlCart1_OnRecalc(decimal price)
        {
            ctrlInvoiceSummary1.AddPrice(price);
        }
    }
}
