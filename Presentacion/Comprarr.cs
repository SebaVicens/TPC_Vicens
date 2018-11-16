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
    public partial class Comprarr : Form
    {
        public Comprarr()
        {
            InitializeComponent();
        }

        public static decimal TotalCompra; 
        private IList<CompraArticulos> listaDetallecompra = new List<CompraArticulos>(); //

        private void Comprarr_Load(object sender, EventArgs e)
        {

            try
            {
                List<CompraArticulos> listaDetallecompra2 = new List<CompraArticulos>(); //
                listaDetallecompra = listaDetallecompra2; //

                lblTotal.Text = "0";
                TotalCompra = 0;

                lblusuariocomp.Text = Login.Userlogin.Nombre.ToString();

                ProveedoresNegocio provelista = new ProveedoresNegocio();
                cbxproveedor.DataSource = provelista.listar2();
                cbxproveedor.DisplayMember = "DESCRIPCION";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        } // LOAD

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Proveedores auxprov = new Proveedores();
            auxprov = (Proveedores)cbxproveedor.SelectedItem;

            int newidcompra = 0;

            txtCantidad.Text = "1";
            ArticulosNegocio articuloslista = new ArticulosNegocio();
            cbxArticulos.DataSource = articuloslista.listarxprov(auxprov);

            ComprasNegocio comprasacc = new ComprasNegocio();
            newidcompra = comprasacc.obtenerId();

           
        } // INICIO LA COMPRA

        private void cbxArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Articulos aux;
            aux = (Articulos)cbxArticulos.SelectedItem;
            txtPrecio.Text = aux.Pu.ToString();
            txtStock.Text = aux.Stock.ToString();
            txtCompra.Text = aux.PuCompra.ToString();
        } // EVENTO QUE CARGA LOS VALORES DE ARTICULO SELEC

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvCompras.RowCount > 0)
            {
                if (DgvCompras.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione el articulo a Eliminar");
                }

                else
                {
                    CompraArticulos obj = (CompraArticulos)DgvCompras.CurrentRow.DataBoundItem;
                    listaDetallecompra.Remove(obj);
                    DgvCompras.DataSource = null;
                    DgvCompras.DataSource = listaDetallecompra;
                    DgvCompras.Columns["IDCOMPRA"].Visible = false;
                    DgvCompras.Columns["IDARTICULO"].Visible = false;
                    TotalCompra = TotalCompra - obj.PuSubtotal;
                    lblTotal.Text = TotalCompra.ToString();
                }
            }
            else
            {
                MessageBox.Show("No posee articulos para eliminar");
                                 
                this.Close();
               
            }
        }  // ELIMINAR ARTICULO DE LA GRILLA

        private void btnCargar_Click(object sender, EventArgs e)
        {
            bool existe = false;

            CompraArticulos nuevo = new CompraArticulos();

            int newidcompra = 0;

            ComprasNegocio comprasacc = new ComprasNegocio();
            newidcompra = comprasacc.obtenerId();

            int stockp;

            nuevo.Articulos = (Articulos)cbxArticulos.SelectedItem;
            nuevo.IdArticulo = nuevo.Articulos.IdArticulo;

            stockp = comprasacc.ConsultarStock(nuevo.Articulos.IdArticulo);


            if (DgvCompras.RowCount == 0)
            {

                nuevo.IdArticulo = nuevo.Articulos.IdArticulo;
                nuevo.IdCompra = newidcompra;
                nuevo.Cantidad = Convert.ToInt32(txtCantidad.Text);
                nuevo.Pu = nuevo.Articulos.PuCompra;
                nuevo.PuSubtotal = nuevo.Cantidad * nuevo.Pu;

                listaDetallecompra.Add(nuevo);

                TotalCompra = TotalCompra + nuevo.PuSubtotal;
                lblTotal.Text = TotalCompra.ToString();

                DgvCompras.DataSource = null;
                DgvCompras.DataSource = listaDetallecompra;
                DgvCompras.Columns["IDCOMPRA"].Visible = false;
                DgvCompras.Columns["IDARTICULO"].Visible = false;
            }
            else
            {
                nuevo.Articulos = (Articulos)cbxArticulos.SelectedItem;

                foreach (CompraArticulos fila in listaDetallecompra)

                {
                    if (fila.IdArticulo == nuevo.Articulos.IdArticulo)
                    {

                        stockp = comprasacc.ConsultarStock(nuevo.Articulos.IdArticulo);
                        Decimal montoanterior;
                        montoanterior = fila.PuSubtotal;

                        fila.Pu = nuevo.Articulos.PuCompra;
                        fila.Cantidad = fila.Cantidad + Convert.ToInt32(txtCantidad.Text);
                        fila.PuSubtotal = fila.Cantidad * fila.Pu;

                        TotalCompra = (TotalCompra + fila.PuSubtotal) - montoanterior;
                        lblTotal.Text = TotalCompra.ToString();


                        DgvCompras.DataSource = null;
                        DgvCompras.DataSource = listaDetallecompra;
                        DgvCompras.Columns["IDCOMPRA"].Visible = false;
                        DgvCompras.Columns["IDARTICULO"].Visible = false;

                        existe = true;

                    }


                }

                if (existe == false)
                {
                    nuevo.IdCompra = newidcompra;
                    nuevo.Articulos = (Articulos)cbxArticulos.SelectedItem;
                    nuevo.Cantidad = Convert.ToInt32(txtCantidad.Text);
                    nuevo.Pu = nuevo.Articulos.PuCompra;
                    nuevo.PuSubtotal = nuevo.Cantidad * nuevo.Pu;
                    listaDetallecompra.Add(nuevo);
                    TotalCompra = TotalCompra + nuevo.PuSubtotal;
                    lblTotal.Text = TotalCompra.ToString();

                    DgvCompras.DataSource = null;
                    DgvCompras.DataSource = listaDetallecompra;
                    DgvCompras.Columns["IDCOMPRA"].Visible = false;
                    DgvCompras.Columns["IDARTICULO"].Visible = false;
                }

            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            try
            {

                if (DgvCompras.RowCount > 0)
                {
                    // GenerarCompra 
                    ComprasNegocio compras = new ComprasNegocio();
                    Compras nuevacompra = new Compras();
                    Proveedores auxprov;

                    auxprov = (Proveedores)cbxproveedor.SelectedItem;

                    nuevacompra.IdUsuario = Login.Userlogin.idusuario;
                    nuevacompra.IdProveedor = auxprov.IdProveedor;
                    nuevacompra.Fecha = dtpFechaCompra.Value;
                    compras.Generarcompra(nuevacompra);


                    // Detalle de Venta

                    CompraArticulos artxcompra = new CompraArticulos();

                    foreach (CompraArticulos fila in listaDetallecompra)
                    {
                        compras.GenerarArtxCompra(fila);
                        compras.ActualizarStock(fila);
                    }

                    MessageBox.Show("Compra Realizada");
                    this.Close();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   
}
