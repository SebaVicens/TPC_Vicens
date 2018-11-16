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
        public ArticulosCrear()     
        {
            InitializeComponent();
        }

        private Articulos articulos;

        public ArticulosCrear(Articulos articulos)
        {
            InitializeComponent();
            this.articulos = articulos;
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
            ArticulosNegocio artNeg = new ArticulosNegocio();

            try
            {

                Articulos articulo = new Articulos();

                articulo.Descripcion = txtDescripcion.Text.Trim();
                articulo.Proveedores = (Proveedores)cbxProveedor.SelectedItem;
                articulo.Marca = (Marcas)cbxMarca.SelectedItem;
                articulo.Origen = txtOrigen.Text.Trim();
                articulo.Stock = Convert.ToInt32(txtStock.Text.Trim());
                articulo.Pu = Convert.ToInt32(txtPu.Text.Trim());
                articulo.PuCompra = Convert.ToInt32(txtPuCompra.Text.Trim());
                articulo.Estado = true;

                artNeg.AgregarArticulo(articulo);
                MessageBox.Show("Agregado con éxito");
                Articuloss art = new Articuloss();
                this.Close();
                art.Show();

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
                Articuloss art = new Articuloss();
                this.Close();
                art.Show();
            }
        }

        private void txtOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtPu_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtPuCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }
    }
}
