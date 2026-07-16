namespace MiniStore.Customers.Control.Page
{
    partial class ctrlCustomersPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ctrlTableOfCustomers1 = new MiniStore.Customers.Control.Page.ctrlTableOfCustomers();
            this.ctrlSearchOnCustomer1 = new MiniStore.Customers.Control.Page.ctrlSearchOnCustomer();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(115)))), ((int)(((byte)(138)))));
            this.label4.Location = new System.Drawing.Point(40, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Manage your customers and their information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(30, 30, 30, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 45);
            this.label5.TabIndex = 18;
            this.label5.Text = "Customers";
            // 
            // ctrlTableOfCustomers1
            // 
            this.ctrlTableOfCustomers1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlTableOfCustomers1.Location = new System.Drawing.Point(43, 222);
            this.ctrlTableOfCustomers1.Name = "ctrlTableOfCustomers1";
            this.ctrlTableOfCustomers1.Size = new System.Drawing.Size(1255, 548);
            this.ctrlTableOfCustomers1.TabIndex = 21;
            // 
            // ctrlSearchOnCustomer1
            // 
            this.ctrlSearchOnCustomer1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlSearchOnCustomer1.Location = new System.Drawing.Point(39, 116);
            this.ctrlSearchOnCustomer1.Name = "ctrlSearchOnCustomer1";
            this.ctrlSearchOnCustomer1.Size = new System.Drawing.Size(1259, 100);
            this.ctrlSearchOnCustomer1.TabIndex = 20;
            // 
            // ctrlCustomersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ctrlTableOfCustomers1);
            this.Controls.Add(this.ctrlSearchOnCustomer1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "ctrlCustomersPage";
            this.Size = new System.Drawing.Size(1323, 812);
            this.Load += new System.EventHandler(this.ctrlCustomersPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ctrlSearchOnCustomer ctrlSearchOnCustomer1;
        private ctrlTableOfCustomers ctrlTableOfCustomers1;
    }
}
