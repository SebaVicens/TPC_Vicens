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
    public partial class Localidadess : Form
    {
        public Localidadess()
        {
            InitializeComponent();
        }

        private void Localidadess_Load(object sender, EventArgs e)
        {
            LocalidadNegocio ubiacc = new LocalidadNegocio();
            cbxProvincia.DataSource = ubiacc.listarprovincias();
            cbxProvincia.DisplayMember = "DESCRIPCION";
            cbxProvincia.ValueMember = "IDPROVINCIA";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCP.Text != "" && txtDescripcion.Text != "")
            {
                try
                {
                    LocalidadNegocio ubiacc = new LocalidadNegocio();
                    Localidades nlocalidad = new Localidades();
                    Provincias selectprov;

                    nlocalidad.IdLocalidad = Convert.ToInt32(txtCP.Text);
                    nlocalidad.Descripcion = txtDescripcion.Text.Trim();
                    selectprov = (Provincias)cbxProvincia.SelectedItem;
                    nlocalidad.IdProvincia = selectprov.IdProvincia;


                    ubiacc.agregarlocalidad(nlocalidad);
                    MessageBox.Show("Localidad Agregada con Exito");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("No se pudo agregar, Codigo postal Existente");
                }
            }
            else
            {
                MessageBox.Show("Ingrese Un codigo postal");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }
    }
    
}
