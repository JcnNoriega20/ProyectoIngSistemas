using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistGestNotas.Models
{
    public class Usuario 
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos {  get; set; }
        public DateOnly FechaIngreso { get; set; }
        public string? Telefono { get; set; }
        public string? RolUsuario { get; set; }

        public Usuario()
        {

        }
        public Usuario(int id, string nombre, string apellidos, DateOnly fechaIngreso)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            FechaIngreso = fechaIngreso;
        }

        public Usuario(int id, string nombre, string apellidos, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = telefono;
        }

        public Usuario(int id, string nombre, string apellidos, string telefono, DateOnly fechaIngreso, string rolUser)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = telefono;
        }

    }
}
