using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaClinica.Entidades;

namespace SistemaClinica.Controlador
{
    public static class TResultadoLaboratorio
    {
        public static List<ResultadoLaboratorio> Lista = new List<ResultadoLaboratorio>();
        public static void Insertar(ResultadoLaboratorio r) => Lista.Add(r);
        public static int Buscar(string codigo) => Lista.FindIndex(x => x.Codigo == codigo);
        public static void Modificar(ResultadoLaboratorio r) { int pos = Buscar(r.Codigo); if (pos >= 0) Lista[pos] = r; }
        public static void Eliminar(string codigo) { int pos = Buscar(codigo); if (pos >= 0) Lista.RemoveAt(pos); }
    }
}
