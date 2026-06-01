using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaClinica.Entidades;

namespace SistemaClinica.Controlador
{
    public static class TServicioMedico
    {
        public static List<ServicioMedico> Lista = new List<ServicioMedico>();
        public static void Insertar(ServicioMedico s) => Lista.Add(s);
        public static int Buscar(string codigo) => Lista.FindIndex(x => x.Codigo == codigo);
        public static void Modificar(ServicioMedico s) { int pos = Buscar(s.Codigo); if (pos >= 0) Lista[pos] = s; }
        public static void Eliminar(string codigo) { int pos = Buscar(codigo); if (pos >= 0) Lista.RemoveAt(pos); }
    }
}
