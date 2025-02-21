using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaDesarrollador.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        
        [Required, StringLength(50)]
        public string NombreUsuario { get; set; }
        
        [Required]
        public string Pass { get; set; } // Encriptada
        
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        [ForeignKey("Persona")]
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
    }
}
