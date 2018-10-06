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
    public partial class Marcass : Form
    {
        public Marcass()
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

        private void btnCrearMarca_Click(object sender, EventArgs e)
        {
            MarcasCrear marcaCrear = new MarcasCrear();
            this.Hide();
            marcaCrear.Show();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            MarcasNegocio marNeg = new MarcasNegocio();
            try
            {
                if (dgvMarcas.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Está seguro de que desea eliminar el registro?", "Seguro?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        Marcas aux = (Marcas)dgvMarcas.CurrentRow.DataBoundItem;

                        marNeg.eliminar(aux.IdMarca);
                        Marcass mar = new Marcass();
                        this.Hide();
                        mar.Show();
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
