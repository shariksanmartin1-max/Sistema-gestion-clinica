using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinica.Entidades
{
    public class ExamenLaboratorio
    {
        public string Codigo { get; set; }
        public string Paciente { get; set; }
        public string TipoExamen { get; set; }
    }
}
