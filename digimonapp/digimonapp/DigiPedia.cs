using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace digimonapp
{
    public partial class digiPedia : Form
    {
        private List<Digimonss> listaDigimon;
        public digiPedia()
        {
            InitializeComponent();
        }

        public void DigiPedia_Load(object sender, EventArgs e)
        {

            cargar();

        }

        private void dgvDigimons_SelectionChanged(object sender, EventArgs e)
        {
           Digimonss seleccionado = (Digimonss)dgvDigimons.CurrentRow.DataBoundItem;
            pbxDigimon.Load(seleccionado.Images);
           
            

        }

        private void cargar()
        {
            DigimonDatos datos = new DigimonDatos();
            try
            {
                listaDigimon = datos.listar();
                dgvDigimons.DataSource = listaDigimon;
                pbxDigimon.Load(listaDigimon[0].Images);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void dgvDigimons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAltaDigimon alta = new frmAltaDigimon();
            alta.ShowDialog();
            cargar();

        }

        private void pbxDigimon_Click(object sender, EventArgs e)
        {

        }
    }
}
