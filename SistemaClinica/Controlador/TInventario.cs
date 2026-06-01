using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaClinica.Entidades;

namespace SistemaClinica.Controlador
{
    public static class TInventario
    {
        public static List<Inventario> Lista = new List<Inventario>();
        public static void Insertar(Inventario i) => Lista.Add(i);
        public static int Buscar(string codigo) => Lista.FindIndex(x => x.Codigo == codigo);
        public static void Modificar(Inventario i) { int pos = Buscar(i.Codigo); if (pos >= 0) Lista[pos] = i; }
        public static void Eliminar(string codigo) { int pos = Buscar(codigo); if (pos >= 0) Lista.RemoveAt(pos); }
    }
}
