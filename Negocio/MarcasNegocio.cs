using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcasNegocio
    {

        public IList<Marcas> listar()
        {

            AccesoDatos conexion = new AccesoDatos();
            IList<Marcas> lista = new List<Marcas>();

            try
            {
                conexion.setearConsulta("SELECT IDMARCA, DESCRIPCION FROM MARCAS WHERE ESTADO = 1");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Marcas marc = new Marcas();

                    marc.IdMarca = conexion.Lector.GetInt32(0);
                    marc.Descripcion = conexion.Lector.GetString(1);

                    lista.Add(marc);
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


        public void AgregarMarca(Marcas marc)
        {
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "INSERT INTO MARCAS (IDMARCA, DESCRIPCION, ESTADO) VALUES (@IDMARCA, @DESCRIPCION, @ESTADO)";

            try
            {

                conexion.limpiarParametros();

                conexion.agregarParametro("@IDMARCA", marc.IdMarca);
                conexion.agregarParametro("@DESCRIPCION", marc.Descripcion);
                conexion.agregarParametro("@ESTADO", marc.Estado);

                conexion.setearConsulta(consulta);

                conexion.ejecutarAccion();

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
