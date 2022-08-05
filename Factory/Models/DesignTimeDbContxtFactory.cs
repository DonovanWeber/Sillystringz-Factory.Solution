using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SillystringzFactory.Models
{
  public class SillystringzFactoryContextFactory : IDesignTimeDbContextFactory<SillystringzFactoryContext>
  {
    SillystringzFactoryContext IDesignTimeDbContextFactory<SillystringzFactoryContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<SillystringzFactoryContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new SillystringzFactoryContext(builder.Options);
    }
  }
}