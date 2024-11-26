namespace SistGestNotas.Models
{
    public class PeriodoAcademico
    {
        public int Id { get; set; }
        public string? NombrePeriodo { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }

    }
}
