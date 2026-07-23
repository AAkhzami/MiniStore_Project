using MiniStoreDB_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore.Inventory_Page
{
    public partial class frmProductInventoryLogs : Form
    {
        public frmProductInventoryLogs()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public async void LoadData()
        {
            DataTable dtAllProductStockLog = await clsCustomers.GetAllCustomers();
            if (dtAllProductStockLog.Rows.Count > 0)
            {
                DataTable dtLog = dtAllProductStockLog.DefaultView.ToTable(false, "OldStock", "NewStock", "ChangeDate");
                dgvLogs.DataSource = dtLog;

                dgvLogs.Columns[0].HeaderText = "Old Stock";
                dgvLogs.Columns[0].Width = 209;

                dgvLogs.Columns[1].HeaderText = "New Stock";
                dgvLogs.Columns[1].Width = 209;

                dgvLogs.Columns[2].HeaderText = "Change Date";
                dgvLogs.Columns[2].Width = 209;
            }
        }

        private void frmProductInventoryLogs_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
