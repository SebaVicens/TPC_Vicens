using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector 
        {
            get { return lector; }
        }

        public AccesoDatos()
        {
            conexion = new SqlConnection("data source=LAPTOP-20LSGO9A\\SQLEXPRESS; initial catalog=TPC_VICENS_BD; integrated security=sspi");
            comando = new SqlCommand();
            comando.Connection = conexion;
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void leerConsulta()
        {
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }


        public void insertar()
        {
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void limpiarParametros()
        {
            comando.Parameters.Clear();
        }

        public void agregarParametro(string nombre, Object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void ejecutarAccion()
        {
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
     
        /////////////////     

        public SqlCommand Comando
        {
            get { return comando; }
        }

        public void abrirConexion()
        {
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarLectura()
        {
            try
            {
                this.comando.Connection = this.conexion;
                this.lector = this.comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void setearParametroConValor(string variable, object valor)
        {
            try
            {
                this.comando.Parameters.AddWithValue(variable, valor);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
