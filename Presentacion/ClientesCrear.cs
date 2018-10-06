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
    public partial class ClientesCrear : Form
    {
        public ClientesCrear()
        {
            InitializeComponent();
        }

        private Clientes cliente;

        public ClientesCrear(Clientes cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void ClientesCrear_Load(object sender, EventArgs e)
        {
            LocalidadNegocio Loca = new LocalidadNegocio();

            try
            {
                cbxCodigoPostal.DataSource = Loca.listar();
                cbxCodigoPostal.DisplayMember = "IDLOCALIDAD";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbxCodigoPostal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Localidades aux;
            aux = (Localidades)cbxCodigoPostal.SelectedItem;
            lblLocalidad.Text = aux.Descripcion.ToString();
        }

        private void BtnCrearCli_Click(object sender, EventArgs e)
        {

            ClientesNegocio clientesCrear = new ClientesNegocio();

            try
            {
                Clientes cli = new Clientes();

                cli.Dni = Convert.ToInt32(txtDni.Text.Trim());
                cli.Nombre = txtNombre.Text.Trim();
                cli.Apellido = txtApellido.Text.Trim();
                cli.FechaNac = dtpFechaNac.Value;
                cli.Calle = txtDireccion.Text.Trim();
                cli.Sexo = cbxSexoCliente.Text.Trim();
                cli.IdLocalidad = Convert.ToInt32(cbxCodigoPostal.Text.Trim());
                cli.Estado = true;

                clientesCrear.AgregarCliente(cli);
                MessageBox.Show("Agregado con éxito");
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Decea Salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MenuPrincipal menuPrin = new MenuPrincipal();
                this.Close();
                menuPrin.Show();
            }
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
