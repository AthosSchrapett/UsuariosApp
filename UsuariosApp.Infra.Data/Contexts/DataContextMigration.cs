using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace UsuariosApp.Infra.Data.Contexts;

public class DataContextMigration : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        var configurationBuilder = new ConfigurationBuilder();

        var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
        configurationBuilder.AddJsonFile(path, false);

        var root = configurationBuilder.Build();
        var connectionString = root.GetConnectionString("UsuariosApp");

        var builder = new DbContextOptionsBuilder<DataContext>();

        builder.UseSqlServer(connectionString);

        return new DataContext(builder.Options);
    }
}
