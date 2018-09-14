using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class Marcas : Form
    {
        public Marcas()
        {
            InitializeComponent();
        }

        private void Marcas_Load(object sender, EventArgs e)
        {
            MarcasNegocio marcasNeg = new MarcasNegocio();

            try
            {
                dgvMarcas.DataSource = marcasNeg.listar();
                dgvMarcas.Columns["Estado"].Visible = false;                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrin = new MenuPrincipal();
            this.Hide();
            menuPrin.Show();
        }
    }
}
