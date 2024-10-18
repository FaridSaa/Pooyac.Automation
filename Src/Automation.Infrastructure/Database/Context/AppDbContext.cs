using Automation.Domain.Entity.Interface;
using Microsoft.EntityFrameworkCore;

namespace Automation.Infrastructure.Database.Context
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<IWip> Wip { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IWip>().HasKey(key => key.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
