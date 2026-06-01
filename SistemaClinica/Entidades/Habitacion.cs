using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinica.Entidades
{
    public class Habitacion
    {
        public string Codigo { get; set; }
        public string Tipo { get; set; }
        public bool Disponible { get; set; }
    }
}
