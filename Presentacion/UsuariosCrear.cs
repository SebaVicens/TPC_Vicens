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
    public partial class UsuariosCrear : Form
    {
        public UsuariosCrear()
        {
            InitializeComponent();
        }

        private void UsuariosCrear_Load(object sender, EventArgs e)
        {
            LocalidadNegocio ubiacc = new LocalidadNegocio();
            cbxCodigoPostal.DataSource = ubiacc.listar();
            cbxCodigoPostal.DisplayMember = "IDLOCALIDAD";

            UsuariosNegocio usuarioacc = new UsuariosNegocio();
            cbxGerarquia.DataSource = usuarioacc.listargerarquias();
            cbxGerarquia.DisplayMember = "DESCRIPCION";

            cbxSexo.Text = "MASCULINO";
        }

        private void btnAddLocalidad_Click(object sender, EventArgs e)
        {
            Localidadess ventana = new Localidadess();
            ventana.ShowDialog();

            LocalidadNegocio ubiacc = new LocalidadNegocio();
            cbxCodigoPostal.DataSource = ubiacc.listar();
            cbxCodigoPostal.DisplayMember = "IDLOCALIDAD";
        }

        private void cbxCodigoPostal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Localidades aux;
            aux = (Localidades)cbxCodigoPostal.SelectedItem;
            lblLocalidad.Text = aux.Descripcion.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            UsuariosNegocio usuarioacc = new UsuariosNegocio();

            try
            {
                Usuarios newusuario = new Usuarios();

                newusuario.Nombre = txtNombre.Text.Trim();
                newusuario.Apellido = txtApellido.Text.Trim();
                newusuario.Dni = Convert.ToInt32(txtDni.Text.Trim());
                newusuario.FechaNac = dtpUsuario.Value;
                newusuario.Direccion = txtDireccion.Text.ToString();
                newusuario.sexo = cbxSexo.Text.Trim();
                newusuario.idlocalidad = Convert.ToInt32(cbxCodigoPostal.Text.Trim());
                newusuario.password = txtPassword.Text.Trim();
                newusuario.gerarquia = (UsuariosGerarquia)cbxGerarquia.SelectedItem;
                newusuario.Estado = true;
                
                usuarioacc.agregar(newusuario);

                MessageBox.Show("Usuario Agregado con Exito");
                Usuarioss usc = new Usuarioss();
                this.Close();
                usc.Show();

            }
            catch (Exception)
            {

                throw;
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
