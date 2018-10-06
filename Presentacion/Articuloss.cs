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
    public partial class Articuloss : Form
    {
        public Articuloss()
        {
            InitializeComponent();
        }

        private void Articulos_Load(object sender, EventArgs e)
        {
            ArticulosNegocio artListar = new ArticulosNegocio();

            try
            {

                dgvArticulos.DataSource = artListar.listar();
               
                dgvArticulos.Columns["Proveedores"].Visible = false;
                dgvArticulos.Columns["PuCompra"].Visible = false;
                dgvArticulos.Columns["Estado"].Visible = false;
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

        private void btnCrear_Click(object sender, EventArgs e)
        {
            ArticulosCrear artGral = new ArticulosCrear();
            this.Hide();
            artGral.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulos articulos = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            ArticulosModificar artMod = new ArticulosModificar(articulos);
            this.Hide();
            artMod.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio artNeg = new ArticulosNegocio();
            try
            {
                if (dgvArticulos.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Está seguro de que desea eliminar el registro?", "Seguro?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        Articulos aux = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

                        artNeg.eliminar(aux.IdArticulo);
                        Articuloss art = new Articuloss();
                        this.Hide();
                        art.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un registro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
