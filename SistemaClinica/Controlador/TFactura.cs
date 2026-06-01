using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaClinica.Entidades;

namespace SistemaClinica.Controlador
{
    public static class TFactura
    {
        public static List<Factura> Lista = new List<Factura>();
        public static void Insertar(Factura f) => Lista.Add(f);
        public static int Buscar(string numero) => Lista.FindIndex(x => x.Numero == numero);
        public static void Modificar(Factura f) { int pos = Buscar(f.Numero); if (pos >= 0) Lista[pos] = f; }
        public static void Eliminar(string numero) { int pos = Buscar(numero    ); if (pos >= 0) Lista.RemoveAt(pos); }
    }
}
