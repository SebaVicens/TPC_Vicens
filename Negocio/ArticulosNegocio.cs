using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticulosNegocio
    {
        public IList<Articulos> listar()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Articulos> lista = new List<Articulos>();

            try
            {
                conexion.setearConsulta("SELECT A.DESCRIPCION, M.DESCRIPCION, A.ORIGEN, A.STOCK, A.PU FROM ARTICULOS AS A INNER JOIN MARCAS AS M ON M.IDMARCA = A.IDMARCA WHERE A.ESTADO = 1");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {

                    Articulos art = new Articulos();

                    art.Descripcion = conexion.Lector.GetString(0);
                    art.Marca = new Marcas(conexion.Lector.GetString(1));
                    art.Origen = conexion.Lector.GetString(2);
                    art.Stock = conexion.Lector.GetInt32(3);
                    art.Pu = conexion.Lector.GetDecimal(4);

                    lista.Add(art);
                }

                return lista;

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

        public void AgregarArticulo (Articulos art)
        {

            AccesoDatos conexion = new AccesoDatos();

            string consulta = "INSERT INTO ARTICULOS (DESCRIPCION, IDMARCA, IDPROVEEDOR, ORIGEN, STOCK, PU, PUCOMPRA, ESTADO) VALUES (@DESCRIPCION, @IDMARCA, @IDPROVEEDOR, @ORIGEN, @STOCK, @PU, @PUCOMPRA, @ESTADO)";

            try
            {
                conexion.limpiarParametros();

                conexion.agregarParametro("@DESCRIPCION", art.Descripcion);
                conexion.agregarParametro("@IDMARCA", art.Marca.IdMarca);
                conexion.agregarParametro("@IDPROVEEDOR", art.Proveedores.IdProveedor);
                conexion.agregarParametro("@ORIGEN", art.Origen);
                conexion.agregarParametro("@STOCK", art.Stock);
                conexion.agregarParametro("@PU", art.Pu);
                conexion.agregarParametro("@PUCOMPRA", art.PuCompra);
                conexion.agregarParametro("@ESTADO", art.Estado);


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
