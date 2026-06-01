using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaClinica.Entidades;

namespace SistemaClinica.Controlador
{
    public static class TTrasladoPaciente
    {
        public static List<TrasladoPaciente> Lista = new List<TrasladoPaciente>();
        public static void Insertar(TrasladoPaciente t) => Lista.Add(t);
        public static int Buscar(string codigo) => Lista.FindIndex(x => x.Codigo == codigo);
        public static void Modificar(TrasladoPaciente t) { int pos = Buscar(t.Codigo); if (pos >= 0) Lista[pos] = t; }
        public static void Eliminar(string codigo) { int pos = Buscar(codigo); if (pos >= 0) Lista.RemoveAt(pos); }
    }
}
