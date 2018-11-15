using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class UsuariosNegocio
    {

        public IList<Usuarios> listar()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Usuarios> lista = new List<Usuarios>();

            try
            {
                conexion.setearConsulta("SELECT US.IDUSUARIO,US.DNI,US.NOMBRE,US.APELLIDO,US.FNAC,US.CALLE,US.SEXO,US.IDLOCALIDAD,US.PASSWORD,US.GERARQUIA,GE.DESCRIPCION, US.ESTADO FROM USUARIOS AS US INNER JOIN GERARQUIAS AS GE ON US.GERARQUIA=GE.IDGERARQUIA WHERE US.ESTADO = 1");
                conexion.leerConsulta();


                while (conexion.Lector.Read())
                {
                    Usuarios aux = new Usuarios();

                    aux.idusuario = conexion.Lector.GetInt32(0);
                    aux.Dni = conexion.Lector.GetInt32(1);
                    aux.Nombre = conexion.Lector.GetString(2);
                    aux.Apellido = conexion.Lector.GetString(3);
                    aux.FechaNac = conexion.Lector.GetDateTime(4);
                    aux.Direccion = conexion.Lector.GetString(5);
                    aux.sexo = conexion.Lector.GetString(6);
                    aux.idlocalidad = conexion.Lector.GetInt32(7);
                    aux.password = conexion.Lector.GetString(8);
                    aux.gerarquia = new UsuariosGerarquia(conexion.Lector.GetInt32(9), conexion.Lector.GetString(10));
                    aux.Estado = conexion.Lector.GetBoolean(11);


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


        public void eliminar(int idaux)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                string consulta = "UPDATE USUARIOS SET ESTADO = 0 WHERE IDUSUARIO = " + idaux;

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


        public IList<UsuariosGerarquia> listargerarquias()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<UsuariosGerarquia> lista = new List<UsuariosGerarquia>();

            try
            {
                conexion.setearConsulta("SELECT IDGERARQUIA , DESCRIPCION FROM GERARQUIAS");
                conexion.leerConsulta();


                while (conexion.Lector.Read())
                {
                    UsuariosGerarquia aux = new UsuariosGerarquia();

                    aux.idgerarquia = conexion.Lector.GetInt32(0);
                    aux.descripcion = conexion.Lector.GetString(1);

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


        public void modificar(Usuarios aux)
        {
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "UPDATE USUARIOS SET DNI=@DNI, NOMBRE=@NOMBRE, APELLIDO=@APELLIDO, FNAC=@FNAC, CALLE=@CALLE, SEXO=@SEXO,IDLOCALIDAD=@IDLOCALIDAD, PASSWORD=@PASSWORD, GERARQUIA=@GERARQUIA, ESTADO=@ESTADO WHERE IDUSUARIO=@IDUSUARIO";
            try
            {

                conexion.limpiarParametros();
                conexion.agregarParametro("@IDUSUARIO", aux.idusuario.ToString());
                conexion.agregarParametro("@DNI", aux.Dni.ToString());
                conexion.agregarParametro("@NOMBRE", aux.Nombre);
                conexion.agregarParametro("@APELLIDO", aux.Apellido);
                conexion.agregarParametro("@FNAC", aux.FechaNac.ToString("dd-MM-yyyy"));
                conexion.agregarParametro("@CALLE", aux.Direccion);
                conexion.agregarParametro("@SEXO", aux.sexo);
                conexion.agregarParametro("@IDLOCALIDAD", aux.idlocalidad.ToString());
                conexion.agregarParametro("@PASSWORD", aux.password.ToString());
                conexion.agregarParametro("@GERARQUIA", aux.gerarquia.idgerarquia.ToString());
                conexion.agregarParametro("@ESTADO", aux.Estado);

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


        public void agregar(Usuarios aux)
        {
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "INSERT INTO USUARIOS (DNI, NOMBRE, APELLIDO, FNAC, CALLE, SEXO,IDLOCALIDAD, PASSWORD, GERARQUIA, ESTADO) VALUES (@DNI, @NOMBRE, @APELLIDO, @FNAC, @CALLE, @SEXO, @IDLOCALIDAD, @PASSWORD, @GERARQUIA, @ESTADO)";

            try
            {

                conexion.limpiarParametros();
                conexion.agregarParametro("@IDUSUARIO", aux.idusuario.ToString());
                conexion.agregarParametro("@DNI", aux.Dni.ToString());
                conexion.agregarParametro("@NOMBRE", aux.Nombre);
                conexion.agregarParametro("@APELLIDO", aux.Apellido);
                conexion.agregarParametro("@FNAC", aux.FechaNac.ToString("dd-MM-yyyy"));
                conexion.agregarParametro("@CALLE", aux.Direccion);
                conexion.agregarParametro("@SEXO", aux.sexo);
                conexion.agregarParametro("@IDLOCALIDAD", aux.idlocalidad.ToString());
                conexion.agregarParametro("@PASSWORD", aux.password.ToString());
                conexion.agregarParametro("@GERARQUIA", aux.gerarquia.idgerarquia.ToString());
                conexion.agregarParametro("@ESTADO", aux.Estado.ToString());


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

