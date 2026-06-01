using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinica.Entidades
{
    public class DetalleFactura
    {
        public string Codigo { get; set; }
        public string Servicio { get; set; }
        public decimal Valor { get; set; }
    }
}
