using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinica.Entidades
{
    public class Inventario
    {
        public string Codigo { get; set; }
        public string Medicamento { get; set; }
        public int Existencia { get; set; }
    }
}
