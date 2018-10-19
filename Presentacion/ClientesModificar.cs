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
    public partial class ClientesModificar : Form
    {
        public ClientesModificar()
        {
            InitializeComponent();
        }

        private Clientes cliente;

        public ClientesModificar(Clientes cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void ClientesModificar_Load(object sender, EventArgs e)
        {
            LocalidadNegocio Loca = new LocalidadNegocio();
            cbxCodigoPostal.DataSource = Loca.listar();
            cbxCodigoPostal.DisplayMember = "IDLOCALIDAD";
            

            try
            {
                txtDni.Text = cliente.Dni.ToString();
                txtNombre.Text = cliente.Nombre.ToString();
                txtApellido.Text = cliente.Apellido.ToString();
                txtDireccion.Text = cliente.Calle.ToString();
                cbxSexoCliente.Text = cliente.Sexo.ToString();
                dtpFechaNac.Value = cliente.FechaNac;
                cbxCodigoPostal.Text = cliente.IdLocalidad.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void BtnCrearCli_Click(object sender, EventArgs e)
        {
            ClientesNegocio cliNeg = new ClientesNegocio();

            try
            {

                cliente.Dni = Convert.ToInt32(txtDni.Text.Trim());
                cliente.Nombre = txtNombre.Text.Trim();
                cliente.Apellido = txtApellido.Text.Trim();
                cliente.FechaNac = dtpFechaNac.Value;
                cliente.Calle = txtDireccion.Text.Trim();
                cliente.Sexo = cbxSexoCliente.Text.Trim();
                cliente.IdLocalidad = Convert.ToInt32(cbxCodigoPostal.Text.Trim());
                cliente.Estado = true;

                cliNeg.ModificarCliente(cliente);

                MessageBox.Show("Modificado con éxito");
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MenuPrincipal menuPrin = new MenuPrincipal();
                this.Close();
                menuPrin.Show();
            }
        }

        private void cbxCodigoPostal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Localidades aux;
            aux = (Localidades)cbxCodigoPostal.SelectedItem;
            lblLocalidad.Text = aux.Descripcion.ToString();
        }

        private void btnAddLocalidad_Click(object sender, EventArgs e)
        {
            Localidadess ventana = new Localidadess();
            ventana.ShowDialog();

            LocalidadNegocio ubiacc = new LocalidadNegocio();
            cbxCodigoPostal.DataSource = ubiacc.listar();
            cbxCodigoPostal.DisplayMember = "IDLOCALIDAD";
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }
    }
}
