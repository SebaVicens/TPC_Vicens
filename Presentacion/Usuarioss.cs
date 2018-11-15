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
    public partial class Usuarioss : Form
    {
        public Usuarioss()
        {
            InitializeComponent();
        }

        private void Usuarioss_Load(object sender, EventArgs e)
        {
            cargargrilla();
        }

        private void cargargrilla()
        {
           
            if (Login.Userlogin.gerarquia.idgerarquia < 2)
            {
                btnCrear.Visible = true;
                btnModificar.Visible = true;
                btnEliminar.Visible = true;
            }
            else
            {
                btnCrear.Visible = false;
                btnModificar.Visible = false;
                btnEliminar.Visible = false;
            }

            UsuariosNegocio usuarioacc = new UsuariosNegocio();

            try
            {

                dgvUsuarios.DataSource = usuarioacc.listar();
                dgvUsuarios.Columns["PASSWORD"].Visible = false;
                dgvUsuarios.Columns["ESTADO"].Visible = false;

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
            UsuariosCrear usc = new UsuariosCrear();
            this.Hide();
            usc.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = (Usuarios)dgvUsuarios.CurrentRow.DataBoundItem;
            UsuariosModificar usm = new UsuariosModificar(usuarios);
            this.Hide();
            usm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            UsuariosNegocio usNeg = new UsuariosNegocio();
            try
            {
                if (dgvUsuarios.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Está seguro de que desea eliminar el registro?", "Seguro?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        Usuarios aux = (Usuarios)dgvUsuarios.CurrentRow.DataBoundItem;

                        usNeg.eliminar(aux.idusuario);
                        Usuarioss pro = new Usuarioss();
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
