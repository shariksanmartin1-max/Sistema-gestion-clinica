using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaClinica.Entidades;

namespace SistemaClinica.Controlador
{
    public static class TTratamiento
    {
        public static List<Tratamiento> Lista = new List<Tratamiento>();
        public static void Insertar(Tratamiento t) => Lista.Add(t);
        public static int Buscar(string codigo) => Lista.FindIndex(x => x.Codigo == codigo);
        public static void Modificar(Tratamiento t) { int pos = Buscar(t.Codigo); if (pos >= 0) Lista[pos] = t; }
        public static void Eliminar(string codigo) { int pos = Buscar(codigo); if (pos >= 0) Lista.RemoveAt(pos); }
    }
}
