
namespace SistGestNotas.Models
{
    public class Docente : Usuario
    {
        public Grado? GradoAsignado { get; set; }
        public string? Email { get; set; }
        

        public Docente() { }

        public Docente(Grado? gradoAsignado, string? email)
        {
            GradoAsignado = gradoAsignado;
            Email = email;
            
        }

        public Docente(int id, string nombre, string apellidos, 
            string telefono, DateOnly fechaIngreso, string rolUser, Grado? gradoAsignado, string? email) 
            : base(id, nombre, apellidos, telefono, fechaIngreso, rolUser)
        {
            GradoAsignado = gradoAsignado;
            Email = email;
        }
    }
}
