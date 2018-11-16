using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
     public class CategoriaPorArticulos
    {
        public int IdCategoria { get; set; }
        public int IdArticulo { get; set; }
        public bool Estado { get; set; }

        private CategoriasArticulos categoriaArticulos;
        public CategoriasArticulos CategoriaArticulos
        {
            set
            {
                categoriaArticulos = value;
                IdCategoria = categoriaArticulos.IdCategoria;
            }
            get { return categoriaArticulos; }
        }

        private Articulos articulos;
        public Articulos Articulos
        {
            set
            {
                articulos = value;
                IdArticulo = articulos.IdArticulo;
            }
            get { return articulos; }
        }

    }
}
