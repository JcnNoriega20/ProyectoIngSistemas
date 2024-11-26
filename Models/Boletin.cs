namespace SistGestNotas.Models
{
    public class Boletin
    {
        public int Id { get; set; }
        public Estudiante? Estudiante { get; set; }
        public List<Asignatura>? Asignaturas { get; set; }
        public PeriodoAcademico? PeriodoAcademico { get; set; }
        public Logros? LogroAsignado { get; set; }
    }
}
