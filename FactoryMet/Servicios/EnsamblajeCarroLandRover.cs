using FactoryMet.Clases;
using FactoryMet.Datos;
using FactoryMet.Modelos;

namespace FactoryMet.Servicios
{
    public class EnsamblajeCarroLandRover : IEnsamblajeCarroService
    {
        private readonly ApplicationDbContext _dbContext;
        public EnsamblajeCarroLandRover(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void EnsamblarCarro(Carro carro, string tipoCarro)
        {
            var model = new Carro
            {
                Modelo = "Land Rover",
                Tipo = tipoCarro,
            };
            if (tipoCarro.Equals("manual"))
            {
                new EnsamblajeCarroManual(_dbContext).EnsamblarCarro(model);
            }
            else if (tipoCarro.Equals("compacto"))
            {
                new EnsamblajeCarroCompacto(_dbContext).EnsamblarCarro(model);
            }
            else
            {
                new EnsamblajeCarroCompacto(_dbContext).EnsamblarCarro(model);
            }
        }
    }
}
