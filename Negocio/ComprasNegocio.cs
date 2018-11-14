using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;

namespace Negocio
{
    public class ComprasNegocio
    {
        public int obtenerId()
        {

            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SELECT TOP 1 * FROM COMPRAS ORDER BY IDCOMPRA DESC";

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

        public void Generarcompra(Compras vaux)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO COMPRAS (FECHA,IDPROVEEDOR,IDUSUARIO) VALUES (@FECHA,@IDPROVEEDOR,@IDUSUARIO)";
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@FECHA", vaux.Fecha.ToString("dd-MM-yyyy"));
                conexion.agregarParametro("@IDPROVEEDOR", vaux.IdProveedor.ToString());
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

        public void GenerarArtxCompra(CompraArticulos vaux)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO ARTICULOS_X_COMPRA (IDCOMPRA,IDARTICULO,CANTIDAD,PU) VALUES (@IDCOMPRA,@IDARTICULO,@CANTIDAD,@PU)";
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@IDCOMPRA", vaux.IdCompra.ToString());
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

        public void ActualizarStock(CompraArticulos vaux)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "UPDATE ARTICULOS SET STOCK=STOCK-@CANTIDAD WHERE IDARTICULO=@IDARTICULO";
            try
            {
                conexion.limpiarParametros();
                conexion.agregarParametro("@IDCOMPRA", vaux.IdCompra.ToString());
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

    }
}
