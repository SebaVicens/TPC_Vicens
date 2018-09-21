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
            Articulos articulosListar = new Articulos();
            this.Hide();
            articulosListar.Show();
        }

        private void mARCASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marcas marcasListar = new Marcas();
            this.Hide();
            marcasListar.Show();
        }

        private void TsmClientes_Click(object sender, EventArgs e)
        {
            Clientes clientesListar = new Clientes();
            this.Hide();
            clientesListar.Show();
        }

        private void TsmProveedores_Click(object sender, EventArgs e)
        {
            Proveedores provListar = new Proveedores();
            this.Hide();
            provListar.Show();
        }
    }
}
