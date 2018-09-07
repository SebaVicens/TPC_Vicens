using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Clientes : Persona
    {
        public int IdCliente { get; set; }
        public string Sexo { get; set; }
        public int IdLocalidad { get; set; }
    }
}
