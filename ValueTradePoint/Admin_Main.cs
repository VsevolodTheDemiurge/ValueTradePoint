using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValueTradePoint
{
    public partial class Admin_Main : Form
    {
        public Admin_Main()
        {
            InitializeComponent();
        }

        private void Admin_Main_Load(object sender, EventArgs e)
        {

        }

        private void buttonLoginLog_Click(object sender, EventArgs e)
        {
            Admin_LoginLog loginLogForm = new Admin_LoginLog();
            loginLogForm.Show();
            this.Close();
        }

        private void buttonDealsView_Click(object sender, EventArgs e)
        {
            Admin_DealsViwe formDealsView = new Admin_DealsViwe();
            formDealsView.Show();

            this.Close();
        }
    }
}
