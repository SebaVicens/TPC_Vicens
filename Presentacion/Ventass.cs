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
    public partial class Ventass : Form
    {
        public Ventass()
        {
            InitializeComponent();
        }

        public static decimal TotalVenta;
        private IList<VentaArticulos> listaDetalleVenta = new List<VentaArticulos>();

        private void Ventass_Load(object sender, EventArgs e)
        {

            try
            {
                txtCantidad.Text = "1";
                TotalVenta = 0;

                lblAtiende.Text = Login.Userlogin.Nombre.ToString();
                ArticulosNegocio articuloslista = new ArticulosNegocio();
                ClientesNegocio clienteslista = new ClientesNegocio();
                cbxCliente.DataSource = clienteslista.listar();
                cbxCliente.DisplayMember = "nombre";
                cbxArticulos.DataSource = articuloslista.listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cbxArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Articulos aux;
            aux = (Articulos)cbxArticulos.SelectedItem;
            txtPrecio.Text = aux.Pu.ToString();
            txtStock.Text = aux.Stock.ToString();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            VentaArticulos nuevo = new VentaArticulos();

            int newidventa = 0;
            VentasNegocio ventaacc = new VentasNegocio();
            newidventa = ventaacc.obtenerId();

            int stockp;
            nuevo.Articulos = (Articulos)cbxArticulos.SelectedItem;
            nuevo.IdArticulo = nuevo.Articulos.IdArticulo;

            stockp = ventaacc.ConsultarStock(nuevo.Articulos.IdArticulo);

            if (dgvNventas.RowCount == 0)
            {
                if (Convert.ToInt32(txtCantidad.Text) <= stockp)
                {
                    nuevo.IdArticulo = nuevo.Articulos.IdArticulo;
                    nuevo.IdVenta = newidventa;
                    nuevo.Cantidad = Convert.ToInt32(txtCantidad.Text);
                    nuevo.Pu = nuevo.Articulos.Pu;
                    nuevo.PuSubtotal = nuevo.Cantidad * nuevo.Pu;



                    listaDetalleVenta.Add(nuevo);

                    TotalVenta = TotalVenta + nuevo.PuSubtotal;
                    lblTotal.Text = TotalVenta.ToString();

                    dgvNventas.DataSource = null;
                    dgvNventas.DataSource = listaDetalleVenta;
                    dgvNventas.Columns["IDVENTA"].Visible = false;
                    dgvNventas.Columns["IDARTICULO"].Visible = false;
                }
                else
                {
                    MessageBox.Show("El stock del producto no permite cargar el producto");
                }
            }
            else
            {
                nuevo.Articulos = (Articulos)cbxArticulos.SelectedItem;

                foreach (VentaArticulos fila in listaDetalleVenta)

                {
                    if (fila.IdArticulo == nuevo.Articulos.IdArticulo)
                    {

                        stockp = ventaacc.ConsultarStock(nuevo.Articulos.IdArticulo);
                        Decimal montoanterior;
                        montoanterior = fila.PuSubtotal;
                        if (fila.Cantidad + Convert.ToInt32(txtCantidad.Text) <= stockp)
                        {
                            fila.Pu = nuevo.Articulos.Pu;
                            fila.Cantidad = fila.Cantidad + Convert.ToInt32(txtCantidad.Text);
                            fila.PuSubtotal = fila.Cantidad * fila.Pu;


                            TotalVenta = (TotalVenta + fila.PuSubtotal) - montoanterior;
                            lblTotal.Text = TotalVenta.ToString();



                            dgvNventas.DataSource = null;
                            dgvNventas.DataSource = listaDetalleVenta;
                            dgvNventas.Columns["IDVENTA"].Visible = false;
                            dgvNventas.Columns["IDARTICULO"].Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("No Existe Sufuciente stock");
                        }

                        existe = true;
                    }

                }

                if (existe == false)
                {
                    if (Convert.ToInt32(txtCantidad.Text) <= stockp)
                    {
                        dgvNventas.DataSource = listaDetalleVenta;
                        nuevo.IdVenta = newidventa;
                        nuevo.Articulos = (Articulos)cbxArticulos.SelectedItem;
                        nuevo.Cantidad = Convert.ToInt32(txtCantidad.Text);
                        nuevo.Pu = nuevo.Articulos.Pu;
                        nuevo.PuSubtotal = nuevo.Cantidad * nuevo.Pu;
                        listaDetalleVenta.Add(nuevo);

                        TotalVenta = TotalVenta + nuevo.PuSubtotal;
                        lblTotal.Text = TotalVenta.ToString();

                        dgvNventas.DataSource = null;
                        dgvNventas.DataSource = listaDetalleVenta;
                        dgvNventas.Columns["IDVENTA"].Visible = false;
                        dgvNventas.Columns["IDARTICULO"].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("El stock del producto no permite cargar el producto");

                    }
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvNventas.RowCount > 0)
            {
                if (dgvNventas.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione el articulo a Eliminar");
                }

                else
                {
                    VentaArticulos obj = (VentaArticulos)dgvNventas.CurrentRow.DataBoundItem;
                    listaDetalleVenta.Remove(obj);
                    dgvNventas.DataSource = null;
                    dgvNventas.DataSource = listaDetalleVenta;
                    dgvNventas.Columns["IDVENTA"].Visible = false;
                    dgvNventas.Columns["IDARTICULO"].Visible = false;
                    TotalVenta = TotalVenta - obj.PuSubtotal;
                    lblTotal.Text = TotalVenta.ToString();
                }
            }
            else
            {
                MessageBox.Show("No posee articulos para eliminar");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrin = new MenuPrincipal();
            this.Hide();
            menuPrin.Show();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvNventas.RowCount > 0)
                {
                    // -- GenerarVenta -- //
                    VentasNegocio venta = new VentasNegocio();
                    Ventas nuevaventa = new Ventas();
                    Clientes auxclie;

                    auxclie = (Clientes)cbxCliente.SelectedItem;

                    nuevaventa.IdUsuario = Login.Userlogin.idusuario;
                    nuevaventa.IdCliente = auxclie.IdCliente;
                    nuevaventa.Fecha = dtpFechaFactura.Value;
                    venta.Generarventa(nuevaventa);


                    // -- Detalle de Venta -- //

                    VentaArticulos artxventa = new VentaArticulos();

                    foreach (VentaArticulos fila in listaDetalleVenta)
                    {
                        venta.GenerarArtxVenta(fila);
                        venta.ActualizarStock(fila);
                    }

                    MessageBox.Show("Venta Generada");
                    MenuPrincipal menuPrin = new MenuPrincipal();
                    this.Hide();
                    menuPrin.Show();

                }


                else
                {
                    MessageBox.Show("Seleccione un articulo y cantidad");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    
}
