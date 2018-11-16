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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static Usuarios Userlogin;

        private void Login_Load(object sender, EventArgs e)
        {
            UsuariosNegocio usuariolista = new UsuariosNegocio();
            cbxLogin.DataSource = usuariolista.listar();
            cbxLogin.DisplayMember = "Nombre";
            cbxLogin.ValueMember = "IDusuario";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Userlogin = (Usuarios)cbxLogin.SelectedItem;
            if (Userlogin.password == TxtPass.Text)
            {
                MessageBox.Show("Bienvenido");

                this.Close();
                                
            }
            else
            {
                MessageBox.Show("Password incorrecto");
            }
        }
    }
}
