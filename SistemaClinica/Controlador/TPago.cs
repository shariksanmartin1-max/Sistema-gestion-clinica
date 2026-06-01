using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaClinica.Entidades;

namespace SistemaClinica.Controlador
{
    public static class TPago
    {
        public static List<Pago> Lista = new List<Pago>();
        public static void Insertar(Pago p) => Lista.Add(p);
        public static int Buscar(string codigo) => Lista.FindIndex(x => x.Codigo == codigo);
        public static void Modificar(Pago p) { int pos = Buscar(p.Codigo); if (pos >= 0) Lista[pos] = p; }
        public static void Eliminar(string codigo) { int pos = Buscar(codigo); if (pos >= 0) Lista.RemoveAt(pos); }
    }
}
