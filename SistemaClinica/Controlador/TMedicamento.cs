using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaClinica.Entidades;

namespace SistemaClinica.Controlador
{
    public static class TMedicamento
    {
        public static List<Medicamento> Lista = new List<Medicamento>();
        public static void Insertar(Medicamento m) => Lista.Add(m);
        public static int Buscar(string codigo) => Lista.FindIndex(x => x.Codigo == codigo);
        public static void Modificar(Medicamento m) { int pos = Buscar(m.Codigo); if (pos >= 0) Lista[pos] = m; }
        public static void Eliminar(string codigo) { int pos = Buscar(codigo); if (pos >= 0) Lista.RemoveAt(pos); }
    }
}
