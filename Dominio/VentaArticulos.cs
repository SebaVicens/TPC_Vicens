using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class VentaArticulos
    {
        public int IdVenta { get; set; }
        public int IdArticulo { get; set; }
        public Articulos Articulos { get; set; }
        public int Cantidad { get; set; }
        public decimal Pu { get; set; }
        public decimal PuSubtotal { get; set; }
    }
}
