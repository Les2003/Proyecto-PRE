using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_3
{
    public partial class Form1 : Form
    {
        string nombre_cliente;
      
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string nombre)
        {
            InitializeComponent();
            nombre_cliente = nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 v2 = new Form2();
            v2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 v3 = new Form3();
            v3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 v4 = new Form4();
            v4.Show();
        }

        private void nombre_clnt_Click(object sender, EventArgs e)
        {

        }

        private void nombre_clnt_Load(object sender, EventArgs e)
        {
            nombre_clnt_Load(sender, e, nombre_cliente);
        }

        private void nombre_clnt_Load(object sender, EventArgs e, string nombre_cliente)
        {
            nombre_clnt.Text = "Bienvenido" + nombre_cliente;
        }
    }
}
