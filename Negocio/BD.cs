using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Negocio
{
    public class BD
    {
        public static DataSet Ejecutar(string url)
        {
            SqlConnection conexion = new SqlConnection("data source=LAPTOP-20LSGO9A\\SQLEXPRESS; initial catalog=TPC_VICENS_BD; integrated security=sspi");
            try
            {
                conexion.Open();
                DataSet DS = new DataSet();
                SqlDataAdapter DP = new SqlDataAdapter(url, conexion);
                DP.Fill(DS);
                conexion.Close();
                return DS;
            }
            catch (Exception ex)
            {
                //si hay alguna excepción la lanzo al nivel superior, a quien me llamó.
                throw ex;
            }
            finally
            {
                //por aquí si o si, falle algo o no, cierro la conexión.
                conexion.Close();
                conexion = null;
            }

        }
    }
}
