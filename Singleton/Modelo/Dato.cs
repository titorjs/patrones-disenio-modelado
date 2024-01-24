using System.ComponentModel.DataAnnotations;

namespace Singleton.Modelo
{
    public class Dato
    {
        [Key]
        public int Id { get; set; }
        
        public string Descripcion { get; set; }

        public string Valor {  get; set; }
    }
}
