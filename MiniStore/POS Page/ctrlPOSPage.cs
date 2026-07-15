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
        int _customerID = 1;
        public ctrlPOSPage()
        {
            InitializeComponent();
        }
        public void GetCustomerID(int ID)
        {
            _customerID = ID;
            ctrlInvoiceSummary1.customerId = _customerID;
        }
        private void ctrlPOSPage_Load(object sender, EventArgs e)
        {
            ctrlCart1.OnRecalc += ctrlCart1_OnRecalc;

            ctrlSearchProducts1.OnProductSelecte += ctrlCart1.AddCart;
            ctrlInvoiceSummary1.OnCancel += ctrlCart1.ResetTheCart;
            ctrlInvoiceSummary1.OnOrderCreate += ctrlCart1.InsertItemsOnDatabase;
            ctrlSearchProducts1.OnCustomerSelecte += GetCustomerID;
        }
    
        private void ctrlCart1_OnRecalc(decimal price)
        {
            ctrlInvoiceSummary1.AddPrice(price);
        }
    }
}
