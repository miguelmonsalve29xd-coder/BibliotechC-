using System;
using System.Collections.Generic;
using System.Linq;
using BibliotecaConsola.Models;

namespace BibliotecaConsola.Services
{
    public class PrestamoService
    {
        private List<Prestamo> prestamos = new List<Prestamo>();

        // 1. Agregar un préstamo
        public void AgregarPrestamo(Prestamo prestamo)
        {
            prestamos.Add(prestamo);
        }

        // 2. Obtener todos los préstamos
        public List<Prestamo> ObtenerPrestamos()
        {
            return new List<Prestamo>(prestamos);
        }

        // 3. Buscar por ID
        public Prestamo? BuscarPorId(int id)
        {
            return prestamos.Find(prestamo =>
                prestamo.Id == id);
        }

        // 4. Buscar por estado
        public List<Prestamo> BuscarPorEstado(
            EstadoPrestamo estado)
        {
            return prestamos.Where(prestamo =>
                prestamo.Estado == estado).ToList();
        }

        // 5. Eliminar un préstamo
        public bool EliminarPrestamo(int id)
        {
            Prestamo? prestamo = BuscarPorId(id);

            if (prestamo != null)
            {
                return prestamos.Remove(prestamo);
            }

            return false;
        }

        // 6. Ordenar por fecha límite
        public List<Prestamo> OrdenarPorFechaVencimiento()
        {
            return prestamos.OrderBy(prestamo =>
                prestamo.FechaVencimiento).ToList();
        }

        // 7. Registrar devolución
        public bool RegistrarDevolucion(int id)
        {
            Prestamo? prestamo = BuscarPorId(id);

            if (prestamo == null ||
                prestamo.Estado == EstadoPrestamo.Devuelto)
            {
                return false;
            }

            prestamo.FechaDevolucion = DateTime.Now;
            prestamo.Estado = EstadoPrestamo.Devuelto;
            prestamo.Libro.Disponible = true;

            return true;
        }


        // KPI 1: Total de préstamos
        public int TotalPrestamos()
        {
            return prestamos.Count;
        }

        // KPI 2: Préstamos activos
        public int PrestamosActivos()
        {
            return prestamos.Count(prestamo =>
                prestamo.Estado == EstadoPrestamo.Activo &&
                !prestamo.EstaVencido());
        }

        // KPI 3: Préstamos vencidos
        public int PrestamosVencidos()
        {
            return prestamos.Count(prestamo =>
                prestamo.Estado == EstadoPrestamo.Vencido ||
                prestamo.EstaVencido());
        }

        // KPI 4: Préstamos devueltos
        public int PrestamosDevueltos()
        {
            return prestamos.Count(prestamo =>
                prestamo.Estado == EstadoPrestamo.Devuelto);
        }

        // KPI 5: Promedio de días de préstamo
        public double PromedioDiasPrestamo()
        {
            if (prestamos.Count == 0)
            {
                return 0;
            }

            return prestamos.Average(prestamo =>
                prestamo.DiasTranscurridos());
        }

    }
}
