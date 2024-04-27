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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        //Кнопка возврата на пред. форму
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogForm form = new LogForm();
            form.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Создание подключения
                SqlConnection connect = new SqlConnection();
                connect.ConnectionString = Program_class.enterLink;

                //Добавление товара в бд с помощью процедуры добавления товара
                connect.Open();
                SqlCommand prodAdd = new SqlCommand();
                prodAdd.CommandType = CommandType.StoredProcedure;
                prodAdd.CommandText = "ProductAdd";
                prodAdd.Parameters.AddWithValue("@name", nameTxt.Text);
                prodAdd.Parameters.AddWithValue("@price", priceTxt.Text);
                prodAdd.Parameters.AddWithValue("@discountMax", maxDiscTxt.Text);
                prodAdd.Parameters.AddWithValue("@manufacturer", manufactTxt.Text);
                prodAdd.Parameters.AddWithValue("@provider", providerTxt.Text);
                prodAdd.Parameters.AddWithValue("@category", categoryCombo.Text);
                prodAdd.Parameters.AddWithValue("@discount", discountTxt.Text);
                prodAdd.Parameters.AddWithValue("@count", countTxt.Text);
                prodAdd.Parameters.AddWithValue("@discription", discriptTxt.Text);
                prodAdd.Parameters.AddWithValue("@image", imageTxt.Text);
                prodAdd.Connection = connect;
                SqlDataReader sqlReader = prodAdd.ExecuteReader();
                sqlReader.Read();

            }
            catch (Exception ex)
            {
                //Сообщение с ошибкой для пользователя, если не все поля заполнены
                MessageBox.Show($"Ошибка! {ex.Message}");
            }
        }
    }
}