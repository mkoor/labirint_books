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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            labelHello.Text = "Здравствуйте, " + FormAuthorization.users.login;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            FormBook formBook = new FormBook();
            formBook.Show();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            FormClient formClient = new FormClient();
            formClient.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Labirint labirint = new Labirint();
            labirint.Show();
            this.Hide();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            FormOrders formOrders = new FormOrders();
            formOrders.Show();
        }
    }
}
