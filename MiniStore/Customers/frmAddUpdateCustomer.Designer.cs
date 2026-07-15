namespace MiniStore.Customers
{
    partial class frmAddUpdateCustomer
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbLogo_Of_Page = new System.Windows.Forms.PictureBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pInActive = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.rbInActive = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.pActive = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.rbActive = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCustomerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Of_Page)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.pInActive.SuspendLayout();
            this.pActive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.lblTitle.Location = new System.Drawing.Point(126, 128);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(30, 30, 30, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(332, 45);
            this.lblTitle.TabIndex = 36;
            this.lblTitle.Text = "Add New Customer";
            // 
            // pbLogo_Of_Page
            // 
            this.pbLogo_Of_Page.Image = global::MiniStore.Properties.Resources.user_32;
            this.pbLogo_Of_Page.Location = new System.Drawing.Point(250, 39);
            this.pbLogo_Of_Page.Margin = new System.Windows.Forms.Padding(30);
            this.pbLogo_Of_Page.Name = "pbLogo_Of_Page";
            this.pbLogo_Of_Page.Size = new System.Drawing.Size(85, 85);
            this.pbLogo_Of_Page.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo_Of_Page.TabIndex = 35;
            this.pbLogo_Of_Page.TabStop = false;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderRadius = 9;
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.txbPhoneNumber);
            this.guna2GroupBox1.Controls.Add(this.lblCustomerID);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.btnSaveCustomer);
            this.guna2GroupBox1.Controls.Add(this.btnCancel);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.pInActive);
            this.guna2GroupBox1.Controls.Add(this.pActive);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.txbCustomerName);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(121)))), ((int)(((byte)(243)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(21, 199);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(542, 532);
            this.guna2GroupBox1.TabIndex = 39;
            this.guna2GroupBox1.Text = "Customer Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.label5.Location = new System.Drawing.Point(33, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Phone Number";
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.BorderRadius = 9;
            this.txbPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPhoneNumber.DefaultText = "";
            this.txbPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txbPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPhoneNumber.Location = new System.Drawing.Point(36, 226);
            this.txbPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPhoneNumber.MaxLength = 9;
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.PlaceholderText = "Enter Phone Number";
            this.txbPhoneNumber.SelectedText = "";
            this.txbPhoneNumber.Size = new System.Drawing.Size(474, 48);
            this.txbPhoneNumber.TabIndex = 25;
            this.txbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPhoneNumber_KeyPress);
            this.txbPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txbPhoneNumber_Validating);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.lblCustomerID.Location = new System.Drawing.Point(149, 70);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(39, 21);
            this.lblCustomerID.TabIndex = 24;
            this.lblCustomerID.Text = "Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.label2.Location = new System.Drawing.Point(33, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Customer ID :";
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.BorderRadius = 9;
            this.btnSaveCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(121)))), ((int)(((byte)(243)))));
            this.btnSaveCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveCustomer.ForeColor = System.Drawing.Color.White;
            this.btnSaveCustomer.Location = new System.Drawing.Point(279, 456);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(231, 55);
            this.btnSaveCustomer.TabIndex = 22;
            this.btnSaveCustomer.Text = "Save";
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.Silver;
            this.btnCancel.BorderRadius = 9;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(115)))), ((int)(((byte)(138)))));
            this.btnCancel.Location = new System.Drawing.Point(36, 456);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(231, 55);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.label7.Location = new System.Drawing.Point(33, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Status";
            // 
            // pInActive
            // 
            this.pInActive.BorderColor = System.Drawing.Color.Silver;
            this.pInActive.BorderRadius = 9;
            this.pInActive.BorderThickness = 2;
            this.pInActive.Controls.Add(this.label1);
            this.pInActive.Controls.Add(this.rbInActive);
            this.pInActive.Location = new System.Drawing.Point(279, 329);
            this.pInActive.Name = "pInActive";
            this.pInActive.Size = new System.Drawing.Size(231, 106);
            this.pInActive.TabIndex = 19;
            this.pInActive.Click += new System.EventHandler(this.pInActive_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.label1.Location = new System.Drawing.Point(61, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Inactive Customer";
            // 
            // rbInActive
            // 
            this.rbInActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbInActive.CheckedState.BorderThickness = 5;
            this.rbInActive.CheckedState.FillColor = System.Drawing.Color.White;
            this.rbInActive.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbInActive.Location = new System.Drawing.Point(14, 35);
            this.rbInActive.Name = "rbInActive";
            this.rbInActive.Size = new System.Drawing.Size(29, 36);
            this.rbInActive.TabIndex = 38;
            this.rbInActive.Text = "guna2CustomRadioButton2";
            this.rbInActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbInActive.UncheckedState.BorderThickness = 2;
            this.rbInActive.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbInActive.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // pActive
            // 
            this.pActive.BackColor = System.Drawing.Color.Transparent;
            this.pActive.BorderColor = System.Drawing.Color.DodgerBlue;
            this.pActive.BorderRadius = 9;
            this.pActive.BorderThickness = 2;
            this.pActive.Controls.Add(this.rbActive);
            this.pActive.Controls.Add(this.label8);
            this.pActive.FillColor = System.Drawing.Color.AliceBlue;
            this.pActive.FillColor2 = System.Drawing.Color.AliceBlue;
            this.pActive.FillColor3 = System.Drawing.Color.AliceBlue;
            this.pActive.FillColor4 = System.Drawing.Color.AliceBlue;
            this.pActive.Location = new System.Drawing.Point(36, 329);
            this.pActive.Name = "pActive";
            this.pActive.Size = new System.Drawing.Size(231, 106);
            this.pActive.TabIndex = 18;
            // 
            // rbActive
            // 
            this.rbActive.Checked = true;
            this.rbActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbActive.CheckedState.BorderThickness = 5;
            this.rbActive.CheckedState.FillColor = System.Drawing.Color.White;
            this.rbActive.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbActive.Location = new System.Drawing.Point(14, 35);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(29, 36);
            this.rbActive.TabIndex = 35;
            this.rbActive.Text = "guna2CustomRadioButton1";
            this.rbActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbActive.UncheckedState.BorderThickness = 2;
            this.rbActive.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbActive.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.label8.Location = new System.Drawing.Point(65, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Active Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.label3.Location = new System.Drawing.Point(33, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Customer Name";
            // 
            // txbCustomerName
            // 
            this.txbCustomerName.BorderRadius = 9;
            this.txbCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCustomerName.DefaultText = "";
            this.txbCustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbCustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbCustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txbCustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCustomerName.Location = new System.Drawing.Point(36, 138);
            this.txbCustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbCustomerName.MaxLength = 100;
            this.txbCustomerName.Name = "txbCustomerName";
            this.txbCustomerName.PlaceholderText = "Enter customer name";
            this.txbCustomerName.SelectedText = "";
            this.txbCustomerName.Size = new System.Drawing.Size(474, 48);
            this.txbCustomerName.TabIndex = 10;
            this.txbCustomerName.Validating += new System.ComponentModel.CancelEventHandler(this.txbCustomerName_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 1;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 748);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbLogo_Of_Page);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUpdateCustomer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Customer";
            this.Load += new System.EventHandler(this.frmAddUpdateCustomer_Load);
            this.Click += new System.EventHandler(this.frmAddUpdateCustomer_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Of_Page)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.pInActive.ResumeLayout(false);
            this.pInActive.PerformLayout();
            this.pActive.ResumeLayout(false);
            this.pActive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbLogo_Of_Page;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSaveCustomer;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pInActive;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbInActive;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pActive;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbActive;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txbCustomerName;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txbPhoneNumber;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}