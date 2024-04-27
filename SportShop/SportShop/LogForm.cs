using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportShop
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        int troubles = 0;
        int s = 10;
        private void Authorization_Load(object sender, EventArgs e)
        {
            capchaPic.Visible = false;
            capchaTxt.Visible=false;
            capchaBtn.Visible=false;
        }

        private void guestBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CatalogForm form = new CatalogForm();
            form.Show();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            //Создание подключения
            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = Program_class.enterLink;

            //Приветствие взависимости от времени на компьютере
            string hello;
            DateTime dateTime = DateTime.Now;
            if (dateTime.Hour >= 0 && dateTime.Hour <= 6)
            {
                hello = "Доброй ночи";
            }
            else if (dateTime.Hour >= 7 && dateTime.Hour <= 12)
            {
                hello = "Доброе утро";
            }
            else if (dateTime.Hour >= 13 && dateTime.Hour <= 18)
            {
                hello = "Добрый день ";
            }
            else if (dateTime.Hour > 18 && dateTime.Hour <= 23)
            {
                hello = "Добрый вечер";
            }
            else
            {
                hello = "Добро пожаловать";
            }

            //Вход в приложение через хранимую процедуру с логином и паролем
            try
            {
                connect.Open();
                SqlCommand enter = new SqlCommand();
                enter.CommandType = CommandType.StoredProcedure;
                enter.CommandText = "Enter";
                enter.Parameters.AddWithValue("@log", logTxt.Text);
                enter.Parameters.AddWithValue("@pass", passTxt.Text);
                enter.Connection = connect;
                SqlDataReader sqlReader = enter.ExecuteReader();
                sqlReader.Read();
                int roleNumb = sqlReader.GetInt32(6);

                //Приветствие по Имени Фамилии
                if (sqlReader.HasRows)
                {
                    //Сохранение идентификатора пользователя для использования в дальнейшем
                    Program_class.user_id = (int)sqlReader.GetInt32(0);
                    connect.Close();
                    connect.Open();
                    //После открытия соединения используя Select выбираем имя и фамилию из таблички в БД
                    using (SqlCommand sqlCom = new SqlCommand(@"Select user_name, user_surname From [Users] where user_login like @log", connect))
                    {
                        SqlParameter logPar = new SqlParameter("@log", logTxt.Text);
                        sqlCom.Parameters.Add(logPar);
                        sqlReader = sqlCom.ExecuteReader();
                        sqlReader.Read();
                        string welcome = $"{hello}, {sqlReader.GetString(0)} {sqlReader.GetString(1)}";
                        MessageBox.Show(welcome);

                        //В зависимости от роли пользователя будет открываться разная форма
                        switch (roleNumb)
                        {
                            case 1:
                                CatalogForm userForm = new CatalogForm();
                                userForm.Show();
                                break;
                            case 2:
                                CatalogForm catalogForm = new CatalogForm();
                                catalogForm.Show();
                                break;
                            case 3:
                                AdminForm adminForm = new AdminForm();
                                adminForm.Show();
                                break;
                        }
                        this.Hide();
                    }
                }

                //Если пользователь совершает 3 ошибки ввода, запускается таймер блокирующий ввод
                else
                {
                    troubles++;

                    if (troubles >= 3)
                    {
                        blockTimer.Start();
                    }
                }
            }

            //Сообщение об ошибках
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка! {ex.Message}");
            }
        }

        private void blockTimer_Tick(object sender, EventArgs e)
        {
            //Блокируем элементы ввода
            logTxt.ReadOnly = false;
            passTxt.ReadOnly = false;
            enterBtn.Enabled = false;
            waitLabel.Visible = false;

            //Запускаем таймер, по окончанию которого элементы ввода снова активны
            waitLabel.Text = $"Подождите ({s})";
            s--;
            if (s == 0)
            {
                blockTimer.Stop();
                logTxt.ReadOnly = false;
                passTxt.ReadOnly = false;
                enterBtn.Enabled = false;
                waitLabel.Visible = false;
                s = 10;
            }
        }
    }
}
