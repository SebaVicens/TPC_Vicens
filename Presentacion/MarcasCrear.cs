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
    public partial class MarcasCrear : Form
    {
        public MarcasCrear()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Decea Salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MenuPrincipal menuPrin = new MenuPrincipal();
                this.Close();
                menuPrin.Show();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcasNegocio marcNeg = new MarcasNegocio();

            try
            {

                Marcas marcas = new Marcas();

                marcas.IdMarca = Convert.ToInt32(txtIdmarca.Text.Trim());
                marcas.Descripcion = txtNombre.Text.Trim();
                marcas.Estado = true;

                marcNeg.AgregarMarca(marcas);
                MessageBox.Show("Agregado con éxito");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
