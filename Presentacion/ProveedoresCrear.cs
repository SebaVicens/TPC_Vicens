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
    public partial class ProveedoresCrear : Form
    {
        public ProveedoresCrear()
        {
            InitializeComponent();
        }

        private void ProveedoresCrear_Load(object sender, EventArgs e)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Decea Salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            lblLocalidad.Text = aux.descripcion.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProveedoresNegocio ProvCrear = new ProveedoresNegocio();

            try
            {
                Proveedores Prov = new Proveedores();

                Prov.Cuit = txtCuit.Text.Trim();
                Prov.Descripcion = txtDescripcion.Text.Trim();
                Prov.Direccion = txtDireccion.Text.Trim();
                Prov.IdLocalidad = Convert.ToInt32(cbxCodigoPostal.Text.Trim());
                Prov.Telefono = txtTelefono.Text.Trim();
                Prov.Mail = txtMail.Text.Trim();
                Prov.Estado = true;

                ProvCrear.AgregarProveedor(Prov);
                MessageBox.Show("Agregado con éxito");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
