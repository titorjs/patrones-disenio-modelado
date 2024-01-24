using Memento.Model;
using Microsoft.EntityFrameworkCore;

namespace Memento.Data
{
    public class MementoDbContext : DbContext
    {
        public MementoDbContext()
        {
        }

        public MementoDbContext(DbContextOptions<MementoDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dato> Datoss { get; set; }
        public virtual DbSet<BackUp> Mementos { get; set; }
    }
}
