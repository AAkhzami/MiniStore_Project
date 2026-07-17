namespace MiniStore.Users.control
{
    partial class ctrUsersPage
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
            this.ctrlSearchOnUser1 = new MiniStore.Users.control.ctrlSearchOnUser();
            this.ctrlListUsers1 = new MiniStore.Users.control.ctrlListUsers();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(115)))), ((int)(((byte)(138)))));
            this.label4.Location = new System.Drawing.Point(39, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Manage system users and their access";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(30, 30, 30, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 45);
            this.label5.TabIndex = 24;
            this.label5.Text = "Users";
            // 
            // ctrlSearchOnUser1
            // 
            this.ctrlSearchOnUser1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlSearchOnUser1.Location = new System.Drawing.Point(32, 135);
            this.ctrlSearchOnUser1.Name = "ctrlSearchOnUser1";
            this.ctrlSearchOnUser1.Size = new System.Drawing.Size(1259, 100);
            this.ctrlSearchOnUser1.TabIndex = 27;
            // 
            // ctrlListUsers1
            // 
            this.ctrlListUsers1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlListUsers1.Location = new System.Drawing.Point(32, 252);
            this.ctrlListUsers1.Name = "ctrlListUsers1";
            this.ctrlListUsers1.Size = new System.Drawing.Size(1259, 532);
            this.ctrlListUsers1.TabIndex = 26;
            // 
            // ctrUsersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ctrlSearchOnUser1);
            this.Controls.Add(this.ctrlListUsers1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "ctrUsersPage";
            this.Size = new System.Drawing.Size(1323, 812);
            this.Load += new System.EventHandler(this.ctrUsersPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ctrlListUsers ctrlListUsers1;
        private ctrlSearchOnUser ctrlSearchOnUser1;
    }
}
