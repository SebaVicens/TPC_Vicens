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
    public partial class Ventasss : Form
    {
        public Ventasss()
        {
            InitializeComponent();
        }

        public Ventasss(int venta)
        {
            InitializeComponent();
            vent = venta;
        }

        private int vent;

        private void Ventasss_Load(object sender, EventArgs e)
        {
            VentasNegocio v = new VentasNegocio();
            dgvNventas.DataSource = v.traerPorVenta(vent);
            lblAtiende.Text = dgvNventas.CurrentRow.Cells["Vendedor"].Value.ToString();
            lblCliente.Text = dgvNventas.CurrentRow.Cells["Cliente"].Value.ToString();
            dtpFechaFactura.Text = dgvNventas.CurrentRow.Cells["Fecha"].Value.ToString();

            double total = 0;

            foreach (DataGridViewRow row in dgvNventas.Rows)
            {
                total += Convert.ToDouble(row.Cells["Total"].Value);
            }
            lblTotal.Text = Convert.ToString(total);

            dgvNventas.Columns["Fecha"].Visible = false;
            dgvNventas.Columns["Cliente"].Visible = false;
            dgvNventas.Columns["Vendedor"].Visible = false;
            dgvNventas.Columns["Ventadet"].Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
