using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class ArticulosCrear : Form
    {
        public ArticulosCrear() //
        {
            InitializeComponent();
        }

        public Articulos articulo;
        public ArticulosCrear(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void ArticulosGral_Load(object sender, EventArgs e)
        {
            MarcasNegocio marc = new MarcasNegocio();

            try
            {
                cbxMarca.DataSource = marc.listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            ProveedoresNegocio prov = new ProveedoresNegocio();

            try
            {
                cbxProveedor.DataSource = prov.listar2();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
