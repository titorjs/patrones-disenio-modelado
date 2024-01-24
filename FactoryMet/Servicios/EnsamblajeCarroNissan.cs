using FactoryMet.Clases;
using FactoryMet.Datos;
using FactoryMet.Modelos;

namespace FactoryMet.Servicios
{
    public class EnsamblajeCarroNissan : IEnsamblajeCarroService
    {
        private readonly ApplicationDbContext _dbContext;
        public EnsamblajeCarroNissan(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void EnsamblarCarro(Carro carro, string tipoCarro)
        {
            var model = new Carro
            {
                Modelo = "Nissan",
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
