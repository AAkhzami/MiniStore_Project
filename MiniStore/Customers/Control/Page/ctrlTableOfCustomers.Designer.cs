namespace MiniStore.Customers.Control.Page
{
    partial class ctrlTableOfCustomers
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
            this.dgvTableCustomers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsCustomer = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.customerInfoStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editCustToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCustomersCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableCustomers)).BeginInit();
            this.cmsCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTableCustomers
            // 
            this.dgvTableCustomers.AllowUserToAddRows = false;
            this.dgvTableCustomers.AllowUserToDeleteRows = false;
            this.dgvTableCustomers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTableCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(90)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTableCustomers.ColumnHeadersHeight = 45;
            this.dgvTableCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTableCustomers.ContextMenuStrip = this.cmsCustomer;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableCustomers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTableCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTableCustomers.Location = new System.Drawing.Point(3, 3);
            this.dgvTableCustomers.Name = "dgvTableCustomers";
            this.dgvTableCustomers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTableCustomers.RowHeadersVisible = false;
            this.dgvTableCustomers.RowTemplate.Height = 60;
            this.dgvTableCustomers.Size = new System.Drawing.Size(1249, 490);
            this.dgvTableCustomers.TabIndex = 5;
            this.dgvTableCustomers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTableCustomers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(90)))), ((int)(((byte)(243)))));
            this.dgvTableCustomers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 11F);
            this.dgvTableCustomers.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvTableCustomers.ThemeStyle.ReadOnly = true;
            this.dgvTableCustomers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTableCustomers.ThemeStyle.RowsStyle.Height = 60;
            // 
            // cmsCustomer
            // 
            this.cmsCustomer.BackColor = System.Drawing.Color.White;
            this.cmsCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerInfoStripMenuItem1,
            this.editCustToolStripMenuItem,
            this.deleteCustomerToolStripMenuItem});
            this.cmsCustomer.Name = "cmsCustomer";
            this.cmsCustomer.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsCustomer.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsCustomer.RenderStyle.ColorTable = null;
            this.cmsCustomer.RenderStyle.RoundedEdges = true;
            this.cmsCustomer.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsCustomer.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsCustomer.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsCustomer.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsCustomer.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsCustomer.Size = new System.Drawing.Size(229, 94);
            // 
            // customerInfoStripMenuItem1
            // 
            this.customerInfoStripMenuItem1.Image = global::MiniStore.Properties.Resources.user_31;
            this.customerInfoStripMenuItem1.Name = "customerInfoStripMenuItem1";
            this.customerInfoStripMenuItem1.Size = new System.Drawing.Size(228, 30);
            this.customerInfoStripMenuItem1.Text = "Customer Info";
            this.customerInfoStripMenuItem1.Click += new System.EventHandler(this.customerInfoStripMenuItem1_Click);
            // 
            // editCustToolStripMenuItem
            // 
            this.editCustToolStripMenuItem.Image = global::MiniStore.Properties.Resources.edit;
            this.editCustToolStripMenuItem.Name = "editCustToolStripMenuItem";
            this.editCustToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.editCustToolStripMenuItem.Text = "Edit Customer";
            this.editCustToolStripMenuItem.Click += new System.EventHandler(this.editCustToolStripMenuItem_Click);
            // 
            // deleteCustomerToolStripMenuItem
            // 
            this.deleteCustomerToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.deleteCustomerToolStripMenuItem.Image = global::MiniStore.Properties.Resources.trash;
            this.deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            this.deleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.deleteCustomerToolStripMenuItem.Text = "Delete Customer";
            this.deleteCustomerToolStripMenuItem.Click += new System.EventHandler(this.deleteCustomerToolStripMenuItem_Click);
            // 
            // lblCustomersCounter
            // 
            this.lblCustomersCounter.AutoSize = true;
            this.lblCustomersCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomersCounter.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblCustomersCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(115)))), ((int)(((byte)(138)))));
            this.lblCustomersCounter.Location = new System.Drawing.Point(3, 510);
            this.lblCustomersCounter.Name = "lblCustomersCounter";
            this.lblCustomersCounter.Size = new System.Drawing.Size(181, 22);
            this.lblCustomersCounter.TabIndex = 20;
            this.lblCustomersCounter.Text = "Showing N customers";
            // 
            // ctrlTableOfCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblCustomersCounter);
            this.Controls.Add(this.dgvTableCustomers);
            this.Name = "ctrlTableOfCustomers";
            this.Size = new System.Drawing.Size(1255, 548);
            this.Load += new System.EventHandler(this.ctrlTableOfCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableCustomers)).EndInit();
            this.cmsCustomer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvTableCustomers;
        private System.Windows.Forms.Label lblCustomersCounter;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsCustomer;
        private System.Windows.Forms.ToolStripMenuItem editCustToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerInfoStripMenuItem1;
    }
}
