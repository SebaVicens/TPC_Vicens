﻿using System;
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
                conexion.setearConsulta("SELECT IDPROVEEDOR, CUIT, DESCRIPCION, DIRECCION, IDLOCALIDAD, TELEFONO, MAIL, ESTADO FROM PROVEEDORES WHERE ESTADO = 1");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Proveedores prov = new Proveedores();

                    prov.IdProveedor = conexion.Lector.GetInt32(0);
                    prov.Cuit = conexion.Lector.GetString(1);
                    prov.Descripcion = conexion.Lector.GetString(2);
                    prov.Direccion = conexion.Lector.GetString(3);
                    prov.IdLocalidad = conexion.Lector.GetInt32(4);
                    prov.Telefono = conexion.Lector.GetString(5);
                    prov.Mail = conexion.Lector.GetString(6);
                    prov.Estado = conexion.Lector.GetBoolean(7);

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

        public void AgregarProveedor(Proveedores prov)
        {
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "INSERT INTO PROVEEDORES ( CUIT, DESCRIPCION, DIRECCION, IDLOCALIDAD, TELEFONO, MAIL, ESTADO) VALUES (@CUIT, @DESCRIPCION, @DIRECCION, @IDLOCALIDAD, @TELEFONO, @MAIL, @ESTADO)";

            try
            {

                conexion.limpiarParametros();

                conexion.agregarParametro("@CUIT", prov.Cuit);
                conexion.agregarParametro("@DESCRIPCION", prov.Descripcion);
                conexion.agregarParametro("@DIRECCION", prov.Direccion);
                conexion.agregarParametro("@IDLOCALIDAD", prov.IdLocalidad);
                conexion.agregarParametro("@TELEFONO", prov.Telefono);
                conexion.agregarParametro("@MAIL", prov.Mail);
                conexion.agregarParametro("@ESTADO", prov.Estado);

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
