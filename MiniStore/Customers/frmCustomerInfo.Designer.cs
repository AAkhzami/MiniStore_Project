namespace MiniStore.Customers
{
    partial class frmCustomerInfo
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
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txbSearchOnCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddNewCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbLogo_Of_Page = new System.Windows.Forms.PictureBox();
            this.btnSelect = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Of_Page)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlCustomerInfo1
            // 
            this.ctrlCustomerInfo1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlCustomerInfo1.Location = new System.Drawing.Point(21, 302);
            this.ctrlCustomerInfo1.Name = "ctrlCustomerInfo1";
            this.ctrlCustomerInfo1.Size = new System.Drawing.Size(751, 376);
            this.ctrlCustomerInfo1.TabIndex = 35;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 9;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::MiniStore.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(670, 245);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 48);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearchOnCustomer
            // 
            this.txbSearchOnCustomer.BorderRadius = 9;
            this.txbSearchOnCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearchOnCustomer.DefaultText = "";
            this.txbSearchOnCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSearchOnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSearchOnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearchOnCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearchOnCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearchOnCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbSearchOnCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearchOnCustomer.IconLeft = global::MiniStore.Properties.Resources.search;
            this.txbSearchOnCustomer.Location = new System.Drawing.Point(21, 245);
            this.txbSearchOnCustomer.Name = "txbSearchOnCustomer";
            this.txbSearchOnCustomer.PlaceholderText = "Search using Phone Number";
            this.txbSearchOnCustomer.SelectedText = "";
            this.txbSearchOnCustomer.Size = new System.Drawing.Size(348, 48);
            this.txbSearchOnCustomer.TabIndex = 33;
            this.txbSearchOnCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSearchOnCustomer_KeyPress);
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.BorderRadius = 9;
            this.btnAddNewCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCustomer.Image = global::MiniStore.Properties.Resources.add;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(724, 245);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(48, 48);
            this.btnAddNewCustomer.TabIndex = 32;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.White;
            this.lblSubtitle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(115)))), ((int)(((byte)(138)))));
            this.lblSubtitle.Location = new System.Drawing.Point(327, 184);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(139, 18);
            this.lblSubtitle.TabIndex = 31;
            this.lblSubtitle.Text = "Search on customer";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.lblTitle.Location = new System.Drawing.Point(309, 134);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(30, 30, 30, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 45);
            this.lblTitle.TabIndex = 30;
            this.lblTitle.Text = "Customer";
            // 
            // pbLogo_Of_Page
            // 
            this.pbLogo_Of_Page.Image = global::MiniStore.Properties.Resources.user_32;
            this.pbLogo_Of_Page.Location = new System.Drawing.Point(354, 45);
            this.pbLogo_Of_Page.Margin = new System.Windows.Forms.Padding(30);
            this.pbLogo_Of_Page.Name = "pbLogo_Of_Page";
            this.pbLogo_Of_Page.Size = new System.Drawing.Size(85, 85);
            this.pbLogo_Of_Page.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo_Of_Page.TabIndex = 29;
            this.pbLogo_Of_Page.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.BorderRadius = 9;
            this.btnSelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelect.Enabled = false;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(567, 684);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(205, 57);
            this.btnSelect.TabIndex = 37;
            this.btnSelect.Text = "Select";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 9;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Crimson;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(354, 684);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(205, 57);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 753);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.ctrlCustomerInfo1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbSearchOnCustomer);
            this.Controls.Add(this.btnAddNewCustomer);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbLogo_Of_Page);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomerInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Info";
            this.Load += new System.EventHandler(this.frmCustomerInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Of_Page)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlCustomerInfo ctrlCustomerInfo1;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txbSearchOnCustomer;
        private Guna.UI2.WinForms.Guna2Button btnAddNewCustomer;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbLogo_Of_Page;
        private Guna.UI2.WinForms.Guna2Button btnSelect;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}