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
    public partial class AuthorizationForm : Form
    {
        string connectionString = "Data Source=quantorium;Initial Catalog=polyakov_429195-24;Integrated Security=True;";

        private string text = String.Empty;
        private int failedAttempts = 0;


        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            CaptchaTextBox.Visible = false;
            CaptchaPictureBox.Visible = false;

            CaptchaPictureBox.Image = this.CreateImage(CaptchaPictureBox.Width, CaptchaPictureBox.Height);
        }

        private void PasswordShowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(PasswordShowCheckBox.Checked == true)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else if (PasswordShowCheckBox.Checked == false)
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void EnableCaptcha()
        {
            button1.Visible = true;
            CaptchaPictureBox.Visible = true;
            CaptchaTextBox.Visible = true;
            button2.Visible = true;

            CaptchaPictureBox.Image = CreateImage(CaptchaPictureBox.Width, CaptchaPictureBox.Height);
        }


        private void Enter_Button_Click(object sender, EventArgs e)
        {
            string enteredLogin = LoginTextBox.Text;
            string enteredPassword = PasswordTextBox.Text;
            string userRole = AuthenticateUserAndGetRole(enteredLogin, enteredPassword);

            if (!string.IsNullOrEmpty(userRole))
            {
                if (userRole == "Администратор")
                {
                    LogLoginAttempt(enteredLogin, userRole, true);

                    Admin_Main mainAdminForm = new Admin_Main();
                    mainAdminForm.Show();

                    this.Hide();
                }
                else if (userRole == "Кассир")
                {
                    LogLoginAttempt(enteredLogin, userRole, true);

                    Cashier_Main mainCashierForm = new Cashier_Main();
                    mainCashierForm.Show();
                    this.Hide();
                }
                else if (userRole == "Клиент")
                {
                    LogLoginAttempt(enteredLogin, userRole, true);

                    Client_Main mainClientForm = new Client_Main();
                    mainClientForm.Show();
                    this.Hide();
                }
            }
            else
            {
                LogLoginAttempt(enteredLogin, "Нет роли", false);

                failedAttempts++;
                if (failedAttempts == 1)
                {
                    MessageBox.Show("Неверные учетные данные. Пожалуйста, попробуйте еще раз.");
                }
                else if (failedAttempts == 2)
                {
                    MessageBox.Show("Лимит ошибок превышен! Решите captcha, чтобы выполнить вход");
                    EnableCaptcha();
                }
                else if (failedAttempts >= 3)
                {
                    MessageBox.Show("Лимит ошибок привышен! Доступ к авторизации заблокирован на 3 минуты.");
                    BlockAuthentication();
                }
            }
        }


        private string AuthenticateUserAndGetRole(string enteredLogin, string enteredPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Роль FROM Пользователи WHERE Логин = @логин AND Пароль = @пароль";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@логин", enteredLogin);
                command.Parameters.AddWithValue("@пароль", enteredPassword);

                string role = command.ExecuteScalar() as string;

                return role;
            }
        }

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            // Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            // Вычислим позицию текста
            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);

            // Добавим различные цвета
            Brush[] colors = { Brushes.Black,
                               Brushes.Red,
                               Brushes.RoyalBlue,
                               Brushes.Green };

            // Укажем, где рисовать
            Graphics g = Graphics.FromImage((Image)result);

            // Пусть фон картинки будет серым
            g.Clear(Color.Gray);

            // Сгенерируем текст
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            // Нарисуем сгенерированный текст
            g.DrawString(text,
                         new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            // Добавим немного помех
            // Линии из углов
            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            // Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaptchaPictureBox.Image = this.CreateImage(CaptchaPictureBox.Width, CaptchaPictureBox.Height);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CaptchaTextBox.Text == this.text)
            {
                MessageBox.Show("Верно!");
                failedAttempts = 0;
            }
            else
            {
                MessageBox.Show("Ошибка! Попробуйте еще раз.");
                failedAttempts++;
                if (failedAttempts >= 2)
                {
                    BlockAuthentication();
                }

            }
        }

        private void BlockAuthentication()
        {
            button2.Enabled = false;

            Timer timer = new Timer();
            timer.Interval = 180000; // 3 минуты
            timer.Tick += (sender, e) =>
            {
                button2.Enabled = true;
                timer.Stop();
            };

            timer.Start();
        }

        private void LogLoginAttempt(string username, string role, bool isSuccessful)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO LoginLog (Время, Логин, Роль, IsSuccessful) VALUES (@Timestamp, @Username, @Role, @IsSuccessful)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Timestamp", DateTime.Now);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Role", role);
                command.Parameters.AddWithValue("@IsSuccessful", isSuccessful);

                command.ExecuteNonQuery();
            }
        }

        private void CaptchaPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
