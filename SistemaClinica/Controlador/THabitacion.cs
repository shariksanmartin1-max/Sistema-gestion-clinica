using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaClinica.Entidades;

namespace SistemaClinica.Controlador
{
    public static class THabitacion
    {
        public static List<Habitacion> Lista = new List<Habitacion>();
        public static void Insertar(Habitacion h) => Lista.Add(h);
        public static int Buscar(string codigo) => Lista.FindIndex(x => x.Codigo == codigo);
        public static void Modificar(Habitacion h) { int pos = Buscar(h.Codigo); if (pos >= 0) Lista[pos] = h; }
        public static void Eliminar(string codigo) { int pos = Buscar(codigo); if (pos >= 0) Lista.RemoveAt(pos); }
    }
}
