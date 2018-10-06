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
    public partial class Clientess : Form
    {
        public Clientess()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            ClientesNegocio clientesListar = new ClientesNegocio();

            try
            {
                dgvClientes.DataSource = clientesListar.listar();
                dgvClientes.Columns["Estado"].Visible = false;
                //dgvClientes.Columns["IdCliente"].Visible = false;
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

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            ClientesCrear cli = new ClientesCrear();
            this.Hide();
            cli.Show();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            Clientes clientes = (Clientes)dgvClientes.CurrentRow.DataBoundItem;
            ClientesModificar cliMod = new ClientesModificar(clientes);
            this.Hide();
            cliMod.Show();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            ClientesNegocio cliNeg = new ClientesNegocio();
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Está seguro de que desea eliminar el registro?", "Seguro?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        Clientes aux = (Clientes)dgvClientes.CurrentRow.DataBoundItem;

                        cliNeg.eliminar(aux.IdCliente);
                        Clientess cli = new Clientess();
                        this.Hide();
                        cli.Show();
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
