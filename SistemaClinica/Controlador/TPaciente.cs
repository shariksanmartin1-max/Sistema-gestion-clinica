using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaClinica.Entidades;

namespace SistemaClinica.Controlador
{
    public static class TPaciente
    {
        public static List<Paciente> Lista = new List<Paciente>();
        public static void Insertar(Paciente p) => Lista.Add(p);
        public static int Buscar(string cedula) => Lista.FindIndex(x => x.Cedula == cedula);
        public static void Modificar(Paciente p) { int pos = Buscar(p.Cedula); if (pos >= 0) Lista[pos] = p; }
        public static void Eliminar(string cedula) { int pos = Buscar(cedula); if (pos >= 0) Lista.RemoveAt(pos); }
    }
}
