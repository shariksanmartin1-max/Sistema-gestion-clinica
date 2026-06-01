using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaClinica.Entidades;

namespace SistemaClinica.Controlador
{
    public static class TDepartamento
    {
        public static List<Departamento> Lista = new List<Departamento>();
        public static void Insertar(Departamento d) => Lista.Add(d);
        public static int Buscar(string codigo) => Lista.FindIndex(x => x.Codigo == codigo);
        public static void Modificar(Departamento d) { int pos = Buscar(d.Codigo); if (pos >= 0) Lista[pos] = d; }
        public static void Eliminar(string codigo) { int pos = Buscar(codigo); if (pos >= 0) Lista.RemoveAt(pos); }
    }
}
