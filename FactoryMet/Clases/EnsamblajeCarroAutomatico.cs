using FactoryMet.Datos;
using FactoryMet.Modelos;

namespace FactoryMet.Clases
{
    public class EnsamblajeCarroAutomatico : IEnsamblajeCarro
    {
        private readonly ApplicationDbContext _db;
        public EnsamblajeCarroAutomatico(ApplicationDbContext db)
        {
            _db = db;
        }
        public void EnsamblarCarro(Carro carro)
        {
            _db.Carros.Add(carro);
        }
    }
}
