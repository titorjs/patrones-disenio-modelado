using FactoryMet.Modelos;
using Microsoft.EntityFrameworkCore;

namespace FactoryMet.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Carro> Carros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            


        }
    }
}
