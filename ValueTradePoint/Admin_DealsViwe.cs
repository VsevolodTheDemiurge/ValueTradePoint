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
    public partial class Admin_DealsViwe : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;


        public Admin_DealsViwe()
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

        private void InsertButton_Click(object sender, EventArgs e)
        {
            string currency = CurrencyTextBox.Text;
            int cashierNumber = Convert.ToInt32(CashierNumberTextBox.Text);
            int clientNumber = Convert.ToInt32(ClientNumberTextBox.Text);
            string status = StatusTextBox.Text;
            DateTime date = DateDateTimePicker.Value;
            string time = TimeTextBox.Text;
            decimal saleAmount = Convert.ToDecimal(SaleAmountTextBox.Text);
            decimal purchaseAmount = Convert.ToDecimal(PurchaseAmountTextBox.Text);

            string query = "INSERT INTO Сделки (Название_Валюты, Номер_Кассира, Номер_Клиента, Статус_Сделки, Дата_Сделки, Время_Сделки, Сумма_Проданной_Валюты, Сумма_Купленной_Валюты) " +
                           "VALUES (@Currency, @CashierNumber, @ClientNumber, @Status, @Date, @Time, @SaleAmount, @PurchaseAmount)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Currency", currency);
            command.Parameters.AddWithValue("@CashierNumber", cashierNumber);
            command.Parameters.AddWithValue("@ClientNumber", clientNumber);
            command.Parameters.AddWithValue("@Status", status);
            command.Parameters.AddWithValue("@Date", date);
            command.Parameters.AddWithValue("@Time", time);
            command.Parameters.AddWithValue("@SaleAmount", saleAmount);
            command.Parameters.AddWithValue("@PurchaseAmount", purchaseAmount);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно добавлена.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении записи: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            int transactionId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["TransactionID"].Value);

            string currency = CurrencyTextBox.Text;
            int cashierNumber = Convert.ToInt32(CashierNumberTextBox.Text);
            int clientNumber = Convert.ToInt32(ClientNumberTextBox.Text);
            string status = StatusTextBox.Text;
            DateTime date = DateDateTimePicker.Value;
            string time = TimeTextBox.Text;
            decimal saleAmount = Convert.ToDecimal(SaleAmountTextBox.Text);
            decimal purchaseAmount = Convert.ToDecimal(PurchaseAmountTextBox.Text);

            string query = "UPDATE Сделки SET Название_Валюты = @Currency, Номер_Кассира = @CashierNumber, " +
                           "Номер_Клиента = @ClientNumber, Статус_Сделки = @Status, Дата_Сделки = @Date, " +
                           "Время_Сделки = @Time, Сумма_Проданной_Валюты = @SaleAmount, Сумма_Купленной_Валюты = @PurchaseAmount " +
                           "WHERE TransactionID = @TransactionID";

             SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Currency", currency);
            command.Parameters.AddWithValue("@CashierNumber", cashierNumber);
            command.Parameters.AddWithValue("@ClientNumber", clientNumber);
            command.Parameters.AddWithValue("@Status", status);
            command.Parameters.AddWithValue("@Date", date);
            command.Parameters.AddWithValue("@Time", time);
            command.Parameters.AddWithValue("@SaleAmount", saleAmount);
            command.Parameters.AddWithValue("@PurchaseAmount", purchaseAmount);
            command.Parameters.AddWithValue("@TransactionID", transactionId);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно обновлена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении записи: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void UpdateDataGridView()
        {
            string query = "SELECT * FROM Сделки";
            dataAdapter.SelectCommand = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                dataTable.Clear(); // Очистите DataTable
                dataAdapter.Fill(dataTable); // Заново заполните DataTable
                dataGridView1.DataSource = dataTable; // Обновите DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении данных: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Admin_Main mainForm = new Admin_Main();
            mainForm.Show();

            this.Close();
        }
    }
}
