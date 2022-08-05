using Microsoft.EntityFrameworkCore;

namespace SillystringzFactory.Models
{
  public class SillystringzFactoryContext : DbContext
  {
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<Machine> Machines {get; set; }
    public DbSet<EngineerMachine> EngineerMachine { get; set; }
    public SillystringzFactoryContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}