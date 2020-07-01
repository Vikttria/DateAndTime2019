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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox6.Visible = true;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox6.Visible = false;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A játék célja, hogy az összes tojást megtaláld, és összeszámold. Vigyázz, elbujkálnak :)", "Játékszabály");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 t = new Form5();
            t.Show();
        }
    }
}
