namespace SistGestNotas.Models
{
    public class Actividad
    {
        public int Id { get; set; }
        public string? NombreActividad { get; set; }
        public decimal NotaActividad { get; set; }

        public Actividad(int id, string? nombreActividad)
        {
            Id = id;
            NombreActividad = nombreActividad;
        }

        public Actividad(int id, string? nombreActividad, decimal notaActividad) : this(id, nombreActividad)
        {
            NotaActividad = notaActividad;
        }
    }
}
