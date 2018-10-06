using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class LocalidadNegocio
    {
        public IList<Localidades> listar()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Localidades> lista = new List<Localidades>();

            try
            {
                conexion.setearConsulta("SELECT IDLOCALIDAD, NOMBRE, IDPROVINCIA FROM LOCALIDADES");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {

                    Localidades loc = new Localidades();

                    loc.IdLocalidad = conexion.Lector.GetInt32(0);
                    loc.Descripcion = conexion.Lector.GetString(1);
                    loc.IdProvincia = conexion.Lector.GetInt32(2);

                    lista.Add(loc);

                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public IList<Provincias> listarprovincias()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Provincias> lista = new List<Provincias>();

            try
            {

                conexion.setearConsulta("SELECT IDPROVINCIA,NOMBRE,IDPAIS FROM PROVINCIAS");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Provincias aux = new Provincias();

                    aux.IdProvincia = conexion.Lector.GetInt32(0);
                    aux.Descripcion = conexion.Lector.GetString(1);
                    aux.IdPais = conexion.Lector.GetInt32(2);

                    lista.Add(aux);
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public void agregarlocalidad(Localidades aux)
        {

            AccesoDatos conexion = new AccesoDatos();

            string consulta = "INSERT INTO LOCALIDADES (IDLOCALIDAD, NOMBRE,IDPROVINCIA) VALUES (@IDLOCALIDAD, @NOMBRE,@IDPROVINCIA)";

            try
            {

                conexion.limpiarParametros();

                conexion.agregarParametro("@IDLOCALIDAD", aux.IdLocalidad);
                conexion.agregarParametro("@NOMBRE", aux.Descripcion);
                conexion.agregarParametro("@IDPROVINCIA", aux.IdProvincia);

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
