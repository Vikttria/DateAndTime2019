using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dátum_és_idő
{
    public partial class Form4 : Form
    {
        //SoundPlayer sound = new SoundPlayer(@"C:\Users\viktt\Documents\tanulás\programozás\C#\2018,12,téli szüneti feladat\zene\tuzijatek.wav");
        SoundPlayer sound = new SoundPlayer(@"tuzijatek.wav");

        public Form4()
        {
            InitializeComponent();
            timer1.Start();
            sound.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = !pictureBox1.Visible;
            pictureBox2.Visible = !pictureBox2.Visible;
            pictureBox3.Visible = !pictureBox3.Visible;
            pictureBox4.Visible = !pictureBox4.Visible;
            pictureBox5.Visible = !pictureBox5.Visible;
        }

        private void Form4_Click(object sender, EventArgs e)
        {
            sound.Stop();
            Close();
        }
    }
}
