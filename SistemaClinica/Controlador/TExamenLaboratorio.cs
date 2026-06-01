using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaClinica.Entidades;

namespace SistemaClinica.Controlador
{
    public static class TExamenLaboratorio
    {
        public static List<ExamenLaboratorio> Lista = new List<ExamenLaboratorio>();
        public static void Insertar(ExamenLaboratorio e) => Lista.Add(e);
        public static int Buscar(string codigo) => Lista.FindIndex(x => x.Codigo == codigo);
        public static void Modificar(ExamenLaboratorio e) { int pos = Buscar(e.Codigo); if (pos >= 0) Lista[pos] = e; }
        public static void Eliminar(string codigo) { int pos = Buscar(codigo); if (pos >= 0) Lista.RemoveAt(pos); }
    }
}
