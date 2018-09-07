using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Proveedores
    {
        public int IdProveedor { get; set; }
        public string Cuit { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public int IdLocalidad { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }


        public Proveedores()
        {
        }

        public Proveedores(int id, string desc)
        {
            IdProveedor = id;
            Descripcion = desc;
        }


        public override string ToString()
        {
            //return descripcion + " - " + Convert.ToString(idproveedor);
            return Descripcion;
        }
    }
}
