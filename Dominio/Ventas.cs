using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ventas
    {
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }

        internal Articulos Articulos
        {
            get => default(Articulos);
            set
            {
            }
        }
    }
}
