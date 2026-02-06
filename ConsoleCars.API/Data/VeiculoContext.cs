using ConsoleCars.Lib.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ConsoleCars.API.Data;

public class VeiculoContext : DbContext
{
    public VeiculoContext(DbContextOptions<VeiculoContext> options) : base(options) { }
    public DbSet<Veiculo> Veiculos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Veiculo>().HasKey(v => v.Placa);
    }
}
