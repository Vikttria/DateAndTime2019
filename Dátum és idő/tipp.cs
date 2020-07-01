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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int db = int.Parse(label1.Text);

            if (0 < db)
            {
                db--;
            }
            else
            {
                MessageBox.Show("A darabszám nem lehet 0-nál kevesebb!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label1.Text = db.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int db = int.Parse(label1.Text) + 1;
            label1.Text = db.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int db = int.Parse(label1.Text);

            if (db == 11)
            {
                Form6 t = new Form6();
                Hide();
                t.ShowDialog();
                t.Show();
            }
            else if (9 <= db && db <= 13)
            {
                MessageBox.Show("Már majdnem jó", "Közelítesz");
            }
            else if (db < 9 || 13 < db)
            {
                MessageBox.Show("Még messze vagy a jó megoldástól, próbáld újra megszámolni. Tipp: van egy kakukktojás", ":(");
            }
        }
    }
}
