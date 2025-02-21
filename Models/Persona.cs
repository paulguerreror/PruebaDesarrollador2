using System.ComponentModel.DataAnnotations;

namespace PruebaDesarrollador.Models
{
    public class Persona
    {
        public int Id { get; set; }
        
        [Required]
        public string Nombres { get; set; }
        
        [Required]
        public string Apellidos { get; set; }
        
        [Required]
        public string NumeroIdentificacion { get; set; }
        
        [Required, EmailAddress]
        public string Email { get; set; }
        
        [Required]
        public string TipoIdentificacion { get; set; }
        
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        
        public string NumeroIdentificacionCompleto { get; set; }
        public string NombreCompleto { get; set; }
    }
}
