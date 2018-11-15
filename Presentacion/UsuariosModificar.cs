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
    public partial class UsuariosModificar : Form
    {
        public UsuariosModificar()
        {
            InitializeComponent();
        }

        private Usuarios usuarios;

        public UsuariosModificar(Usuarios usuarios)
        {
            InitializeComponent();
            this.usuarios = usuarios;
        }

        private void btnAddLocalidad_Click(object sender, EventArgs e)
        {
            Localidadess ventana = new Localidadess();
            ventana.ShowDialog();

            LocalidadNegocio ubiacc = new LocalidadNegocio();
            cbxCodigoPostal.DataSource = ubiacc.listar();
            cbxCodigoPostal.DisplayMember = "IDLOCALIDAD";
        }

        private void cbxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Localidades aux;
            aux = (Localidades)cbxCodigoPostal.SelectedItem;
            lblLocalidad.Text = aux.Descripcion.ToString();
        }

        private void UsuariosModificar_Load(object sender, EventArgs e)
        {
            LocalidadNegocio Loca = new LocalidadNegocio();
            cbxCodigoPostal.DataSource = Loca.listar();
            cbxCodigoPostal.DisplayMember = "IDLOCALIDAD";

            UsuariosNegocio usuarioacc = new UsuariosNegocio();
            cbxGerarquia.DataSource = usuarioacc.listargerarquias();
            cbxGerarquia.DisplayMember = "DESCRIPCION";

            try
            {
                
                txtNombre.Text = usuarios.Nombre.ToString();
                txtApellido.Text = usuarios.Apellido.ToString();
                txtDni.Text = usuarios.Dni.ToString();
                dtpUsuario.Value = usuarios.FechaNac;
                txtDireccion.Text = usuarios.Direccion.ToString();
                cbxSexo.Text = usuarios.sexo.ToString();
                cbxCodigoPostal.Text = usuarios.idlocalidad.ToString();
                txtPassword.Text = usuarios.password.ToString();
                cbxGerarquia.Text = usuarios.gerarquia.descripcion.ToString();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            UsuariosNegocio usuarioacc = new UsuariosNegocio();

            try
            {

                usuarios.Nombre = txtNombre.Text.Trim();
                usuarios.Apellido = txtApellido.Text.Trim();
                usuarios.Dni = Convert.ToInt32(txtDni.Text.Trim());
                usuarios.FechaNac = dtpUsuario.Value;
                usuarios.Direccion = txtDireccion.Text.ToString();
                usuarios.sexo = cbxSexo.Text.Trim();
                usuarios.idlocalidad = Convert.ToInt32(cbxCodigoPostal.Text.Trim());
                usuarios.password = txtPassword.Text.Trim();
                usuarios.gerarquia = (UsuariosGerarquia)cbxGerarquia.SelectedItem;
                usuarios.Estado = true;

                usuarioacc.modificar(usuarios);

                MessageBox.Show("Usuario Modificado con Exito");
                Usuarioss usc = new Usuarioss();
                this.Close();
                usc.Show();

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
                Usuarioss us = new Usuarioss();
                this.Close();
                us.Show();
            }
        }
    }
}
