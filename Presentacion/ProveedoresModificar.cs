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
    public partial class ProveedoresModificar : Form
    {
        public ProveedoresModificar()
        {
            InitializeComponent();
        }

        private Proveedores proveedores;

        public ProveedoresModificar(Proveedores proveedores)
        {
            InitializeComponent();
            this.proveedores = proveedores;
        }

        private void ProveedoresModificar_Load(object sender, EventArgs e)
        {
            LocalidadNegocio Loca = new LocalidadNegocio();
            cbxCodigoPostal.DataSource = Loca.listar();
            cbxCodigoPostal.DisplayMember = "IDLOCALIDAD";

            try
            {
                txtCuit.Text = proveedores.Cuit;
                txtDescripcion.Text = proveedores.Descripcion;
                txtDireccion.Text = proveedores.Direccion;
                cbxCodigoPostal.Text = proveedores.IdLocalidad.ToString();
                txtTelefono.Text = proveedores.Telefono;
                txtMail.Text = proveedores.Mail;


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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MenuPrincipal menuPrin = new MenuPrincipal();
                this.Close();
                menuPrin.Show();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProveedoresNegocio ProvCrear = new ProveedoresNegocio();

            try
            {

                proveedores.Cuit = txtCuit.Text.Trim();
                proveedores.Descripcion = txtDescripcion.Text.Trim();
                proveedores.Direccion = txtDireccion.Text.Trim();
                proveedores.IdLocalidad = Convert.ToInt32(cbxCodigoPostal.Text.Trim());
                proveedores.Telefono = txtTelefono.Text.Trim();
                proveedores.Mail = txtMail.Text.Trim();
                proveedores.Estado = true;

                ProvCrear.ModificarProveedor(proveedores);
                MessageBox.Show("Modificado con éxito");
                


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
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

        private void txtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }
    }
}
