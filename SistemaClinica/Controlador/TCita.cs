using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaClinica.Entidades;

namespace SistemaClinica.Controlador
{
    public static class TCita
    {
        public static List<Cita> Lista = new List<Cita>();
        public static void Insertar(Cita c) => Lista.Add(c);
        public static int Buscar(string codigo) => Lista.FindIndex(x => x.Codigo == codigo);
        public static void Modificar(Cita c) { int pos = Buscar(c.Codigo); if (pos >= 0) Lista[pos] = c; }
        public static void Eliminar(string codigo) { int pos = Buscar(codigo); if (pos >= 0) Lista.RemoveAt(pos); }
    }
}
