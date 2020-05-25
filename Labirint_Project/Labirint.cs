using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint_Project
{
    public partial class Labirint : Form
    {
        public Labirint()
        {
            InitializeComponent();
        }

        private void Labirint_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAuthorization formAutho = new FormAuthorization();
            formAutho.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormCategories formCategories = new FormCategories();
            formCategories.Show();
            this.Hide();
        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
