using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinica.Entidades
{
    public class Cita
    {
        public string Codigo { get; set; }
        public string CedulaPaciente { get; set; }
        public string CodigoMedico { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
    }
}
