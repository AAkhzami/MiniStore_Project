namespace MiniStore.POS_Page
{
    partial class ctrlSearchProducts
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
            this.btnInsertProduct = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.cbSearchType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txbProductSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel10
            // 
            this.guna2ShadowPanel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel10.Controls.Add(this.btnInsertProduct);
            this.guna2ShadowPanel10.Controls.Add(this.guna2ComboBox1);
            this.guna2ShadowPanel10.Controls.Add(this.lable1);
            this.guna2ShadowPanel10.Controls.Add(this.cbSearchType);
            this.guna2ShadowPanel10.Controls.Add(this.txbProductSearch);
            this.guna2ShadowPanel10.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel10.Location = new System.Drawing.Point(1, 1);
            this.guna2ShadowPanel10.Margin = new System.Windows.Forms.Padding(1);
            this.guna2ShadowPanel10.Name = "guna2ShadowPanel10";
            this.guna2ShadowPanel10.Radius = 9;
            this.guna2ShadowPanel10.ShadowColor = System.Drawing.Color.Silver;
            this.guna2ShadowPanel10.Size = new System.Drawing.Size(1296, 98);
            this.guna2ShadowPanel10.TabIndex = 1;
            // 
            // btnInsertProduct
            // 
            this.btnInsertProduct.BorderRadius = 9;
            this.btnInsertProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInsertProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInsertProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInsertProduct.ForeColor = System.Drawing.Color.White;
            this.btnInsertProduct.Image = global::MiniStore.Properties.Resources.down;
            this.btnInsertProduct.Location = new System.Drawing.Point(587, 20);
            this.btnInsertProduct.Name = "btnInsertProduct";
            this.btnInsertProduct.Size = new System.Drawing.Size(56, 56);
            this.btnInsertProduct.TabIndex = 20;
            this.btnInsertProduct.Click += new System.EventHandler(this.btnInsertProduct_Click);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 9;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Cash Customer (Walk-in)",
            "Registered Customer"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(965, 42);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(294, 36);
            this.guna2ComboBox1.StartIndex = 0;
            this.guna2ComboBox1.TabIndex = 19;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.lable1.Location = new System.Drawing.Point(965, 20);
            this.lable1.Margin = new System.Windows.Forms.Padding(30, 30, 30, 10);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(77, 19);
            this.lable1.TabIndex = 18;
            this.lable1.Text = "Customer";
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
            "Product Name",
            "Product ID"});
            this.cbSearchType.Location = new System.Drawing.Point(667, 42);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(185, 36);
            this.cbSearchType.StartIndex = 0;
            this.cbSearchType.TabIndex = 2;
            // 
            // txbProductSearch
            // 
            this.txbProductSearch.BorderRadius = 9;
            this.txbProductSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbProductSearch.DefaultText = "";
            this.txbProductSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbProductSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbProductSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbProductSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbProductSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbProductSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txbProductSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbProductSearch.IconLeft = global::MiniStore.Properties.Resources.search;
            this.txbProductSearch.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txbProductSearch.Location = new System.Drawing.Point(20, 20);
            this.txbProductSearch.Margin = new System.Windows.Forms.Padding(20);
            this.txbProductSearch.Name = "txbProductSearch";
            this.txbProductSearch.PlaceholderText = "Insert product ID...";
            this.txbProductSearch.SelectedText = "";
            this.txbProductSearch.Size = new System.Drawing.Size(558, 58);
            this.txbProductSearch.TabIndex = 0;
            // 
            // ctrlSearchProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel10);
            this.Name = "ctrlSearchProducts";
            this.Size = new System.Drawing.Size(1298, 100);
            this.Load += new System.EventHandler(this.ctrlSearchProducts_Load);
            this.guna2ShadowPanel10.ResumeLayout(false);
            this.guna2ShadowPanel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel10;
        private Guna.UI2.WinForms.Guna2TextBox txbProductSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchType;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label lable1;
        private Guna.UI2.WinForms.Guna2Button btnInsertProduct;
    }
}
