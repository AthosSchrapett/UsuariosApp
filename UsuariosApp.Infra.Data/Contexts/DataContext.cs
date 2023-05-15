using Microsoft.EntityFrameworkCore;
using UsuariosApp.Domain.Models;
using UsuariosApp.Infra.Data.Configurations;

namespace UsuariosApp.Infra.Data.Contexts;

public class DataContext : DbContext
{
    public DbSet<Usuario>? Usuarios { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
    }
}
