using MiniStore.Orders;
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
    public partial class ctrlCart : UserControl
    {
        public ctrlCart()
        {
            InitializeComponent();
        }

        public delegate void RecalculateInvoiceEventHandler(decimal price);
        public event RecalculateInvoiceEventHandler OnRecalc;

        private void _GenerateColumns()
        {
            DataGridViewTextBoxColumn colProductName = new DataGridViewTextBoxColumn();
            colProductName.Name = "ProductName";
            colProductName.HeaderText = "Product";
            colProductName.Width = 250;
            colProductName.ReadOnly = true;
            dgvCart.Columns.Add(colProductName);

            DataGridViewTextBoxColumn colPrice = new DataGridViewTextBoxColumn();
            colPrice.Name = "Price";
            colPrice.HeaderText = "Price";
            colPrice.Width = 130;
            colPrice.ReadOnly = true;
            dgvCart.Columns.Add(colPrice);

            DataGridViewTextBoxColumn colQty = new DataGridViewTextBoxColumn();
            colQty.Name = "Qty";
            colQty.HeaderText = "Qty";
            colQty.Width = 100;
            colQty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colQty.ReadOnly = true; 
            dgvCart.Columns.Add(colQty);

            DataGridViewTextBoxColumn colSubTotal = new DataGridViewTextBoxColumn();
            colSubTotal.Name = "SubTotal";
            colSubTotal.HeaderText = "Total";
            colSubTotal.Width = 143; 
            colSubTotal.ReadOnly = true;
            dgvCart.Columns.Add(colSubTotal);

            //Product ID not visible
            DataGridViewTextBoxColumn colProductID = new DataGridViewTextBoxColumn();
            colProductID.Name = "ProductID";
            colProductID.Visible = false; 
            dgvCart.Columns.Add(colProductID);

            DataGridViewButtonColumn btnDecrease = new DataGridViewButtonColumn();
            btnDecrease.Name = "btnDecrease";
            btnDecrease.HeaderText = "Action";
            btnDecrease.Text = "-";
            btnDecrease.UseColumnTextForButtonValue = true;
            btnDecrease.Width = 100;
            btnDecrease.FlatStyle = FlatStyle.Flat;
            btnDecrease.DefaultCellStyle.BackColor = Color.White;
            btnDecrease.DefaultCellStyle.ForeColor = Color.FromArgb(100, 112, 145);
            //btnDecrease.DefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 57, 43);
            btnDecrease.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCart.Columns.Add(btnDecrease);

            DataGridViewButtonColumn btnIncrease = new DataGridViewButtonColumn();
            btnIncrease.Name = "btnIncrease";
            btnIncrease.HeaderText = "Action";
            btnIncrease.Text = "+";
            btnIncrease.UseColumnTextForButtonValue = true;
            btnIncrease.Width = 100;
            btnIncrease.FlatStyle = FlatStyle.Flat;
            btnIncrease.DefaultCellStyle.BackColor = Color.White;
            btnIncrease.DefaultCellStyle.ForeColor = Color.FromArgb(100,112,145);
            //btnIncrease.DefaultCellStyle.SelectionBackColor = Color.FromArgb(39, 174, 96);
            btnIncrease.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCart.Columns.Add(btnIncrease);
        }

        private void ctrlCart_Load(object sender, EventArgs e)
        {
            _GenerateColumns();

            dgvCart.CellContentClick += dgvCart_CellContentClick;
        }
        public void AddCart(int ProductID, string ProdcutName, decimal price)
        {
            bool isProductExist = false;
            // Search in the cart if the product exists or not already
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells["ProductID"].Value != null && (int)row.Cells["ProductID"].Value == ProductID)
                {
                    int currentQty = (int)row.Cells["Qty"].Value;
                    int StockQuantity = clsProducts.Find(ProductID).StockQuantity;
                    // Increase Qty
                    if (!(StockQuantity > currentQty))
                    {
                        MessageBox.Show($"The maximum quantity available for this product ({StockQuantity} pieces) has been reached.\nNo more than the current stock can be added.",
                            "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }
                    row.Cells["Qty"].Value = currentQty + 1;

                    //Calc the SubTotal
                    row.Cells["SubTotal"].Value = (currentQty + 1) * price;

                    isProductExist = true; 
                    break;
                }
            }

            if(!isProductExist)
            {
                dgvCart.Rows.Add(ProdcutName, price, 1, price, ProductID);
            }

            OnRecalc?.Invoke(price);
        }
        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string ColumnName = dgvCart.Columns[e.ColumnIndex].Name;

            decimal price = (decimal)dgvCart.Rows[e.RowIndex].Cells["Price"].Value;
            int currentQty = (int)dgvCart.Rows[e.RowIndex].Cells["Qty"].Value;

            if(ColumnName == "btnDecrease")
            {
                if(currentQty > 1)
                {
                    int newQty = currentQty - 1;
                    dgvCart.Rows[e.RowIndex].Cells["Qty"].Value = newQty;
                    dgvCart.Rows[e.RowIndex].Cells["SubTotal"].Value = price * newQty;
                    
                }
                else
                {
                    dgvCart.Rows.RemoveAt(e.RowIndex);
                }
                OnRecalc?.Invoke(-price);

            }
            else
            {
                int StockQuantity = clsProducts.Find((int)dgvCart.Rows[e.RowIndex].Cells["ProductID"].Value).StockQuantity;

                if (!(StockQuantity > currentQty))
                {
                    MessageBox.Show($"The maximum quantity available for this product ({StockQuantity} pieces) has been reached.\nNo more than the current stock can be added.",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int newQty = currentQty + 1;
                dgvCart.Rows[e.RowIndex].Cells["Qty"].Value = newQty;
                dgvCart.Rows[e.RowIndex].Cells["SubTotal"].Value = price * newQty;
                OnRecalc?.Invoke(price);
            }
        }

        private void removeTSM_Click(object sender, EventArgs e)
        {
            if(dgvCart.CurrentRow != null && dgvCart.CurrentRow.Index >= 0)
            {
                int rowIndex = dgvCart.CurrentRow.Index;
                decimal subTotal = Convert.ToDecimal(dgvCart.Rows[rowIndex].Cells["SubTotal"].Value);

                dgvCart.Rows.RemoveAt(rowIndex);

                OnRecalc?.Invoke(-subTotal);
            }
        }
        public void ResetTheCart()
        {
            dgvCart.Rows.Clear();
        }

        public void InsertItemsOnDatabase(int orderid, int customerID)
        {
            foreach(DataGridViewRow row in dgvCart.Rows)
            {
                clsOrderDetails detail = new clsOrderDetails();
                detail.OrderID = orderid;
                detail.ProductID = (int) row.Cells["ProductID"].Value;
                detail.Quantity = (int)row.Cells["Qty"].Value;
                detail.PricePerUnit = (decimal)row.Cells["Price"].Value;

                if(!detail.Save())
                {
                    MessageBox.Show("Something wrong try again later!", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                }
            }
            frmShowOrder frm = new frmShowOrder(clsOrders.Find(orderid),clsCustomers.Find(customerID));
            frm.ShowDialog();

            ResetTheCart();
        }
    }

}
