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
    public partial class ArticulosModificar : Form
    {
        public ArticulosModificar()
        {
            InitializeComponent();
        }

        private Articulos articulos;

        public ArticulosModificar(Articulos articulos)
        {
            InitializeComponent();
            this.articulos = articulos;
        }

        private void ArticulosModificar_Load(object sender, EventArgs e)
        {
            ProveedoresNegocio provacc = new ProveedoresNegocio();
            cbxProveedor.DataSource = provacc.listar2();
            //cbxProveedor.DisplayMember = "DESCRIPCION";


            MarcasNegocio marcaacc = new MarcasNegocio();
            cbxMarca.DataSource = marcaacc.listar();
            //cbxMarca.DisplayMember = "DESCRIPCION";

            try
            {
                txtDescripcion.Text = articulos.Descripcion.ToString();
                cbxProveedor.Text = articulos.Proveedores.Descripcion;
                cbxMarca.Text = articulos.Marca.Descripcion;
                txtOrigen.Text = articulos.Origen.ToString();
                txtStock.Text = articulos.Stock.ToString();
                txtPu.Text = articulos.Pu.ToString();
                txtPuCompra.Text = articulos.PuCompra.ToString();

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

                articulos.Descripcion = txtDescripcion.Text.Trim();
                articulos.Marca = (Marcas)cbxMarca.SelectedItem;
                articulos.Proveedores = (Proveedores)cbxProveedor.SelectedItem;
                articulos.Origen = txtOrigen.Text.Trim();
                articulos.Stock = Convert.ToInt32(txtStock.Text.Trim());
                articulos.PuCompra = Convert.ToDecimal(txtPuCompra.Text.Trim());
                articulos.Pu = Convert.ToDecimal(txtPu.Text.Trim());
                articulos.Estado = true;

                artNeg.ModificarArticulo(articulos);

                MessageBox.Show("Modificado con éxito");
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

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
