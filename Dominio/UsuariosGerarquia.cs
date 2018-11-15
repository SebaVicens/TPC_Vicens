using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class UsuariosGerarquia
    {
        public int idgerarquia { get; set; }
        public string descripcion { get; set; }

        public UsuariosGerarquia()
        {
        }

        public UsuariosGerarquia(int id, string desc)
        {
            idgerarquia = id;
            descripcion = desc;
        }

        public override string ToString()
        {
          
            return descripcion;
        }

    }
}
