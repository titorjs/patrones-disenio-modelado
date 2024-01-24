using System.ComponentModel.DataAnnotations;

namespace FactoryMet.Modelos
{
    public class Carro
    {
        [Key]
        public int Id { get; set; }
        public string Modelo { get; set; }

        public string Tipo { get; set; }
    }
}
