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
    public partial class FormOrderBy : Form
    {
        public FormOrderBy()
        {
            InitializeComponent();
            ShowBook();
        }

        void ShowBook()
        {
            comboBoxBook.Items.Clear();
            foreach (BooksSet booksSet in Program.lab.BooksSet)
            {
                string[] item = { booksSet.Id.ToString() + ". ", booksSet.Name+ " - ", booksSet.Author};
                comboBoxBook.Items.Add(string.Join(" ", item));
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonGO_Click(object sender, EventArgs e)
        {
            try
            {
                ClientsSet clientsSet = new ClientsSet();
                if (comboBoxBook.SelectedItem != null)
                    clientsSet.IdBooks = Convert.ToInt32(comboBoxBook.SelectedItem.ToString().Split('.')[0]);
                else throw new Exception("Обязательные данные не заполнены");

                if (textBoxEmail.Text != "")
                {
                    clientsSet.Email = textBoxEmail.Text;
                }
                else clientsSet.Email = null;

                if (textBoxLastName.Text == "" || textBoxFirstName.Text == "" || textBoxPhone.Text == "" || textBoxAddress.Text == "")
                {
                    throw new Exception("Обязательные данные не заполнены");
                }
                else
                {
                    clientsSet.LastName = textBoxLastName.Text;
                    clientsSet.FirstName = textBoxFirstName.Text;
                    clientsSet.Phone = textBoxPhone.Text;
                    clientsSet.Address = textBoxAddress.Text;
                }
                MessageBox.Show("Ваш заказ успешно офоромлен! Ожидайте SMS сообщение по вашему номеру телефона с" +
                    " информацией об оплате и доставке вашей книги.","Заказ оформлен",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                Program.lab.ClientsSet.Add(clientsSet);
                Program.lab.SaveChanges();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }          
        }

        private void comboBoxBook_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
