namespace MiniStore.Customers
{
    partial class frmCustomerStatistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlCustomerInfo1 = new MiniStore.Customers.ctrlCustomerInfo();
            this.ctrlCustomerStatistics1 = new MiniStore.Customers.ctrlCustomerStatistics();
            this.ctrlOrdersDetailTable1 = new MiniStore.Orders.Control.ctrlOrdersDetailTable();
            this.SuspendLayout();
            // 
            // ctrlCustomerInfo1
            // 
            this.ctrlCustomerInfo1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlCustomerInfo1.Location = new System.Drawing.Point(30, 12);
            this.ctrlCustomerInfo1.Name = "ctrlCustomerInfo1";
            this.ctrlCustomerInfo1.Size = new System.Drawing.Size(751, 376);
            this.ctrlCustomerInfo1.TabIndex = 1;
            // 
            // ctrlCustomerStatistics1
            // 
            this.ctrlCustomerStatistics1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlCustomerStatistics1.Location = new System.Drawing.Point(30, 394);
            this.ctrlCustomerStatistics1.Name = "ctrlCustomerStatistics1";
            this.ctrlCustomerStatistics1.Size = new System.Drawing.Size(751, 365);
            this.ctrlCustomerStatistics1.TabIndex = 0;
            // 
            // ctrlOrdersDetailTable1
            // 
            this.ctrlOrdersDetailTable1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlOrdersDetailTable1.Location = new System.Drawing.Point(787, 12);
            this.ctrlOrdersDetailTable1.Name = "ctrlOrdersDetailTable1";
            this.ctrlOrdersDetailTable1.Size = new System.Drawing.Size(731, 747);
            this.ctrlOrdersDetailTable1.TabIndex = 2;
            // 
            // frmCustomerStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1530, 827);
            this.Controls.Add(this.ctrlOrdersDetailTable1);
            this.Controls.Add(this.ctrlCustomerInfo1);
            this.Controls.Add(this.ctrlCustomerStatistics1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomerStatistics";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Statistics";
            this.Load += new System.EventHandler(this.frmCustomerStatistics_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlCustomerStatistics ctrlCustomerStatistics1;
        private ctrlCustomerInfo ctrlCustomerInfo1;
        private Orders.Control.ctrlOrdersDetailTable ctrlOrdersDetailTable1;
    }
}