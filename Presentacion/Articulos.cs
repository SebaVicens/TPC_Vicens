﻿using System;
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
    public partial class Articulos : Form
    {
        public Articulos()
        {
            InitializeComponent();
        }

        private void Articulos_Load(object sender, EventArgs e)
        {
            ArticulosNegocio artListar = new ArticulosNegocio();

            try
            {

                dgvArticulos.DataSource = artListar.listar();
                dgvArticulos.Columns["IdArticulo"].Visible = false;
                dgvArticulos.Columns["Proveedores"].Visible = false;
                dgvArticulos.Columns["PuCompra"].Visible = false;
                dgvArticulos.Columns["Estado"].Visible = false;
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
    }
}
