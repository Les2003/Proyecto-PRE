using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Form1 v1 = new Form1())
                v1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 v5 = new Form5();
            v5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 v6 = new Form6();
            v6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 v7 = new Form7();
            v7.Show();
        }
    }
}
