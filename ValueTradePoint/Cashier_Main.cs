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
    public partial class Cashier_Main : Form
    {
        public Cashier_Main()
        {
            InitializeComponent();
        }

        private void buttonDealsView_Click(object sender, EventArgs e)
        {
            Cashier_DealsViwe cashierDealsViwe = new Cashier_DealsViwe();
            cashierDealsViwe.Show(); 

            this.Close();
        }
    }
}
