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
                conexion.setearConsulta("SELECT IDCLIENTE, DNI, NOMBRE, APELLIDO, FNAC, CALLE, SEXO, IDLOCALIDAD, ESTADO FROM CLIENTES WHERE ESTADO = 1");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Clientes clientes = new Clientes();

                    clientes.IdCliente = conexion.Lector.GetInt32(0);
                    clientes.Dni = conexion.Lector.GetInt32(1);
                    clientes.Nombre = conexion.Lector.GetString(2);
                    clientes.Apellido = conexion.Lector.GetString(3);
                    clientes.FechaNac = conexion.Lector.GetDateTime(4);
                    clientes.Calle = conexion.Lector.GetString(5);
                    clientes.Sexo = conexion.Lector.GetString(6);
                    clientes.IdLocalidad = conexion.Lector.GetInt32(7);
                    clientes.Estado = conexion.Lector.GetBoolean(8);
                    

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

        public void AgregarCliente (Clientes cli)
        {
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "INSERT INTO CLIENTES ( DNI, NOMBRE, APELLIDO, FNAC, CALLE, SEXO, IDLOCALIDAD, ESTADO) VALUES (@DNI, @NOMBRE, @APELLIDO, @FNAC, @CALLE, @SEXO, @IDLOCALIDAD, @ESTADO)";

            try
            {

                conexion.limpiarParametros();

                conexion.agregarParametro("@DNI", cli.Dni);
                conexion.agregarParametro("@NOMBRE", cli.Nombre);
                conexion.agregarParametro("@APELLIDO", cli.Apellido);
                conexion.agregarParametro("@FNAC", cli.FechaNac.ToString("dd-MM-yyyy"));
                conexion.agregarParametro("@CALLE", cli.Calle);
                conexion.agregarParametro("@SEXO", cli.Sexo);
                conexion.agregarParametro("@IDLOCALIDAD", cli.IdLocalidad);
                conexion.agregarParametro("@ESTADO", cli.Estado);

                conexion.setearConsulta(consulta);

                conexion.ejecutarAccion();

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarCliente(Clientes cli)
        {

            AccesoDatos conexion = new AccesoDatos();

            string consulta = "UPDATE CLIENTES SET DNI=@DNI, NOMBRE=@NOMBRE, APELLIDO=@APELLIDO, FNAC=@FNAC, CALLE=@CALLE, SEXO=@SEXO, IDLOCALIDAD=@IDLOCALIDAD, @ESTADO=ESTADO WHERE IDCLIENTE = @IDCLIENTE";

            try
            {
                conexion.limpiarParametros();

                conexion.agregarParametro("@IDCLIENTE", cli.IdCliente);
                conexion.agregarParametro("@DNI", cli.Dni);
                conexion.agregarParametro("@NOMBRE", cli.Nombre);
                conexion.agregarParametro("@APELLIDO", cli.Apellido);
                conexion.agregarParametro("@FNAC", cli.FechaNac);
                conexion.agregarParametro("@CALLE", cli.Calle);
                conexion.agregarParametro("@SEXO", cli.Sexo);
                conexion.agregarParametro("@IDLOCALIDAD", cli.IdLocalidad);
                conexion.agregarParametro("@ESTADO", cli.Estado);             


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
