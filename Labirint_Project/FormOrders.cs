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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
            ShowClient();
            ShowOrders();
        }   

        void ShowClient()
        {
            comboBoxOrder.Items.Clear();
            foreach (ClientsSet clientsSet in Program.lab.ClientsSet)
            {
                string[] item = { clientsSet.Id.ToString()+". ", clientsSet.LastName+" ",
                clientsSet.FirstName+" - ", clientsSet.IdBooks.ToString()+" ", clientsSet.BooksSet.Name};
                comboBoxOrder.Items.Add(string.Join(" ", item));
            }
        }

        void ShowOrders()
        {
            listViewOrders.Items.Clear();
            foreach (OrdersSet ordersSet in Program.lab.OrdersSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    ordersSet.Id.ToString(),
                    ordersSet.ClientsSet.IdBooks.ToString()+ ". "+
                    ordersSet.ClientsSet.BooksSet.Name+ " - "+
                    ordersSet.ClientsSet.BooksSet.Author,
                    ordersSet.IdClients.ToString()+". "+
                    ordersSet.ClientsSet.LastName+" "+
                    ordersSet.ClientsSet.FirstName.Remove(1)+".",
                    ordersSet.OrderStatus                    
                });
                item.Tag = ordersSet;
                listViewOrders.Items.Add(item);
            }
            listViewOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void comboBoxBook_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                OrdersSet ordersSet = new OrdersSet();

                if (comboBoxOrder.SelectedItem != null)
                    ordersSet.IdClients = Convert.ToInt32(comboBoxOrder.SelectedItem.ToString().Split('.')[0]);
                else throw new Exception("Обязательные данные не заполнены");

                if (comboBoxStatus.SelectedItem != null)
                    ordersSet.OrderStatus = comboBoxStatus.SelectedItem.ToString();
                else ordersSet.OrderStatus = null;

                Program.lab.OrdersSet.Add(ordersSet);
                Program.lab.SaveChanges();
                ShowOrders();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrders.SelectedItems.Count == 1)
                {
                    OrdersSet ordersSet = listViewOrders.SelectedItems[0].Tag as OrdersSet;

                    if (comboBoxOrder.SelectedItem != null)
                        ordersSet.IdClients = Convert.ToInt32(comboBoxOrder.SelectedItem.ToString().Split('.')[0]);
                    else throw new Exception("Обязательные данные не заполнены");

                    if (comboBoxStatus.SelectedItem != null)
                        ordersSet.OrderStatus = comboBoxStatus.SelectedItem.ToString();
                    else ordersSet.OrderStatus = null;

                    Program.lab.SaveChanges();
                    ShowOrders();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count == 1)
            {
                OrdersSet ordersSet = listViewOrders.SelectedItems[0].Tag as OrdersSet;

                comboBoxStatus.Text = ordersSet.OrderStatus;
                comboBoxOrder.Text = ordersSet.IdClients.ToString()+". "+
                ordersSet.ClientsSet.LastName+" "+ordersSet.ClientsSet.FirstName+" - "+
                ordersSet.ClientsSet.IdBooks.ToString()+". "+ordersSet.ClientsSet.BooksSet.Name;
            }
            else
            {
                comboBoxStatus.SelectedItem = null;       
                comboBoxOrder.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrders.SelectedItems.Count == 1)
                {
                    OrdersSet ordersSet = listViewOrders.SelectedItems[0].Tag as OrdersSet;

                    Program.lab.OrdersSet.Remove(ordersSet);
                    Program.lab.SaveChanges();
                    ShowOrders();
                }
                comboBoxStatus.Text = "";
                comboBoxOrder.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void comboBoxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
