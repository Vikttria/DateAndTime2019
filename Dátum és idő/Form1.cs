using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dátum_és_idő
{
    public partial class Form1 : Form
    {
        private DateTime ma = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();//idő elindítása
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = ma.ToString("F"); //mai dátum és idő
            int Month = ma.Month;

            if (3 <= Month  && Month <= 5)
            {
                BackgroundImage = global::Dátum_és_idő.Properties.Resources.tavasz;
            }
            else if (6 <= Month && Month <= 8)
            {
                BackgroundImage = global::Dátum_és_idő.Properties.Resources.nyar;
            }
            else if (9 <= Month && Month <= 11)
            {
                BackgroundImage = global::Dátum_és_idő.Properties.Resources.osz;
            }
            else if (12 <= Month && Month <= 2)
            {
                BackgroundImage = global::Dátum_és_idő.Properties.Resources.tel;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) //időt frissíti másodpercenként
        {
            label1.Text = DateTime.Now.ToString("F");
        }

        private void button5_Click(object sender, EventArgs e)//kilép az alkalmazásból
        {
            Application.Exit();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)//újév, ráhúzom az egeret
        {
            pictureBox1.Visible = true;
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)//újév, lehúzom az egeret
        {
            pictureBox1.Visible = false;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)//húsvét, ráhúz
        {
            pictureBox2.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)//húsvét, lehúz
        {
            pictureBox2.Visible = false;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)//karácsony, ráhúz
        {
            pictureBox4.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)//karácsony, lehúz
        {
            pictureBox4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)//karácsony
        {
            Form2 k = new Form2();
            k.Show();
        }

        private void button2_Click(object sender, EventArgs e)//húsvét
        {
            Form3 h = new Form3();
            Hide();
            h.ShowDialog();
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 u = new Form4();
            Hide();
            u.ShowDialog();
            Show();
        }
    }
}
