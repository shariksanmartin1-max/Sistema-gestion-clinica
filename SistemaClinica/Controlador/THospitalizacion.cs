using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaClinica.Entidades;

namespace SistemaClinica.Controlador
{
    public static class THospitalizacion
    {
        public static List<Hospitalizacion> Lista = new List<Hospitalizacion>();
        public static void Insertar(Hospitalizacion h) => Lista.Add(h);
        public static int Buscar(string codigo) => Lista.FindIndex(x => x.Codigo == codigo);
        public static void Modificar(Hospitalizacion h) { int pos = Buscar(h.Codigo); if (pos >= 0) Lista[pos] = h; }
        public static void Eliminar(string codigo) { int pos = Buscar(codigo); if (pos >= 0) Lista.RemoveAt(pos); }
    }
}
