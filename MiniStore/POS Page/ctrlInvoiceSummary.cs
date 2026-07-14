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
    public partial class ctrlInvoiceSummary : UserControl
    {
        decimal totalPrice = 0;
        public ctrlInvoiceSummary()
        {
            InitializeComponent();
        }
        public void AddPrice(decimal price)
        {
            totalPrice += price;
        }
        public void ReducePrice(decimal price)
        {
            if(totalPrice - price > 0)
            {
                totalPrice -= price;
            }
            else
            {
                totalPrice = 0;
            }    
        }
        public void UpdateTotal()
        {
            lblSubtotal.Text = totalPrice.ToString();
        }
    }
}
