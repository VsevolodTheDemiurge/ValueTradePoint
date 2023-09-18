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
    public partial class Client_DealsViwe : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;


        public Client_DealsViwe()
        {
            InitializeComponent();
            string connectionString = "Data Source=quantorium;Initial Catalog=polyakov_429195-24;Integrated Security=True;";
            connection = new SqlConnection(connectionString);
        }

        private void DealsViwe_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_polyakov_429195_24DataSet.Сделки". При необходимости она может быть перемещена или удалена.
            this.сделкиTableAdapter.Fill(this._polyakov_429195_24DataSet.Сделки);
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Сделки";
            dataAdapter.SelectCommand = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void returnButton_Click(object sender, EventArgs e)
        {
            Client_Main mainClient = new Client_Main();
            mainClient.Show();

            this.Close();
        }
    }
}
