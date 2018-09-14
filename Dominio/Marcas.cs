using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marcas
    {
        public int IdMarca { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        public Marcas()
        {
        }

        public Marcas(string desc)
        {
            Descripcion = desc;
        }

        public override string ToString()
        {
            //return descripcion + " - " + Convert.ToString(idmarca);
            return Descripcion;
        }
    }
}
