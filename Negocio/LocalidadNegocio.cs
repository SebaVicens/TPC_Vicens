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

                    loc.idlocalidad = conexion.Lector.GetInt32(0);
                    loc.descripcion = conexion.Lector.GetString(1);
                    loc.idprovincia = conexion.Lector.GetInt32(2);

                    lista.Add(loc);

                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        } 

    }
}
