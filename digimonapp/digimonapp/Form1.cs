using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digimonapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string nombre = txtName.Text;
            string numero = nudAge.Value.ToString();
            MessageBox.Show("Welcome " + nombre );
            Ventana2 ventana2 = new Ventana2();
            ventana2.Show();

          
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
        }
    }
}
