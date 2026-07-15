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

namespace MiniStore.POS_Page
{
    public partial class ctrlInvoiceSummary : UserControl
    {
        decimal _subtotalPrice = 0;
        decimal _cashPaid = 0;
        decimal _tax = 0;
        decimal _finalPrice = 0;

        public int customerId = -1;

        public delegate void ResetEventHandler();
        public event ResetEventHandler OnCancel;

        public delegate void OrderCreateEventHandler(int OrderID);
        public event OrderCreateEventHandler OnOrderCreate;

        public ctrlInvoiceSummary()
        {
            InitializeComponent();
        }
        public void AddPrice(decimal price)
        {
            _subtotalPrice += price;
            _Update();
        }
        public void ReducePrice(decimal price)
        {
            if(_subtotalPrice - price >= 0)
            {
                _subtotalPrice -= price;
                _Update();
            }
            else
            {
                _subtotalPrice = 0;
                nudCashPaid.Value = 0;
            }    
        }
        private void _Update()
        {
            _UpdateSubTotal();
            _UpdateTaxPrice(_subtotalPrice);
            _UpdateFinalTotal();
        }
        private void _UpdateSubTotal()
        {
            lblSubtotal.Text = _subtotalPrice.ToString();
            nudCashPaid.Enabled = _subtotalPrice > 0;        
            if(_subtotalPrice == 0)
            {
                lblSubtotal.Text = "00.00";
            }
        }
        private void _UpdateTaxPrice(decimal subtital)
        {
            _tax = (decimal)((double)subtital * 0.05);
            lblTax.Text = _tax.ToString();
            if(_tax ==  0)
            {
                lblTax.Text = "00.00";
            }
        }
        private void _UpdateFinalTotal()
        {
            _finalPrice = _subtotalPrice + _tax;
            lblFinalTotal.Text = _finalPrice.ToString();
            if( _subtotalPrice == 0)
            {
                lblFinalTotal.Text = "00.00";
            }
        }
        private void _ResetCashPaid()
        {
            lblChange.Text = "00.00";
            nudCashPaid.Value = 0;
        }

        private void nudCashPaid_ValueChanged(object sender, EventArgs e)
        {
            _cashPaid = nudCashPaid.Value;
            if (_cashPaid > 0)
            {
                lblChange.Text = (_cashPaid - _finalPrice).ToString();
            }
            else
            {
                lblChange.Text = "00.00";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _subtotalPrice = 0;
            _cashPaid = 0;
            _tax = 0;
            _finalPrice = 0;
            _Update();
            _ResetCashPaid();
            OnCancel?.Invoke();
        }
        
        private void btnPay_Click(object sender, EventArgs e)
        {
            clsOrders order = new clsOrders();
            order.CustomerID = customerId;
            order.OrderDate = DateTime.Now;
            order.TotalAmount = _finalPrice;
            order.CreatedByUserID = clsCurrentUser.CurrentUser.UserID ?? -1;

            if(!order.Save())
            {
                MessageBox.Show("Try again later!","Wrong",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            OnOrderCreate?.Invoke(order.OrderID ?? -1);
        }
    }
}
