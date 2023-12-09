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
    public partial class frmAltaDigimon : Form
    {
        public frmAltaDigimon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Digimonss digi = new Digimonss();
            DigimonDatos datos = new DigimonDatos();
            try
            {   
                
                digi.Digimon = txtDigimon.Text;
                digi.Tipe = txtTipe.Text;
                digi.Atack = txtAtackk.Text;
                digi.Images = txtImages.Text;

                datos.agregar(digi);
                MessageBox.Show("Agregado Exitosamente");
                Close();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtImages_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImages.Text);
        }

        private void cargarImagen(string Images)
        {
            
            try
            {

                pbxImagesD.Load(Images);
            }
            catch (Exception ex)
            {

                pbxImagesD.Load("https://clipart-library.com/data_images/208821.png");
            }
        }

        private void frmAltaDigimon_Load(object sender, EventArgs e)
        {
            cargarImagen(txtImages.Text);
        }



        private void pbxImagesAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
