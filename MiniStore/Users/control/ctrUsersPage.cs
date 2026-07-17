using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore.Users.control
{
    public partial class ctrUsersPage : UserControl
    {
        public ctrUsersPage()
        {
            InitializeComponent();
        }

        private void ctrUsersPage_Load(object sender, EventArgs e)
        {
            ctrlSearchOnUser1.OnSearch += ctrlListUsers1.SearchOnUser;
        }
    }
}
