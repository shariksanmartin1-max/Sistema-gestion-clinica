using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinica.Entidades
{
    public class Receta
    {
        public string Codigo { get; set; }
        public string Paciente { get; set; }
        public string Medico { get; set; }
    }
}
