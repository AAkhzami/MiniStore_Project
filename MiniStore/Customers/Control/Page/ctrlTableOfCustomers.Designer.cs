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
            this.lblCustomersCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableCustomers)).BeginInit();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvTableCustomers;
        private System.Windows.Forms.Label lblCustomersCounter;
    }
}
