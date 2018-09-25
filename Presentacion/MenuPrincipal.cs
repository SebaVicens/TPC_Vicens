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
            this.Hide();
            articulosListar.Show();
        }

        private void mARCASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marcass marcasListar = new Marcass();
            this.Hide();
            marcasListar.Show();
        }

        private void TsmClientes_Click(object sender, EventArgs e)
        {
            Clientess clientesListar = new Clientess();
            this.Hide();
            clientesListar.Show();
        }

        private void TsmProveedores_Click(object sender, EventArgs e)
        {
            Proveedoress provListar = new Proveedoress();
            this.Hide();
            provListar.Show();
        }
    }
}
