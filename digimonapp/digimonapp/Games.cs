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
    public partial class Games : Form
    {
        public Games()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Games2 Games2 = new Games2();
            Games2.ShowDialog();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Games Games = new Games();
            Games.ShowDialog();
        }
    }
}
