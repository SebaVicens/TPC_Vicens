using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriasNegocio
    {
        public IList<CategoriasArticulos> listar()
        {

            AccesoDatos conexion = new AccesoDatos();
            IList<CategoriasArticulos> lista = new List<CategoriasArticulos>();

            try
            {
                conexion.setearConsulta("SELECT IDCATEGORIA, CATEGORIA FROM CATEGORIAS WHERE ESTADO = 1");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    CategoriasArticulos cat = new CategoriasArticulos();

                    cat.IdCategoria = conexion.Lector.GetInt32(0);
                    cat.Descripcion = conexion.Lector.GetString(1);

                    lista.Add(cat);
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

        public void agregarcategoria(CategoriasArticulos aux)
        {

            AccesoDatos conexion = new AccesoDatos();

            string consulta = "INSERT INTO CATEGORIAS (CATEGORIA,ESTADO) VALUES (@CATEGORIA,@ESTADO)";

            try
            {

                conexion.limpiarParametros();

                conexion.agregarParametro("@CATEGORIA", aux.Descripcion);
                conexion.agregarParametro("@ESTADO", aux.Estado);

                //seteo la consulta
                conexion.setearConsulta(consulta);

                //ejecuto la acción.
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

        public void agregarcategoriaporarticulo(CategoriaPorArticulos aux)
        {

            AccesoDatos conexion = new AccesoDatos();

            string consulta = "INSERT INTO CATEGORIAS_X_ARTICULO (IDARTICULO, IDCATEGORIA) VALUES (@IDARTICULO, @IDCATEGORIA)";

            try
            {

                conexion.limpiarParametros();

                conexion.agregarParametro("@IDARTICULO", aux.IdArticulo);
                conexion.agregarParametro("@IDCATEGORIA", aux.IdCategoria);


                //seteo la consulta
                conexion.setearConsulta(consulta);

                //ejecuto la acción.
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
