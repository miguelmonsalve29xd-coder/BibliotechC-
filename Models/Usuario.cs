
namespace BibliotecaConsola.Models
{
    public class Usuario
    {
        // Propiedades
        public int Id { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }

        // Constructor vacío
        public Usuario()
        {
            Documento = "";
            Nombre = "";
            Correo = "";
            Telefono = "";
            Activo = true;
        }

        // Constructor completo
        public Usuario(int id, string documento, string nombre,
                        string correo, string telefono, bool activo = true)
        {
            Id = id;
            Documento = documento;
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
            Activo = activo;
        }

        // Resumen corto
        public string ResumenCorto()
        {
            return $"ID: {Id} | Nombre: {Nombre} | Documento: {Documento}";
        }

        // Detalle completo
        public string DetalleCompleto()
        {
            return $"ID: {Id}\n" +
                    $"Documento: {Documento}\n" +
                    $"Nombre: {Nombre}\n" +
                    $"Correo: {Correo}\n" +
                    $"Teléfono: {Telefono}\n" +
                    $"Activo: {(Activo ? "Sí" : "No")}";
        }

        // Representación del objeto
        public override string ToString()
        {
            return ResumenCorto();
        }
    }
}
