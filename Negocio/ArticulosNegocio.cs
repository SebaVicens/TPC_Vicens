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
                conexion.setearConsulta("SELECT A.IDARTICULO, A.DESCRIPCION, A.IDMARCA, MA.DESCRIPCION, A.IDPROVEEDOR, P.DESCRIPCION, A.ORIGEN, A.STOCK, A.PU, A.PUCOMPRA, A.ESTADO FROM ARTICULOS AS A INNER JOIN MARCAS AS MA ON MA.IDMARCA = A.IDMARCA INNER JOIN PROVEEDORES AS P ON P.IDPROVEEDOR = A.IDPROVEEDOR WHERE A.ESTADO = 1");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {

                    Articulos art = new Articulos();

                    art.IdArticulo = conexion.Lector.GetInt32(0);
                    art.Descripcion = conexion.Lector.GetString(1);
                    art.Marca = new Marcas(conexion.Lector.GetInt32(2), conexion.Lector.GetString(3));
                    art.Proveedores = new Proveedores(conexion.Lector.GetInt32(4), conexion.Lector.GetString(5));
                    art.Origen = conexion.Lector.GetString(6);
                    art.Stock = conexion.Lector.GetInt32(7);
                    art.Pu = conexion.Lector.GetDecimal(8);
                    art.PuCompra = conexion.Lector.GetDecimal(9);
                    art.Estado = conexion.Lector.GetBoolean(10);

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

        public void AgregarArticulo(Articulos art)
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

        public void ModificarArticulo(Articulos art)
        {

            AccesoDatos conexion = new AccesoDatos();

            string consulta = "UPDATE ARTICULOS SET DESCRIPCION = @DESCRIPCION, IDMARCA = @IDMARCA, IDPROVEEDOR = @IDPROVEEDOR, ORIGEN = @ORIGEN, STOCK = @STOCK, PU = @PU, PUCOMPRA = @PUCOMPRA, @ESTADO = ESTADO WHERE IDARTICULO = @IDARTICULO";

            try
            {
                conexion.limpiarParametros();

                conexion.agregarParametro("@IDARTICULO", art.IdArticulo);
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

        public void eliminar(int IdArt)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                string consulta = "UPDATE ARTICULOS SET ESTADO = 0 WHERE IDARTICULO = " + IdArt;

                conexion.setearConsulta(consulta);
                conexion.insertar();
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
        public IList<Articulos> listarxprov(Proveedores auxprov)
        {
            IList<Articulos> lista = new List<Articulos>();
            AccesoDatos conexion = new AccesoDatos();

            try
            {
                conexion.limpiarParametros();
                conexion.setearConsulta("SELECT AR.IDARTICULO, AR.DESCRIPCION, AR.IDMARCA, MA.DESCRIPCION, AR.IDPROVEEDOR, AR.ORIGEN, AR.STOCK, AR.PU, AR.PUCOMPRA,PRO.DESCRIPCION FROM ARTICULOS AS AR INNER JOIN MARCAS AS MA ON AR.IDMARCA = MA.IDMARCA INNER JOIN PROVEEDORES AS PRO ON AR.IDPROVEEDOR=PRO.IDPROVEEDOR WHERE AR.IDPROVEEDOR = @IDPROVEEDOR");
                conexion.agregarParametro("@IDPROVEEDOR", auxprov.IdProveedor.ToString());
         
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Articulos aux = new Articulos();

                    aux.IdArticulo = conexion.Lector.GetInt32(0);
                    aux.Descripcion = conexion.Lector.GetString(1);

                    aux.Marca = new Marcas(conexion.Lector.GetInt32(2), conexion.Lector.GetString(3));
                    aux.Proveedores = new Proveedores(conexion.Lector.GetInt32(4), conexion.Lector.GetString(9));
                    aux.Origen = conexion.Lector.GetString(5);
                    aux.Stock = conexion.Lector.GetInt32(6);
                    aux.Pu = conexion.Lector.GetDecimal(7);
                    aux.PuCompra = conexion.Lector.GetDecimal(8);

                  
                    lista.Add(aux);
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

    }
}
