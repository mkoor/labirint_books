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
    public partial class FormCategories : Form
    {
        public FormCategories()
        {
            InitializeComponent();
            comboBoxGenre.SelectedIndex = 0;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormKoko formKoko = new FormKoko();
            formKoko.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormVpered formVpered = new FormVpered();
            formVpered.Show();
        }

        private void labelGenre_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxAnime_Click(object sender, EventArgs e)
        {
            FormAnime formAnime = new FormAnime();
            formAnime.Show();
        }

        private void pictureBoxDetectiv_Click(object sender, EventArgs e)
        {
            FormDetectiv formDetectiv = new FormDetectiv();
            formDetectiv.Show();
        }

        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGenre.SelectedIndex == 0)
            {
                labelBaby1.Visible = true;
                labelBaby2.Visible = true;
                labelBaby3.Visible = true;
                labelBaby4.Visible = true;
                pictureBoxBaby1.Visible = true;
                pictureBoxBaby2.Visible = true;

                labelDetectiv.Visible = false;
                labelDetectiv1.Visible = false;
                labelAnime.Visible = false;
                labelAnime1.Visible = false;
                pictureBoxDetectiv.Visible = false;
                pictureBoxAnime.Visible = false;
            }
            else if (comboBoxGenre.SelectedIndex == 1)
            {
                labelDetectiv.Visible = true;
                labelDetectiv1.Visible = true;
                pictureBoxDetectiv.Visible = true;

                labelBaby1.Visible = false;
                labelBaby2.Visible = false;
                labelBaby3.Visible = false;
                labelBaby4.Visible = false;
                labelAnime.Visible = false;
                labelAnime1.Visible = false;
                pictureBoxAnime.Visible = false;
                pictureBoxBaby1.Visible = false;
                pictureBoxBaby2.Visible = false;
            }
            else if (comboBoxGenre.SelectedIndex == 2)
            {
                labelAnime.Visible = true;
                labelAnime1.Visible = true;
                pictureBoxAnime.Visible = true;

                labelDetectiv.Visible = false;
                labelDetectiv1.Visible = false;
                pictureBoxDetectiv.Visible = false;
                labelBaby1.Visible = false;
                labelBaby2.Visible = false;
                labelBaby3.Visible = false;
                labelBaby4.Visible = false;            
                pictureBoxBaby1.Visible = false;
                pictureBoxBaby2.Visible = false;
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Labirint labirint = new Labirint();
            labirint.Show();
            this.Hide();
        }
    }
}
