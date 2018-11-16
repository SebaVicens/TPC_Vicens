using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void TsmArticulos_Click(object sender, EventArgs e)
        {
            Articuloss articulosListar = new Articuloss();
            
            articulosListar.Show();
        }

        private void mARCASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marcass marcasListar = new Marcass();
            
            marcasListar.Show();
        }

        private void TsmClientes_Click(object sender, EventArgs e)
        {
            Clientess clientesListar = new Clientess();
            
            clientesListar.Show();
        }

        private void TsmProveedores_Click(object sender, EventArgs e)
        {
            Proveedoress provListar = new Proveedoress();
            
            provListar.Show();
        }

        private void TsmCompras_Click(object sender, EventArgs e)
        {
            Comprarr ventass = new Comprarr();
            
            ventass.Show();
        }

        private void TsmVentas_Click(object sender, EventArgs e)
        {
            Ventass comprarrr = new Ventass();
            
            comprarrr.Show();
        }

        private void TsmUsuarios_Click(object sender, EventArgs e)
        {
            Usuarioss usuarios = new Usuarioss();
            
            usuarios.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
        }
    }
}
