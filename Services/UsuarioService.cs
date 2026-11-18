using System;
using System.Collections.Generic;
using System.Linq;
using BibliotecaConsola.Models;

namespace BibliotecaConsola.Services
{
    public class UsuarioService
    {
        private List<Usuario> usuarios = new List<Usuario>();

        // 1. Agregar usuario
        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        // 2. Obtener todos los usuarios
        public List<Usuario> ObtenerUsuarios()
        {
            return new List<Usuario>(usuarios);
        }

        // 3. Buscar por documento
        public Usuario? BuscarPorDocumento(string documento)
        {
            return usuarios.Find(usuario =>
                usuario.Documento == documento);
        }

        // 4. Buscar por nombre
        public List<Usuario> BuscarPorNombre(string nombre)
        {
            return usuarios.Where(usuario =>
                usuario.Nombre.Contains(
                    nombre,
                    StringComparison.OrdinalIgnoreCase
                )
            ).ToList();
        }

        // 5. Eliminar usuario
        public bool EliminarUsuario(string documento)
        {
            Usuario? usuario = BuscarPorDocumento(documento);

            if (usuario != null)
            {
                return usuarios.Remove(usuario);
            }

            return false;
        }

        // 6. Ordenar por nombre
        public List<Usuario> OrdenarPorNombre()
        {
            return usuarios.OrderBy(usuario =>
                usuario.Nombre).ToList();
        }


        // KPI 1: Total de usuarios
        public int TotalUsuarios()
        {
            return usuarios.Count;
        }

        // KPI 2: Usuarios activos
        public int UsuariosActivos()
        {
            return usuarios.Count(usuario => usuario.Activo);
        }

        // KPI 3: Usuarios inactivos
        public int UsuariosInactivos()
        {
            return usuarios.Count(usuario => !usuario.Activo);
        }

    }
}
