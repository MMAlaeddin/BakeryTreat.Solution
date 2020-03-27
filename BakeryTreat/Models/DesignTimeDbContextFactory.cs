using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BakeryTreat.Models
{
  public class BakeryTreatContextFactory : IDesignTimeDbContextFactory<BakeryTreatContext>
  {

    BakeryTreatContext IDesignTimeDbContextFactory<BakeryTreatContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<BakeryTreatContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new BakeryTreatContext(builder.Options);
    }
  }
}