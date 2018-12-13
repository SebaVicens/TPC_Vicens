using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class VentasDetalle
    {
        public int Factura { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Vendedor { get; set; }
        public string Descripcion { get; set; }
        public decimal Total { get; set; }
        public int Cantidad { get; set; }
        public IList<VentasDetalle> Ventadet { set; get; }
    }
}
