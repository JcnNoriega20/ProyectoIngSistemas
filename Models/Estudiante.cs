namespace SistGestNotas.Models
{
    public class Estudiante : Usuario
    {
        public Grado GradoActual { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public Acudiente Acudiente { get; set; }


        public Estudiante(){}

        public Estudiante(int id, string nombre, string apellidos, 
            DateOnly fechaIngreso, DateOnly fechaNacimiento, Acudiente acudiente) 
            : base (id, nombre, apellidos, fechaIngreso)
        {
            FechaNacimiento = fechaNacimiento;
            Acudiente = acudiente;
        }

        
    }
}
