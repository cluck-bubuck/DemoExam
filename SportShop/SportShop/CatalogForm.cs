using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportShop
{
    public partial class CatalogForm : Form
    {
        public CatalogForm()
        {
            InitializeComponent();
        }


        //Кнопка возврата на пред. форму
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogForm form = new LogForm();
            form.Show();
        }

        private void Catalog_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "terna_SportShopDataSet.ProductView". При необходимости она может быть перемещена или удалена.
            this.productViewTableAdapter.Fill(this.terna_SportShopDataSet.ProductView);

            filterCombo.SelectedIndex = 0;

            //Изменение цвета клеток с большой скидкой
            foreach (DataGridViewRow row in prodData.Rows)
                if (Convert.ToInt32(row.Cells[3].Value) > 15) //проверка скидки каждого продукта
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(byte)(127)), ((int)(byte)(255)), ((int)(byte)(0)));
                }
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            //Поиск товара по названию
            BindingSource bs = new BindingSource();
            bs.DataSource = prodData.DataSource;
            bs.Filter = "Название" + " like '%" + searchTxt.Text + "%'";
            prodData.DataSource = bs;
        }

        private void prodData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Вывод фотографии при нажатии на товар в DataGrid
                if (e.RowIndex != null & e.RowIndex != -1)
                {
                    DataGridViewRow productDate = prodData.Rows[e.RowIndex];
                    discriptionLabel1.Text = productDate.Cells[7].Value.ToString();
                    manufactLabel1.Text = productDate.Cells[6].Value.ToString();
                    priceLabel1.Text = productDate.Cells[4].Value.ToString();
                    if (productDate.Cells[8].Value.ToString() != "")
                    {
                        //Вывод фото товара при нажатии на него в DataGrid
                        //Здесь, может быть, нужно поменять путь к фотографиям
                        String imageName = productDate.Cells[8].Value.ToString();
                        prodPic.Image = Image.FromFile(imageName);
                    }

                    else
                    {
                        //Если фото товара нет, будет вставлена картинка-затычка вместо нее
                        String imageName = "icon.png";
                        prodPic.Image = Image.FromFile(imageName);
                    }
                    discountLabel.Text = productDate.Cells[3].Value.ToString() + "%";
                }
            }
            catch (Exception ex)
            {
                //Сообщение с ошибкой для пользователя
                MessageBox.Show($"Ошибка! {ex.Message}");
            }
        }
    }
}
