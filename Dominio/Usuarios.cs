using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuarios : Persona
    {
        public int idusuario { get; set; }
        public string password { get; set; }
        public UsuariosGerarquia gerarquia { get; set; }
        public int idlocalidad { get; set; }
        public string sexo { get; set; }
        public bool Estado { get; set; }
    }
}
