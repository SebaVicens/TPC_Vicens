using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ClientesNegocio
    {
        public IList<Clientes> listar()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Clientes> lista = new List<Clientes>();

            try
            {
                conexion.setearConsulta("SELECT DNI, NOMBRE, APELLIDO, FNAC, CALLE, IDLOCALIDAD, SEXO FROM CLIENTES WHERE ESTADO = 1");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Clientes clientes = new Clientes();

                    clientes.Dni = conexion.Lector.GetInt32(0);
                    clientes.Nombre = conexion.Lector.GetString(1);
                    clientes.Apellido = conexion.Lector.GetString(2);
                    clientes.FechaNac = conexion.Lector.GetDateTime(3);
                    clientes.Calle = conexion.Lector.GetString(4);
                    clientes.IdLocalidad = conexion.Lector.GetInt32(5);
                    clientes.Sexo = conexion.Lector.GetString(6);

                    lista.Add(clientes);

                }

                return lista;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }

        }

    }
}
