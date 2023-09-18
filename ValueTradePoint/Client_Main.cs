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
    public partial class Client_Main : Form
    {
        public Client_Main()
        {
            InitializeComponent();
        }


        private void Client_Main_Load(object sender, EventArgs e)
        {

        }

        private void buttonDealsView_Click(object sender, EventArgs e)
        {
            Client_DealsViwe clientFormDeals = new Client_DealsViwe();
            clientFormDeals.Show();

            this.Close();
        }

    }
}
