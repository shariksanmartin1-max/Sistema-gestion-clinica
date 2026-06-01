using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaClinica.Entidades;

namespace SistemaClinica.Controlador
{
    public static class TLaboratorio
    {
        public static List<Laboratorio> Lista = new List<Laboratorio>();
        public static void Insertar(Laboratorio l) => Lista.Add(l);
        public static int Buscar(string codigo) => Lista.FindIndex(x => x.Codigo == codigo);
        public static void Modificar(Laboratorio l) { int pos = Buscar(l.Codigo); if (pos >= 0) Lista[pos] = l; }
        public static void Eliminar(string codigo) { int pos = Buscar(codigo); if (pos >= 0) Lista.RemoveAt(pos); }
    }
}
