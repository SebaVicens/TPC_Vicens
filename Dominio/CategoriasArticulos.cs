using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class CategoriasArticulos
    {
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        public CategoriasArticulos()
        {
        }

        public CategoriasArticulos(int id, string desc)
        {
            IdCategoria = id;
            Descripcion = desc;
        }

        public override string ToString()
        {
            //return descripcion + " - " + Convert.ToString(idmarca);
            return Descripcion;
        }
    }
}
