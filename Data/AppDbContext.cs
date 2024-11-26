    using SistGestNotas.Models;
using Microsoft.EntityFrameworkCore;

namespace SistGestNotas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Grado> Grados { get; set; }
        public DbSet<Boletin> Boletines { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<SistGestNotas.Models.Logros> Logros { get; set; } = default!;
        public DbSet<SistGestNotas.Models.PeriodoAcademico> PeriodoAcademico { get; set; } = default!;
    }
}
