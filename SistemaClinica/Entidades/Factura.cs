using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinica.Entidades
{
    public class Factura
    {
        public string Numero { get; set; }
        public string Paciente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
    }
}
