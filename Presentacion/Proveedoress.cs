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
    public partial class Proveedoress : Form
    {
        public Proveedoress()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            ProveedoresNegocio provListar = new ProveedoresNegocio();
            try
            {
                dgvProv.DataSource = provListar.listar();
                dgvProv.Columns["Descripcion"].Visible = false;
                dgvProv.Columns["Estado"].Visible = false;
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
            ProveedoresCrear ProvCrear = new ProveedoresCrear();
            this.Hide();
            ProvCrear.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = (Proveedores)dgvProv.CurrentRow.DataBoundItem;
            ProveedoresModificar proMod = new ProveedoresModificar(proveedores);
            this.Hide();
            proMod.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProveedoresNegocio proNeg = new ProveedoresNegocio();
            try
            {
                if (dgvProv.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Está seguro de que desea eliminar el registro?", "Seguro?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        Proveedores aux = (Proveedores)dgvProv.CurrentRow.DataBoundItem;

                        proNeg.eliminar(aux.IdProveedor);
                        Proveedoress pro = new Proveedoress();
                        this.Hide();
                        pro.Show();
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
