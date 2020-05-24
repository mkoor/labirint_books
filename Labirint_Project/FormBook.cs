using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Labirint_Project
{
    public partial class FormBook : Form
    {
        public FormBook()
        {
            InitializeComponent();
            ShowBooks();
        }

        void ShowBooks()
        {
            listViewBooks.Items.Clear();
            foreach (BooksSet booksSet in Program.lab.BooksSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    booksSet.Id.ToString(), booksSet.Name, booksSet.Author,
                    booksSet.StockBalance, booksSet.Price.ToString()
                });
                item.Tag = booksSet;
                listViewBooks.Items.Add(item);
            }
            listViewBooks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void FormBook_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                BooksSet booksSet = new BooksSet();
               
                if (textBoxStockBalance.Text != "")
                {
                    booksSet.StockBalance = textBoxStockBalance.Text;
                }
                else booksSet.StockBalance = null;
                if (textBoxPrice.Text == "" || textBoxAuthor.Text == "" || textBoxName.Text == "")
                {
                    throw new Exception("Обязательные данные не заполнены");
                }
                else
                {
                    booksSet.Price = Convert.ToInt32(textBoxPrice.Text);
                    booksSet.Name = textBoxName.Text;
                    booksSet.Author = textBoxAuthor.Text;
                }

                Program.lab.BooksSet.Add(booksSet);
                Program.lab.SaveChanges();
                ShowBooks();
            } catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewBooks.SelectedItems.Count == 1)
                {
                    BooksSet booksSet = listViewBooks.SelectedItems[0].Tag as BooksSet;

                    booksSet.Name = textBoxName.Text;
                    booksSet.StockBalance = textBoxStockBalance.Text;;
                    if (textBoxPrice.Text == "" || textBoxAuthor.Text == "" || textBoxName.Text == "")
                    throw new Exception("Обязательные данные не заполнены!");
                    else
                    {
                        booksSet.Name = textBoxName.Text;
                        booksSet.Author = textBoxAuthor.Text;
                        booksSet.Price = Convert.ToInt32(textBoxPrice.Text);
                    }

                    Program.lab.SaveChanges();
                    ShowBooks();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void listViewBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBooks.SelectedItems.Count == 1)
            {
                BooksSet booksSet =  listViewBooks.SelectedItems[0].Tag as BooksSet;

                textBoxName.Text = booksSet.Name;
                textBoxAuthor.Text = booksSet.Author;
                textBoxStockBalance.Text = booksSet.StockBalance;
                textBoxPrice.Text = booksSet.Price.ToString();
            }
            else
            {
                textBoxName.Text = "";
                textBoxAuthor.Text = "";
                textBoxStockBalance.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewBooks.SelectedItems.Count == 1)
                {
                    BooksSet booksSet = listViewBooks.SelectedItems[0].Tag as BooksSet;

                    Program.lab.BooksSet.Remove(booksSet);
                    Program.lab.SaveChanges();
                    ShowBooks();
                }
                textBoxName.Text = "";
                textBoxAuthor.Text = "";
                textBoxStockBalance.Text = "";
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void textBoxPrice_TextChanged(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace, запятая 
            {
                e.Handled = true;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
