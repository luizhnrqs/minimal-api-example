using Microsoft.EntityFrameworkCore;
using MinimalAPIExample.Models;

namespace MinimalAPIExample
{
    public class InMemoryDbContext : DbContext
    {
        public InMemoryDbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Heroi> Herois { get; set; }
    }
}
