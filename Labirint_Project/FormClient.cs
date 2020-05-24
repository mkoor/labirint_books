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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            ShowClients();
            ShowBook();
        }

        void ShowBook()
        {
            comboBoxBook.Items.Clear();
            foreach (BooksSet booksSet in Program.lab.BooksSet)
            {
                string[] item = { booksSet.Id.ToString() + ". ", booksSet.Name };
                comboBoxBook.Items.Add(string.Join(" ", item));
            }
        }

        void ShowClients()
        {
            listViewClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.lab.ClientsSet)
            {
                ListViewItem item = new ListViewItem (new string[]
                {
                    clientsSet.Id.ToString(), clientsSet.LastName+" "+clientsSet.FirstName,
                    clientsSet.Phone, clientsSet.Email, clientsSet.Address, clientsSet.BooksSet.Name
                    +" - "+clientsSet.BooksSet.Author
                });
                item.Tag = clientsSet;
                listViewClients.Items.Add(item);
            }
            listViewClients.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
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

                Program.lab.ClientsSet.Add(clientsSet);
                Program.lab.SaveChanges();
                ShowClients();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void listViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count == 1)
            {
                ClientsSet clientsSet = listViewClients.SelectedItems[0].Tag as ClientsSet;
                
                textBoxFirstName.Text = clientsSet.FirstName;
                textBoxLastName.Text = clientsSet.LastName;
                textBoxPhone.Text = clientsSet.Phone;
                textBoxEmail.Text = clientsSet.Email;
                textBoxAddress.Text = clientsSet.Address;
                comboBoxBook.Text = clientsSet.IdBooks.ToString();
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxAddress.Text = "";
                comboBoxBook.SelectedItem = null;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClients.SelectedItems.Count == 1)
                {
                    ClientsSet clientsSet = listViewClients.SelectedItems[0].Tag as ClientsSet;
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

                    Program.lab.SaveChanges();
                    ShowClients();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClients.SelectedItems.Count == 1)
                {
                    ClientsSet clientsSet = listViewClients.SelectedItems[0].Tag as ClientsSet;

                    Program.lab.ClientsSet.Remove(clientsSet);
                    Program.lab.SaveChanges();
                    ShowClients();
                }
                textBoxLastName.Text = "";
                textBoxFirstName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxAddress.Text = "";
                comboBoxBook.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void comboBoxBook_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
