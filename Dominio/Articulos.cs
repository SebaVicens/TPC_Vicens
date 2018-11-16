using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulos
    {
        public int IdArticulo { get; set; }
        public string Descripcion { get; set; }
        public Marcas Marca { get; set; }
        public Proveedores Proveedores { get; set; }
        public string Origen { get; set; }
        public int Stock { get; set; }
        public decimal Pu { get; set; }
        public decimal PuCompra { get; set; }
        public bool Estado { get; set; }

        public Articulos()
        {
        }

        public Articulos(int id, string desc)
        {
            IdArticulo = id;
            Descripcion = desc;
        }


        public override string ToString()
        {
            return Descripcion;
        }
    }
}
