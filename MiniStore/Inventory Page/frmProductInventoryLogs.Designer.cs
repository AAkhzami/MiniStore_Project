namespace MiniStore.Inventory_Page
{
    partial class frmProductInventoryLogs
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbLogo_Of_Page = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Of_Page)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderRadius = 9;
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(121)))), ((int)(((byte)(243)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 197);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(633, 601);
            this.guna2GroupBox1.TabIndex = 42;
            this.guna2GroupBox1.Text = "Logs";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.lblTitle.Location = new System.Drawing.Point(162, 126);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(30, 30, 30, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(313, 45);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "Product Stock Log";
            // 
            // pbLogo_Of_Page
            // 
            this.pbLogo_Of_Page.Image = global::MiniStore.Properties.Resources.clipboard;
            this.pbLogo_Of_Page.Location = new System.Drawing.Point(286, 37);
            this.pbLogo_Of_Page.Margin = new System.Windows.Forms.Padding(30);
            this.pbLogo_Of_Page.Name = "pbLogo_Of_Page";
            this.pbLogo_Of_Page.Size = new System.Drawing.Size(85, 85);
            this.pbLogo_Of_Page.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo_Of_Page.TabIndex = 40;
            this.pbLogo_Of_Page.TabStop = false;
            // 
            // frmProductInventoryLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 810);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbLogo_Of_Page);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductInventoryLogs";
            this.ShowIcon = false;
            this.Text = "Product Stock Log";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Of_Page)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbLogo_Of_Page;
    }
}