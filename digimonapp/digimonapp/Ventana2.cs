using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digimonapp
{
    public partial class Ventana2 : Form
    {
        public Ventana2()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            digiPedia DigiPedia = new digiPedia();
            DigiPedia.Show();
            
           
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void digiStoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(VentanaStory))
                    return;
            }


            VentanaStory ventanaStory = new VentanaStory();
            ventanaStory.MdiParent = this;
            ventanaStory.Show();
        }

        private void Ventana2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            VentanaStory ventanaStory = new VentanaStory();
            
            ventanaStory.ShowDialog();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            digiPedia DigiPedia = new digiPedia();
            DigiPedia.ShowDialog();
        }

        private void gamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Games Games = new Games();
            Games.ShowDialog();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Games Games = new Games();
            Games.ShowDialog();
        }

        private void contacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contacto contacto = new Contacto();
            contacto.ShowDialog();

        }
    }
}
