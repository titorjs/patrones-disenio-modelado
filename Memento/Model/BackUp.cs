using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Memento.Model
{
    public class BackUp
    {
        [Key]
        public int IdAux { get; set; }
        [Required]
        public int Estado { get; set; }
        [Required]
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Cuerpo { get; set; }
    }
}
