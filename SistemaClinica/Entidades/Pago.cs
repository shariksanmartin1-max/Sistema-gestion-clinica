using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinica.Entidades
{
    public class Pago
    {
        public string Codigo { get; set; }
        public decimal Valor { get; set; }
        public DateTime Fecha { get; set; }
    }
}
