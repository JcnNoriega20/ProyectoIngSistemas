namespace SistGestNotas.Models
{
    public class Asignatura
    {
        public int Id { get; set; }
        public string? NombreAsignatura { get; set; }
        public List<Actividad>? Actividades { get; set; }

        public Asignatura(){}

        public Asignatura(int id, string? nombreAsignatura, List<Actividad>? actividades)
        {
            Id = id;
            NombreAsignatura = nombreAsignatura;
            Actividades = actividades;
        }

        public Asignatura(int id, string? nombreAsignatura)
        {
            Id = id;
            NombreAsignatura = nombreAsignatura;
            
        }
    }
}
