using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaClinica.Entidades;

namespace SistemaClinica.Controlador
{
    public static class TEspecialidad
    {
        public static List<Especialidad> Lista = new List<Especialidad>();
        public static void Insertar(Especialidad e) => Lista.Add(e);
        public static int Buscar(string codigo) => Lista.FindIndex(x => x.Codigo == codigo);
        public static void Modificar(Especialidad e) { int pos = Buscar(e.Codigo); if (pos >= 0) Lista[pos] = e; }
        public static void Eliminar(string codigo) { int pos = Buscar(codigo); if (pos >= 0) Lista.RemoveAt(pos); }
    }
}
