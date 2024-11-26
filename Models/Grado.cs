namespace SistGestNotas.Models
{
    public class Grado
    {
        public int Id { get; set; }
        public string? nombreGrado { get; set; }
        public List<Asignatura>? Asignaturas { get; set; }
    }
}
