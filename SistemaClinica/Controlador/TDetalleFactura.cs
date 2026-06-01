using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaClinica.Entidades;

namespace SistemaClinica.Controlador
{
    public static class TDetalleFactura
    {
        public static List<DetalleFactura> Lista = new List<DetalleFactura>();
        public static void Insertar(DetalleFactura df) => Lista.Add(df);
        public static int Buscar(string codigo) => Lista.FindIndex(x => x.Codigo == codigo);
        public static void Modificar(DetalleFactura df) { int pos = Buscar(df.Codigo); if (pos >= 0) Lista[pos] = df; }
        public static void Eliminar(string codigo) { int pos = Buscar(codigo); if (pos >= 0) Lista.RemoveAt(pos); }
    }

}
