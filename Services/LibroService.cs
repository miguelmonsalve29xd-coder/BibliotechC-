using System;
using System.Collections.Generic;
using System.Linq;
using BibliotecaConsola.Models;

namespace BibliotecaConsola.Services
{
    public class LibroService
    {
        private List<Libro> libros = new List<Libro>();

        // Agregar libro
        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        // Obtener todos los libros
        public List<Libro> ObtenerLibros()
        {
            return new List<Libro>(libros);
        }

        // Buscar por ISBN
        public Libro? BuscarPorISBN(string isbn)
        {
            return libros.Find(libro => libro.ISBN == isbn);
        }

        // Buscar por título
        public List<Libro> BuscarPorTitulo(string titulo)
        {
            return libros.Where(libro =>
                libro.Titulo.Contains(
                    titulo,
                    StringComparison.OrdinalIgnoreCase
                )
            ).ToList();
        }

        // Buscar por autor
        public List<Libro> BuscarPorAutor(string autor)
        {
            return libros.Where(libro =>
                libro.Autor.Contains(
                    autor,
                    StringComparison.OrdinalIgnoreCase
                )
            ).ToList();
        }

        // Eliminar por ISBN
        public bool EliminarLibro(string isbn)
        {
            Libro? libro = BuscarPorISBN(isbn);

            if (libro != null)
            {
                return libros.Remove(libro);
            }

            return false;
        }

        // Ordenar por título
        public List<Libro> OrdenarPorTitulo()
        {
            return libros.OrderBy(libro => libro.Titulo).ToList();
        }

        // Ordenar por año
        public List<Libro> OrdenarPorAnio()
        {
            return libros.OrderBy(libro => libro.Anio).ToList();
        }


        // KPI 1: Total de libros
        public int TotalLibros()
        {
            return libros.Count;
        }

        // KPI 2: Libros disponibles
        public int LibrosDisponibles()
        {
            return libros.Count(libro => libro.Disponible);
        }

        // KPI 3: Libros prestados
        public int LibrosPrestados()
        {
            return libros.Count(libro => !libro.Disponible);
        }

    }
}
