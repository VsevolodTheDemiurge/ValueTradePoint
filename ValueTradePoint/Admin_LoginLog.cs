using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ValueTradePoint
{
    public partial class Admin_LoginLog : Form
    {
        string connectionString = "Data Source=quantorium;Initial Catalog=polyakov_429195-24;Integrated Security=True;";

        public Admin_LoginLog()
        {
            InitializeComponent();
        }

        private void Admin_LoginLog_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Время, Логин, Роль, IsSuccessful FROM LoginLog";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewLoginLog.DataSource = dataTable;
            }
        }

        private void textBoxUsernameFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonApplyFilter_Click(object sender, EventArgs e)
        {
            string usernameFilter = textBoxUsernameFilter.Text;
            FilterData(usernameFilter);
        }

        private void FilterData(string username)
        {
            DataTable dataTable = dataGridViewLoginLog.DataSource as DataTable;
            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Format("Логин LIKE '%{0}%'", username);
            }
        }

        private void buttonApplySort_Click(object sender, EventArgs e)
        {
            string selectedColumnName = comboBoxSortBy.SelectedItem.ToString();
            SortData(selectedColumnName);
        }

        private void SortData(string sortDirection)
        {
            DataTable dataTable = dataGridViewLoginLog.DataSource as DataTable;
            if (dataTable != null)
            {
                if (sortDirection == "По возрастанию")
                {
                    dataTable.DefaultView.Sort = "Время ASC";
                }
                else if (sortDirection == "По убыванию")
                {
                    dataTable.DefaultView.Sort = "Время DESC";
                }
            }
        }

        private void comboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonMainPageReturn_Click(object sender, EventArgs e)
        {
            Admin_Main mainForm = new Admin_Main();
            mainForm.Show();

            this.Close();
        }
    }
}
