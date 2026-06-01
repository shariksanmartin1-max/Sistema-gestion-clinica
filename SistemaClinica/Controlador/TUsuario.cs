using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaClinica.Entidades;

namespace SistemaClinica.Controlador
{
    public static class TUsuario
    {
        public static List<Usuario> Lista = new List<Usuario>();
        public static void Insertar(Usuario u) => Lista.Add(u);
        public static int Buscar(string usuarioLogin) => Lista.FindIndex(x => x.UsuarioLogin == usuarioLogin);
        public static void Modificar(Usuario u) { int pos = Buscar(u.UsuarioLogin); if (pos >= 0) Lista[pos] = u; }
        public static void Eliminar(string usuarioLogin) { int pos = Buscar(usuarioLogin); if (pos >= 0) Lista.RemoveAt(pos); }
    }
}
