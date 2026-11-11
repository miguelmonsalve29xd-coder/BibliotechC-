
namespace BibliotecaConsola.Models
{
    public class Libro
    {
        // Propiedades
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Anio { get; set; }
        public string Categoria { get; set; }
        public bool Disponible { get; set; }

        // Constructor vacío
        public Libro()
        {
            Disponible = true;
            ISBN = "";
            Titulo = "";
            Autor = "";
            Categoria = "";
        }

        // Constructor completo
        public Libro(int id, string isbn, string titulo, string autor,
                    int anio, string categoria, bool disponible = true)
        {
            Id = id;
            ISBN = isbn;
            Titulo = titulo;
            Autor = autor;
            Anio = anio;
            Categoria = categoria;
            Disponible = disponible;
        }

        // Resumen corto
        public string ResumenCorto()
        {
            return $"ID: {Id} | Título: {Titulo} | Autor: {Autor}";
        }

        // Detalle completo
        public string DetalleCompleto()
        {
            return $"ID: {Id}\n" +
                    $"ISBN: {ISBN}\n" +
                    $"Título: {Titulo}\n" +
                    $"Autor: {Autor}\n" +
                    $"Año: {Anio}\n" +
                    $"Categoría: {Categoria}\n" +
                    $"Disponible: {(Disponible ? "Sí" : "No")}";
        }

        // Representación del objeto
        public override string ToString()
        {
            return ResumenCorto();
        }
    }
}
