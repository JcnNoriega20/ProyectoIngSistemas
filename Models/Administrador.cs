namespace SistGestNotas.Models
{
    public class Administrador : Usuario
    {
        public Administrador(int id, string nombre, string apellidos, string telefono) : base(id, nombre, apellidos, telefono)
        {
        }
    }
}
