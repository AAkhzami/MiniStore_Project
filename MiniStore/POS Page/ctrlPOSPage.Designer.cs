namespace MiniStore.POS_Page
{
    partial class ctrlPOSPage
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
            this.ctrlSearchProducts1 = new MiniStore.POS_Page.ctrlSearchProducts();
            this.ctrlCart1 = new MiniStore.POS_Page.ctrlCart();
            this.ctrlInvoiceSummary1 = new MiniStore.POS_Page.ctrlInvoiceSummary();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlSearchProducts1
            // 
            this.ctrlSearchProducts1.Location = new System.Drawing.Point(12, 103);
            this.ctrlSearchProducts1.Name = "ctrlSearchProducts1";
            this.ctrlSearchProducts1.Size = new System.Drawing.Size(1298, 100);
            this.ctrlSearchProducts1.TabIndex = 15;
            // 
            // ctrlCart1
            // 
            this.ctrlCart1.Location = new System.Drawing.Point(12, 223);
            this.ctrlCart1.Name = "ctrlCart1";
            this.ctrlCart1.Size = new System.Drawing.Size(929, 570);
            this.ctrlCart1.TabIndex = 19;
            // 
            // ctrlInvoiceSummary1
            // 
            this.ctrlInvoiceSummary1.Location = new System.Drawing.Point(954, 223);
            this.ctrlInvoiceSummary1.Name = "ctrlInvoiceSummary1";
            this.ctrlInvoiceSummary1.Size = new System.Drawing.Size(349, 565);
            this.ctrlInvoiceSummary1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(115)))), ((int)(((byte)(138)))));
            this.label4.Location = new System.Drawing.Point(40, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Create new invoice and process payments";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(30, 30, 30, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 45);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sales / POS";
            // 
            // ctrlPOSPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ctrlSearchProducts1);
            this.Controls.Add(this.ctrlCart1);
            this.Controls.Add(this.ctrlInvoiceSummary1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "ctrlPOSPage";
            this.Size = new System.Drawing.Size(1323, 812);
            this.Load += new System.EventHandler(this.ctrlPOSPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlSearchProducts ctrlSearchProducts1;
        private ctrlCart ctrlCart1;
        private ctrlInvoiceSummary ctrlInvoiceSummary1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
