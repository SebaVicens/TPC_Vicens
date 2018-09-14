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


    }
}
