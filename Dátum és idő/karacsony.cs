using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dátum_és_idő
{
    public partial class Form2 : Form
    {
        GraphicsPath gp = new GraphicsPath();
        const int LEPES = 3;
        //SoundPlayer sound = new SoundPlayer(@"C:\Users\viktt\Documents\tanulás\programozás\C#\2018,12,téli szüneti feladat\zene\carol.wav");
        SoundPlayer sound = new SoundPlayer(@"carol.wav");//az adott könyvtárba található fajl (hordozható legyen a teljes program)

        public Form2()
        {
            InitializeComponent();
            gp.AddPolygon(new Point[]
            {
                new Point(280, 600),
                new Point(280, 530),
                new Point(0, 530),
                new Point(170, 410),
                new Point(75, 410),
                new Point(220, 280),
                new Point(130, 280),
                new Point(230, 170),
                new Point(190, 170),
                new Point(260, 85),
                new Point(215, 85),
                new Point(300, 0),
                new Point(385, 85),
                new Point(340, 85),
                new Point(410, 170),
                new Point(370, 170),
                new Point(470, 280),
                new Point(380, 280),
                new Point(525, 410),
                new Point(430, 410),
                new Point(600, 530),
                new Point(320, 530),
                new Point(320, 600)
            });
            Region = new Region(gp);
            timer1.Start();
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            Close();
            sound.Stop();
            
        }

        private void button1_Click(object sender, EventArgs e)//zene indítás
        {
            sound.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)//hópelyhek hullnak
        {
            pictureBox1.Top += LEPES;
            if (label1.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                label1.Height += LEPES;
                if (label1.Height < Height - pictureBox1.Height - LEPES)
                {
                    pictureBox1.Top = 0;
                }
                else
                {
                    timer1.Stop();
                }
            }
            pictureBox2.Top += LEPES;
            if (label1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                label1.Height += LEPES;
                if (label1.Height < Height - pictureBox2.Height - LEPES)
                {
                    pictureBox2.Top = 0;
                }
                else
                {
                    timer1.Stop();
                }
            }
            pictureBox3.Top += LEPES;
            if (label1.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                label1.Height += LEPES;
                if (label1.Height < Height - pictureBox3.Height - LEPES)
                {
                    pictureBox3.Top = 0;
                }
                else
                {
                    timer1.Stop();
                }
            }
            pictureBox4.Top += LEPES;
            if (label1.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                label1.Height += LEPES;
                if (label1.Height < Height - pictureBox4.Height - LEPES)
                {
                    pictureBox4.Top = 0;
                }
                else
                {
                    timer1.Stop();
                }
            }
            pictureBox5.Top += LEPES;
            if (label1.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                label1.Height += LEPES;
                if (label1.Height < Height - pictureBox5.Height - LEPES)
                {
                    pictureBox5.Top = 0;
                }
                else
                {
                    timer1.Stop();
                }
            }
            pictureBox6.Top += LEPES;
            if (label1.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                label1.Height += LEPES;
                if (label1.Height < Height - pictureBox6.Height - LEPES)
                {
                    pictureBox6.Top = 0;
                }
                else
                {
                    timer1.Stop();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sound.Stop();
        }
    }
}
