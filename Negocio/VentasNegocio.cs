using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class VentasNegocio
    {
        public int obtenerId()
        {

            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SELECT TOP 1 * FROM VENTAS ORDER BY IDVENTA DESC";

            try
            {

                conexion.limpiarParametros();

                conexion.setearConsulta(consulta);

                conexion.leerConsulta();

                conexion.Lector.Read();

                int ID = conexion.Lector.GetInt32(0);
                ID = ID + 1;
                return ID;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }

        }

        public int ConsultarStock(int vaux)
        {
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "select STOCK from ARTICULOS where IDARTICULO = @IDARTICULO";

            try
            {

                conexion.limpiarParametros();
                conexion.agregarParametro("@IDARTICULO", vaux.ToString());

                conexion.setearConsulta(consulta);

                conexion.leerConsulta();

                conexion.Lector.Read();

                int ID = conexion.Lector.GetInt32(0);

                return ID;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }

        }

        public void Generarventa(Ventas vaux)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO VENTAS (FECHA,IDCLIENTE,IDUSUARIO) VALUES (@FECHA,@IDCLIENTE,@IDUSUARIO)";
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@FECHA", vaux.Fecha.ToString("dd-MM-yyyy"));
                conexion.agregarParametro("@IDCLIENTE", vaux.IdCliente.ToString());
                conexion.agregarParametro("@IDUSUARIO", vaux.IdUsuario.ToString());
                conexion.setearConsulta(consulta);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }

        }

        public void GenerarArtxVenta(VentaArticulos vaux)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO ARTICULOS_X_VENTA (IDVENTA,IDARTICULO,CANTIDAD,PU) VALUES (@IDVENTA,@IDARTICULO,@CANTIDAD,@PU)";
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@IDVENTA", vaux.IdVenta.ToString());
                conexion.agregarParametro("@IDARTICULO", vaux.IdArticulo.ToString());
                conexion.agregarParametro("@CANTIDAD", vaux.Cantidad.ToString());
                conexion.agregarParametro("@PU", vaux.Pu.ToString().Replace(",", "."));
                conexion.setearConsulta(consulta);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }

        public void ActualizarStock(VentaArticulos vaux)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "UPDATE ARTICULOS SET STOCK=STOCK-@CANTIDAD WHERE IDARTICULO=@IDARTICULO";
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@IDVENTA", vaux.IdVenta.ToString());
                conexion.agregarParametro("@IDARTICULO", vaux.IdArticulo.ToString());
                conexion.agregarParametro("@CANTIDAD", vaux.Cantidad.ToString());
                conexion.agregarParametro("@PU", vaux.Pu.ToString().Replace(",", "."));
                conexion.setearConsulta(consulta);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }

        public IList<VentasDetalle> traerPorVenta(Int32 IdVenta)
        {

            AccesoDatos conexion = new AccesoDatos();
            IList<VentasDetalle> lista = new List<VentasDetalle>();

            try
            {
                conexion.setearConsulta("SELECT VE.IDVENTA AS FACTURA,VE.FECHA, CL.APELLIDO AS CLIENTE, AR.DESCRIPCION, AXV.PU * AXV.CANTIDAD, US.APELLIDO AS VENDEDOR, AXV.CANTIDAD FROM VENTAS AS VE INNER JOIN CLIENTES AS CL ON VE.IDCLIENTE = CL.IDCLIENTE INNER JOIN USUARIOS AS US ON VE.IDUSUARIO = US.IDUSUARIO INNER JOIN ARTICULOS_X_VENTA AS AXV ON VE.IDVENTA = AXV.IDVENTA INNER JOIN ARTICULOS AS AR ON AXV.IDARTICULO = AR.IDARTICULO WHERE VE.IDVENTA = " + IdVenta.ToString());
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {

                    VentasDetalle vetVenta = new VentasDetalle();

                    vetVenta.Factura = conexion.Lector.GetInt32(0);
                    vetVenta.Fecha = conexion.Lector.GetDateTime(1);
                    vetVenta.Cliente = conexion.Lector.GetString(2);
                    vetVenta.Descripcion = conexion.Lector.GetString(3);
                    vetVenta.Total = conexion.Lector.GetDecimal(4);
                    vetVenta.Vendedor = conexion.Lector.GetString(5);
                    vetVenta.Cantidad = conexion.Lector.GetInt32(6);

                    lista.Add(vetVenta);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IList<VentasDetalle> listarVentas()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<VentasDetalle> lista = new List<VentasDetalle>();
            VentasNegocio ven = new VentasNegocio();

            try
            {
                conexion.setearConsulta("SELECT VE.IDVENTA AS FACTURA,VE.FECHA, CL.APELLIDO + ' ' + CL.NOMBRE AS CLIENTE,US.APELLIDO + ' ' + US.NOMBRE AS VENDEDOR, SUM(AXV.PU * AXV.CANTIDAD) AS TOTAL_FACTURA FROM VENTAS AS VE INNER JOIN CLIENTES AS CL ON VE.IDCLIENTE = CL.IDCLIENTE INNER JOIN USUARIOS AS US ON VE.IDUSUARIO = US.IDUSUARIO INNER JOIN ARTICULOS_X_VENTA AS AXV ON VE.IDVENTA = AXV.IDVENTA INNER JOIN ARTICULOS AS AR ON AXV.IDARTICULO = AR.IDARTICULO GROUP BY VE.IDVENTA, CL.APELLIDO, US.APELLIDO,VE.FECHA,CL.NOMBRE, US.NOMBRE ORDER BY VE.IDVENTA DESC");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    VentasDetalle venta = new VentasDetalle();

                    venta.Factura = conexion.Lector.GetInt32(0);
                    venta.Fecha = conexion.Lector.GetDateTime(1);
                    venta.Cliente = conexion.Lector.GetString(2);
                    venta.Vendedor = conexion.Lector.GetString(3);
                    venta.Total = conexion.Lector.GetDecimal(4);

                    venta.Ventadet= ven.traerPorVenta(venta.Factura);

                    lista.Add(venta);
                }

                return (lista);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
