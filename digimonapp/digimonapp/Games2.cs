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
    public partial class Games2 : Form
    {
        public Games2()
        {
            InitializeComponent();
        }

        private void asd_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Games Games = new Games();
            Games.ShowDialog();
            Close ();
        }

        private void gamesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
