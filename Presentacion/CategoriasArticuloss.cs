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
    public partial class CategoriasArticuloss : Form
    {
        public CategoriasArticuloss()
        {
            InitializeComponent();
        }

        private void CategoriasArticuloss_Load(object sender, EventArgs e)
        {
            CategoriasNegocio catart = new CategoriasNegocio();
            ArticulosNegocio artneg = new ArticulosNegocio();

            try
            {

                cmbCategoria.DataSource = catart.listar();
                cmbArticulo.DataSource = artneg.listar2();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriasNegocio catneg = new CategoriasNegocio();
            CategoriaPorArticulos catporart = new CategoriaPorArticulos();
            
            try
            {
                catporart.Articulos = (Articulos)cmbArticulo.SelectedItem;
                catporart.CategoriaArticulos = (CategoriasArticulos)cmbCategoria.SelectedItem;

                catneg.agregarcategoriaporarticulo(catporart);

                MessageBox.Show("Agregado con Exito");
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddLocalidad_Click(object sender, EventArgs e)
        {
            Categoriass catego = new Categoriass();
            this.Close();
            catego.Show();
        }
    }
}
