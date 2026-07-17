namespace MiniStore.Users.control
{
    partial class ctrlSearchOnUser
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
            this.guna2ShadowPanel10 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnAddNewCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.cbSearchType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txbCustomerSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel10
            // 
            this.guna2ShadowPanel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel10.Controls.Add(this.btnAddNewCustomer);
            this.guna2ShadowPanel10.Controls.Add(this.cbSearchType);
            this.guna2ShadowPanel10.Controls.Add(this.txbCustomerSearch);
            this.guna2ShadowPanel10.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel10.Location = new System.Drawing.Point(0, 1);
            this.guna2ShadowPanel10.Margin = new System.Windows.Forms.Padding(1);
            this.guna2ShadowPanel10.Name = "guna2ShadowPanel10";
            this.guna2ShadowPanel10.Radius = 9;
            this.guna2ShadowPanel10.ShadowColor = System.Drawing.Color.Silver;
            this.guna2ShadowPanel10.Size = new System.Drawing.Size(1258, 98);
            this.guna2ShadowPanel10.TabIndex = 3;
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.BorderRadius = 9;
            this.btnAddNewCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNewCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCustomer.Image = global::MiniStore.Properties.Resources.add;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(965, 20);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(267, 58);
            this.btnAddNewCustomer.TabIndex = 21;
            this.btnAddNewCustomer.Text = "Add New User";
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // cbSearchType
            // 
            this.cbSearchType.BackColor = System.Drawing.Color.Transparent;
            this.cbSearchType.BorderRadius = 9;
            this.cbSearchType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearchType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearchType.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.cbSearchType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSearchType.ItemHeight = 30;
            this.cbSearchType.Items.AddRange(new object[] {
            "User ID",
            "Full Name",
            "User Name"});
            this.cbSearchType.Location = new System.Drawing.Point(667, 30);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(249, 36);
            this.cbSearchType.StartIndex = 0;
            this.cbSearchType.TabIndex = 2;
            // 
            // txbCustomerSearch
            // 
            this.txbCustomerSearch.BorderRadius = 9;
            this.txbCustomerSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCustomerSearch.DefaultText = "";
            this.txbCustomerSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbCustomerSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbCustomerSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCustomerSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCustomerSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCustomerSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txbCustomerSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCustomerSearch.IconLeft = global::MiniStore.Properties.Resources.search;
            this.txbCustomerSearch.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txbCustomerSearch.Location = new System.Drawing.Point(20, 20);
            this.txbCustomerSearch.Margin = new System.Windows.Forms.Padding(20);
            this.txbCustomerSearch.Name = "txbCustomerSearch";
            this.txbCustomerSearch.PlaceholderText = "Search by name";
            this.txbCustomerSearch.SelectedText = "";
            this.txbCustomerSearch.Size = new System.Drawing.Size(558, 58);
            this.txbCustomerSearch.TabIndex = 0;
            this.txbCustomerSearch.TextChanged += new System.EventHandler(this.txbCustomerSearch_TextChanged);
            this.txbCustomerSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCustomerSearch_KeyPress);
            // 
            // ctrlSearchOnUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2ShadowPanel10);
            this.Name = "ctrlSearchOnUser";
            this.Size = new System.Drawing.Size(1259, 100);
            this.guna2ShadowPanel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel10;
        private Guna.UI2.WinForms.Guna2Button btnAddNewCustomer;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchType;
        private Guna.UI2.WinForms.Guna2TextBox txbCustomerSearch;
    }
}
