namespace MiniStore.Inventory_Page
{
    partial class ctrl_InventoryPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvInventoryProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAddNewProduct = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel10 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.cbSearchType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbInventory_Categories = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txbInventorySearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel11 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.cbItemPerPage_Inventory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_Inventory_Text_For_Item_Per_Page = new System.Windows.Forms.Label();
            this.lbl_Inventory_PageNumber = new System.Windows.Forms.Label();
            this.btnNextPageProducts = new Guna.UI2.WinForms.Guna2Button();
            this.btnPreviesPageProducts = new Guna.UI2.WinForms.Guna2Button();
            this.lblCounterProductsPerPage = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cmsInventoryPage = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.editProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAtiveProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.disableDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryProducts)).BeginInit();
            this.guna2ShadowPanel10.SuspendLayout();
            this.guna2ShadowPanel11.SuspendLayout();
            this.cmsInventoryPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvInventoryProducts);
            this.panel5.Controls.Add(this.btnAddNewProduct);
            this.panel5.Controls.Add(this.guna2ShadowPanel10);
            this.panel5.Controls.Add(this.guna2ShadowPanel11);
            this.panel5.Location = new System.Drawing.Point(37, 129);
            this.panel5.Margin = new System.Windows.Forms.Padding(30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1256, 665);
            this.panel5.TabIndex = 15;
            // 
            // dgvInventoryProducts
            // 
            this.dgvInventoryProducts.AllowUserToAddRows = false;
            this.dgvInventoryProducts.AllowUserToDeleteRows = false;
            this.dgvInventoryProducts.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvInventoryProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(90)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventoryProducts.ColumnHeadersHeight = 45;
            this.dgvInventoryProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvInventoryProducts.ContextMenuStrip = this.cmsInventoryPage;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventoryProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInventoryProducts.Location = new System.Drawing.Point(20, 119);
            this.dgvInventoryProducts.Name = "dgvInventoryProducts";
            this.dgvInventoryProducts.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInventoryProducts.RowHeadersVisible = false;
            this.dgvInventoryProducts.RowTemplate.Height = 60;
            this.dgvInventoryProducts.Size = new System.Drawing.Size(1211, 457);
            this.dgvInventoryProducts.TabIndex = 4;
            this.dgvInventoryProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInventoryProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(90)))), ((int)(((byte)(243)))));
            this.dgvInventoryProducts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 11F);
            this.dgvInventoryProducts.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvInventoryProducts.ThemeStyle.ReadOnly = true;
            this.dgvInventoryProducts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInventoryProducts.ThemeStyle.RowsStyle.Height = 60;
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.BorderRadius = 9;
            this.btnAddNewProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(90)))), ((int)(((byte)(243)))));
            this.btnAddNewProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddNewProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddNewProduct.Image = global::MiniStore.Properties.Resources.add;
            this.btnAddNewProduct.Location = new System.Drawing.Point(1042, 36);
            this.btnAddNewProduct.Margin = new System.Windows.Forms.Padding(20);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(189, 54);
            this.btnAddNewProduct.TabIndex = 3;
            this.btnAddNewProduct.Text = "Add New Products";
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // guna2ShadowPanel10
            // 
            this.guna2ShadowPanel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel10.Controls.Add(this.cbSearchType);
            this.guna2ShadowPanel10.Controls.Add(this.cbInventory_Categories);
            this.guna2ShadowPanel10.Controls.Add(this.txbInventorySearch);
            this.guna2ShadowPanel10.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel10.Location = new System.Drawing.Point(20, 20);
            this.guna2ShadowPanel10.Margin = new System.Windows.Forms.Padding(20);
            this.guna2ShadowPanel10.Name = "guna2ShadowPanel10";
            this.guna2ShadowPanel10.Radius = 9;
            this.guna2ShadowPanel10.ShadowColor = System.Drawing.Color.Silver;
            this.guna2ShadowPanel10.Size = new System.Drawing.Size(876, 76);
            this.guna2ShadowPanel10.TabIndex = 0;
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
            "None",
            "Product Name",
            "Product ID"});
            this.cbSearchType.Location = new System.Drawing.Point(430, 20);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(185, 36);
            this.cbSearchType.StartIndex = 0;
            this.cbSearchType.TabIndex = 2;
            this.cbSearchType.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
            // 
            // cbInventory_Categories
            // 
            this.cbInventory_Categories.BackColor = System.Drawing.Color.Transparent;
            this.cbInventory_Categories.BorderRadius = 9;
            this.cbInventory_Categories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbInventory_Categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInventory_Categories.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbInventory_Categories.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbInventory_Categories.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.cbInventory_Categories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbInventory_Categories.ItemHeight = 30;
            this.cbInventory_Categories.Items.AddRange(new object[] {
            "All Categories"});
            this.cbInventory_Categories.Location = new System.Drawing.Point(621, 20);
            this.cbInventory_Categories.Name = "cbInventory_Categories";
            this.cbInventory_Categories.Size = new System.Drawing.Size(235, 36);
            this.cbInventory_Categories.StartIndex = 0;
            this.cbInventory_Categories.TabIndex = 1;
            this.cbInventory_Categories.SelectedIndexChanged += new System.EventHandler(this.cbInventory_Categories_SelectedIndexChanged);
            // 
            // txbInventorySearch
            // 
            this.txbInventorySearch.BorderRadius = 9;
            this.txbInventorySearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbInventorySearch.DefaultText = "";
            this.txbInventorySearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbInventorySearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbInventorySearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbInventorySearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbInventorySearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbInventorySearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txbInventorySearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbInventorySearch.IconLeft = global::MiniStore.Properties.Resources.search;
            this.txbInventorySearch.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txbInventorySearch.Location = new System.Drawing.Point(20, 20);
            this.txbInventorySearch.Margin = new System.Windows.Forms.Padding(20);
            this.txbInventorySearch.Name = "txbInventorySearch";
            this.txbInventorySearch.PlaceholderText = "Search products by name or ID...";
            this.txbInventorySearch.SelectedText = "";
            this.txbInventorySearch.Size = new System.Drawing.Size(400, 36);
            this.txbInventorySearch.TabIndex = 0;
            this.txbInventorySearch.Visible = false;
            this.txbInventorySearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            this.txbInventorySearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSearch_KeyPress);
            // 
            // guna2ShadowPanel11
            // 
            this.guna2ShadowPanel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel11.Controls.Add(this.cbItemPerPage_Inventory);
            this.guna2ShadowPanel11.Controls.Add(this.lbl_Inventory_Text_For_Item_Per_Page);
            this.guna2ShadowPanel11.Controls.Add(this.lbl_Inventory_PageNumber);
            this.guna2ShadowPanel11.Controls.Add(this.btnNextPageProducts);
            this.guna2ShadowPanel11.Controls.Add(this.btnPreviesPageProducts);
            this.guna2ShadowPanel11.Controls.Add(this.lblCounterProductsPerPage);
            this.guna2ShadowPanel11.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel11.Location = new System.Drawing.Point(20, 588);
            this.guna2ShadowPanel11.Margin = new System.Windows.Forms.Padding(20);
            this.guna2ShadowPanel11.Name = "guna2ShadowPanel11";
            this.guna2ShadowPanel11.Radius = 9;
            this.guna2ShadowPanel11.ShadowColor = System.Drawing.Color.Silver;
            this.guna2ShadowPanel11.Size = new System.Drawing.Size(1211, 69);
            this.guna2ShadowPanel11.TabIndex = 2;
            // 
            // cbItemPerPage_Inventory
            // 
            this.cbItemPerPage_Inventory.BackColor = System.Drawing.Color.Transparent;
            this.cbItemPerPage_Inventory.BorderRadius = 9;
            this.cbItemPerPage_Inventory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbItemPerPage_Inventory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemPerPage_Inventory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbItemPerPage_Inventory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbItemPerPage_Inventory.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.cbItemPerPage_Inventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbItemPerPage_Inventory.ItemHeight = 30;
            this.cbItemPerPage_Inventory.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50"});
            this.cbItemPerPage_Inventory.Location = new System.Drawing.Point(1076, 16);
            this.cbItemPerPage_Inventory.Name = "cbItemPerPage_Inventory";
            this.cbItemPerPage_Inventory.Size = new System.Drawing.Size(104, 36);
            this.cbItemPerPage_Inventory.StartIndex = 0;
            this.cbItemPerPage_Inventory.TabIndex = 15;
            this.cbItemPerPage_Inventory.SelectedIndexChanged += new System.EventHandler(this.cbItemPerPage_Inventory_SelectedIndexChanged);
            // 
            // lbl_Inventory_Text_For_Item_Per_Page
            // 
            this.lbl_Inventory_Text_For_Item_Per_Page.AutoSize = true;
            this.lbl_Inventory_Text_For_Item_Per_Page.BackColor = System.Drawing.Color.White;
            this.lbl_Inventory_Text_For_Item_Per_Page.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inventory_Text_For_Item_Per_Page.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(115)))), ((int)(((byte)(138)))));
            this.lbl_Inventory_Text_For_Item_Per_Page.Location = new System.Drawing.Point(951, 25);
            this.lbl_Inventory_Text_For_Item_Per_Page.Name = "lbl_Inventory_Text_For_Item_Per_Page";
            this.lbl_Inventory_Text_For_Item_Per_Page.Size = new System.Drawing.Size(120, 18);
            this.lbl_Inventory_Text_For_Item_Per_Page.TabIndex = 14;
            this.lbl_Inventory_Text_For_Item_Per_Page.Text = "Items per page :";
            // 
            // lbl_Inventory_PageNumber
            // 
            this.lbl_Inventory_PageNumber.AutoSize = true;
            this.lbl_Inventory_PageNumber.BackColor = System.Drawing.Color.White;
            this.lbl_Inventory_PageNumber.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inventory_PageNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(115)))), ((int)(((byte)(138)))));
            this.lbl_Inventory_PageNumber.Location = new System.Drawing.Point(558, 22);
            this.lbl_Inventory_PageNumber.Name = "lbl_Inventory_PageNumber";
            this.lbl_Inventory_PageNumber.Size = new System.Drawing.Size(23, 25);
            this.lbl_Inventory_PageNumber.TabIndex = 13;
            this.lbl_Inventory_PageNumber.Text = "1";
            // 
            // btnNextPageProducts
            // 
            this.btnNextPageProducts.BorderRadius = 9;
            this.btnNextPageProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNextPageProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNextPageProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNextPageProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNextPageProducts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNextPageProducts.ForeColor = System.Drawing.Color.White;
            this.btnNextPageProducts.Image = global::MiniStore.Properties.Resources.right;
            this.btnNextPageProducts.Location = new System.Drawing.Point(603, 14);
            this.btnNextPageProducts.Name = "btnNextPageProducts";
            this.btnNextPageProducts.Size = new System.Drawing.Size(40, 40);
            this.btnNextPageProducts.TabIndex = 12;
            this.btnNextPageProducts.Click += new System.EventHandler(this.btnNextPageProducts_Click);
            // 
            // btnPreviesPageProducts
            // 
            this.btnPreviesPageProducts.BorderRadius = 9;
            this.btnPreviesPageProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPreviesPageProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPreviesPageProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPreviesPageProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPreviesPageProducts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPreviesPageProducts.ForeColor = System.Drawing.Color.White;
            this.btnPreviesPageProducts.Image = global::MiniStore.Properties.Resources.left_small;
            this.btnPreviesPageProducts.Location = new System.Drawing.Point(496, 14);
            this.btnPreviesPageProducts.Name = "btnPreviesPageProducts";
            this.btnPreviesPageProducts.Size = new System.Drawing.Size(40, 40);
            this.btnPreviesPageProducts.TabIndex = 11;
            this.btnPreviesPageProducts.Click += new System.EventHandler(this.btnPreviesPageProducts_Click);
            // 
            // lblCounterProductsPerPage
            // 
            this.lblCounterProductsPerPage.AutoSize = true;
            this.lblCounterProductsPerPage.BackColor = System.Drawing.Color.White;
            this.lblCounterProductsPerPage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounterProductsPerPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(115)))), ((int)(((byte)(138)))));
            this.lblCounterProductsPerPage.Location = new System.Drawing.Point(17, 25);
            this.lblCounterProductsPerPage.Name = "lblCounterProductsPerPage";
            this.lblCounterProductsPerPage.Size = new System.Drawing.Size(169, 18);
            this.lblCounterProductsPerPage.TabIndex = 8;
            this.lblCounterProductsPerPage.Text = "Showing N of N products";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(115)))), ((int)(((byte)(138)))));
            this.label20.Location = new System.Drawing.Point(34, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(230, 18);
            this.label20.TabIndex = 14;
            this.label20.Text = "Manage Your Products amd stock";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(29, 19);
            this.label21.Margin = new System.Windows.Forms.Padding(30, 30, 30, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(176, 45);
            this.label21.TabIndex = 13;
            this.label21.Text = "Inventory";
            // 
            // cmsInventoryPage
            // 
            this.cmsInventoryPage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmsInventoryPage.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.cmsInventoryPage.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.cmsInventoryPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editProductToolStripMenuItem,
            this.addStockToolStripMenuItem,
            this.tsmAtiveProduct,
            this.disableDeleteToolStripMenuItem,
            this.viewDetailsToolStripMenuItem});
            this.cmsInventoryPage.Name = "cmsInventoryPage";
            this.cmsInventoryPage.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsInventoryPage.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsInventoryPage.RenderStyle.ColorTable = null;
            this.cmsInventoryPage.RenderStyle.RoundedEdges = true;
            this.cmsInventoryPage.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsInventoryPage.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsInventoryPage.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsInventoryPage.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsInventoryPage.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsInventoryPage.Size = new System.Drawing.Size(237, 174);
            this.cmsInventoryPage.Opening += new System.ComponentModel.CancelEventHandler(this.cmsInventoryPage_Opening);
            // 
            // editProductToolStripMenuItem
            // 
            this.editProductToolStripMenuItem.Image = global::MiniStore.Properties.Resources.edit;
            this.editProductToolStripMenuItem.Name = "editProductToolStripMenuItem";
            this.editProductToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.editProductToolStripMenuItem.Text = "Edit Product";
            this.editProductToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.editProductToolStripMenuItem.Click += new System.EventHandler(this.editProductToolStripMenuItem_Click);
            // 
            // addStockToolStripMenuItem
            // 
            this.addStockToolStripMenuItem.Image = global::MiniStore.Properties.Resources.add_2;
            this.addStockToolStripMenuItem.Name = "addStockToolStripMenuItem";
            this.addStockToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.addStockToolStripMenuItem.Text = "Add Stock";
            this.addStockToolStripMenuItem.Click += new System.EventHandler(this.addStockToolStripMenuItem_Click);
            // 
            // tsmAtiveProduct
            // 
            this.tsmAtiveProduct.Enabled = false;
            this.tsmAtiveProduct.Name = "tsmAtiveProduct";
            this.tsmAtiveProduct.Size = new System.Drawing.Size(236, 34);
            this.tsmAtiveProduct.Text = "Active";
            this.tsmAtiveProduct.Click += new System.EventHandler(this.tsmActiveProduct_Click);
            // 
            // disableDeleteToolStripMenuItem
            // 
            this.disableDeleteToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.disableDeleteToolStripMenuItem.Image = global::MiniStore.Properties.Resources.trash;
            this.disableDeleteToolStripMenuItem.Name = "disableDeleteToolStripMenuItem";
            this.disableDeleteToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.disableDeleteToolStripMenuItem.Text = "Disable/Delete";
            this.disableDeleteToolStripMenuItem.Click += new System.EventHandler(this.disableDeleteToolStripMenuItem_Click);
            // 
            // viewDetailsToolStripMenuItem
            // 
            this.viewDetailsToolStripMenuItem.Image = global::MiniStore.Properties.Resources.view;
            this.viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            this.viewDetailsToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.viewDetailsToolStripMenuItem.Text = "View Details";
            this.viewDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewDetailsToolStripMenuItem_Click);
            // 
            // ctrl_InventoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Name = "ctrl_InventoryPage";
            this.Size = new System.Drawing.Size(1323, 812);
            this.Load += new System.EventHandler(this.ctrl_InventoryPage_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryProducts)).EndInit();
            this.guna2ShadowPanel10.ResumeLayout(false);
            this.guna2ShadowPanel11.ResumeLayout(false);
            this.guna2ShadowPanel11.PerformLayout();
            this.cmsInventoryPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInventoryProducts;
        private Guna.UI2.WinForms.Guna2Button btnAddNewProduct;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel10;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchType;
        private Guna.UI2.WinForms.Guna2ComboBox cbInventory_Categories;
        private Guna.UI2.WinForms.Guna2TextBox txbInventorySearch;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel11;
        private Guna.UI2.WinForms.Guna2ComboBox cbItemPerPage_Inventory;
        private System.Windows.Forms.Label lbl_Inventory_Text_For_Item_Per_Page;
        private System.Windows.Forms.Label lbl_Inventory_PageNumber;
        private Guna.UI2.WinForms.Guna2Button btnNextPageProducts;
        private Guna.UI2.WinForms.Guna2Button btnPreviesPageProducts;
        private System.Windows.Forms.Label lblCounterProductsPerPage;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsInventoryPage;
        private System.Windows.Forms.ToolStripMenuItem editProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAtiveProduct;
        private System.Windows.Forms.ToolStripMenuItem disableDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDetailsToolStripMenuItem;
    }
}
