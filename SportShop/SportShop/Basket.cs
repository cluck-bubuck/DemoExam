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
    public partial class Basket : Form
    {
        public Basket()
        {
            InitializeComponent();
        }

        //Кнопка возврата на пред. форму
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            CatalogForm form = new CatalogForm();
            form.Show();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
