using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Singleton.Modelo;

namespace Singleton.Data
{
    public class SingletonDbContext : DbContext
    {
        public SingletonDbContext() { }

        public SingletonDbContext(DbContextOptions<SingletonDbContext> options)
            :base(options)
        {

        }

        public virtual DbSet<Dato> Datos { get; set; }
    }
}
