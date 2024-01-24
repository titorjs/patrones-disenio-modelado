using System.ComponentModel.DataAnnotations;

namespace Memento.Model
{
    public class Dato
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Cuerpo { get; set; }
    }
}
