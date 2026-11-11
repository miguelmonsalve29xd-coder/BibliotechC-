
using System;

namespace BibliotecaConsola.Models
{
    public class Prestamo
    {
        // Propiedades
        public int Id { get; set; }
        public Libro Libro { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime? FechaDevolucion { get; set; }

        // Estado inicial del préstamo
        public EstadoPrestamo Estado { get; set; }

        // Constructor vacío
        public Prestamo()
        {
            Libro = new Libro();
            Usuario = new Usuario();
            FechaPrestamo = DateTime.Now;
            FechaVencimiento = DateTime.Now.AddDays(15);
            FechaDevolucion = null;
            Estado = EstadoPrestamo.Activo;
        }

        // Constructor completo
        public Prestamo(int id, Libro libro, Usuario usuario,
                        DateTime fechaPrestamo, DateTime fechaVencimiento,
                        DateTime? fechaDevolucion = null,
                        EstadoPrestamo estado = EstadoPrestamo.Activo)
        {
            Id = id;
            Libro = libro;
            Usuario = usuario;
            FechaPrestamo = fechaPrestamo;
            FechaVencimiento = fechaVencimiento;
            FechaDevolucion = fechaDevolucion;
            Estado = estado;
        }

        // Verificar si el préstamo está vencido
        public bool EstaVencido()
        {
            return Estado == EstadoPrestamo.Activo &&
                    FechaDevolucion == null &&
                    DateTime.Now.Date > FechaVencimiento.Date;
        }

        // Calcular días transcurridos
        public int DiasTranscurridos()
        {
            DateTime fechaFinal = FechaDevolucion ?? DateTime.Now;

            return Math.Max(0, (fechaFinal.Date - FechaPrestamo.Date).Days);
        }

        // Resumen corto
        public string ResumenCorto()
        {
            return $"Préstamo ID: {Id} | Libro: {Libro.Titulo} | Usuario: {Usuario.Nombre} | Estado: {Estado}";
        }

        // Detalle completo
        public string DetalleCompleto()
        {
            return $"ID: {Id}\n" +
                    $"Libro: {Libro.Titulo}\n" +
                    $"Usuario: {Usuario.Nombre}\n" +
                    $"Fecha de préstamo: {FechaPrestamo:dd/MM/yyyy}\n" +
                    $"Fecha de vencimiento: {FechaVencimiento:dd/MM/yyyy}\n" +
                    $"Fecha de devolución: {(FechaDevolucion.HasValue ? FechaDevolucion.Value.ToString("dd/MM/yyyy") : "Pendiente")}\n" +
                    $"Estado: {Estado}\n" +
                    $"¿Está vencido?: {(EstaVencido() ? "Sí" : "No")}\n" +
                    $"Días transcurridos: {DiasTranscurridos()}";
        }

        // Representación del objeto
        public override string ToString()
        {
            return ResumenCorto();
        }
    }
}
