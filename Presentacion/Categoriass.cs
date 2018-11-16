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
    public partial class Categoriass : Form
    {
        public Categoriass()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CategoriasArticuloss catt = new CategoriasArticuloss();
                this.Close();
                catt.Show();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                CategoriasNegocio catneg = new CategoriasNegocio();
                CategoriasArticulos catnueva = new CategoriasArticulos();

                catnueva.Descripcion = txtCateg.Text.Trim();
                catnueva.Estado = true;

                catneg.agregarcategoria(catnueva);
                MessageBox.Show("Categoria Agregada con Exito");
                CategoriasArticuloss catt = new CategoriasArticuloss();
                this.Close();
                catt.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
