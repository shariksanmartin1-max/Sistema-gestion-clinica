using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinica.Entidades
{
    public class Usuario
    {
        public string UsuarioLogin { get; set; }
        public string Clave { get; set; }
        public string Rol { get; set; }
    }
}
