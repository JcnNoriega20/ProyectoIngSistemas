namespace SistGestNotas.Models
{
    public class Acudiente : Usuario
    {
        public Acudiente() { 
        }
        public Acudiente(int id, string nombre, string apellidos, string telefono) 
            : base(id, nombre, apellidos, telefono)
        {

        }
    }
}
