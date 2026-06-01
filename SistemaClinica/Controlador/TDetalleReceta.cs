using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaClinica.Entidades;

namespace SistemaClinica.Controlador
{
    public static class TDetalleReceta
    {
        public static List<DetalleReceta> Lista = new List<DetalleReceta>();
        public static void Insertar(DetalleReceta dr) => Lista.Add(dr);
        public static int Buscar(string codigo) => Lista.FindIndex(x => x.Codigo == codigo);
        public static void Modificar(DetalleReceta dr) { int pos = Buscar(dr.Codigo); if (pos >= 0) Lista[pos] = dr; }
        public static void Eliminar(string codigo) { int pos = Buscar(codigo); if (pos >= 0) Lista.RemoveAt(pos); }
    }
}
