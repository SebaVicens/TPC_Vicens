using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ProveedoresNegocio
    {

        public IList<Proveedores> listar()
        {

            AccesoDatos conexion = new AccesoDatos();
            IList<Proveedores> lista = new List<Proveedores>();


            try
            {
                conexion.setearConsulta("SELECT IDPROVEEDOR, CUIT, DIRECCION, IDLOCALIDAD, TELEFONO, MAIL FROM PROVEEDORES WHERE ESTADO = 1");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Proveedores prov = new Proveedores();

                    prov.IdProveedor = conexion.Lector.GetInt32(0);
                    prov.Cuit = conexion.Lector.GetString(1);
                    prov.Direccion = conexion.Lector.GetString(2);
                    prov.IdLocalidad = conexion.Lector.GetInt32(3);
                    prov.Telefono = conexion.Lector.GetString(4);
                    prov.Mail = conexion.Lector.GetString(5);

                    lista.Add(prov);            

                }

                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IList<Proveedores> listar2()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Proveedores> lista = new List<Proveedores>();

            try
            {
                conexion.setearConsulta("SELECT IDPROVEEDOR, DESCRIPCION FROM PROVEEDORES WHERE ESTADO = 1");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Proveedores prov = new Proveedores();

                    prov.IdProveedor = conexion.Lector.GetInt32(0);
                    prov.Descripcion = conexion.Lector.GetString(1);

                    lista.Add(prov);
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
