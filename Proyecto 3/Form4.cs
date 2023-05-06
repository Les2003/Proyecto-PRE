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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 v1 = new Form1();
            v1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal v0 = new FormPrincipal();
            v0.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Programadores P = new Programadores();
            P.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
