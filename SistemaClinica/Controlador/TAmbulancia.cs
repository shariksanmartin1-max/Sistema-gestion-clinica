using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaClinica.Entidades;

namespace SistemaClinica.Controlador
{
    public static class TAmbulancia
    {
        public static List<Ambulancia> Lista = new List<Ambulancia>();
        public static void Insertar(Ambulancia a) => Lista.Add(a);
        public static int Buscar(string codigo) => Lista.FindIndex(x => x.Codigo == codigo);
        public static void Modificar(Ambulancia a) { int pos = Buscar(a.Codigo); if (pos >= 0) Lista[pos] = a; }
        public static void Eliminar(string codigo) { int pos = Buscar(codigo); if (pos >= 0) Lista.RemoveAt(pos); }
    }
}
