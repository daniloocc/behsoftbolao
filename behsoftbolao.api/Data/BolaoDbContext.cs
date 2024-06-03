using Core.Models;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace behsoftbolao.api.Data;

public class BolaoDbContext : DbContext
{
    public BolaoDbContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bolao>()
            .HasIndex(x => x.Codigo)
            .HasDatabaseName("UX_codigo_bolao")
            .IsUnique();

        modelBuilder.Entity<CampeonatoAnual>()
            .HasIndex(c => new { c.CampeonatoId, c.Ano })
            .IsUnique(true);

        modelBuilder.Entity<Palpite>()
            .HasIndex(p => new { p.ParticipanteID, p.JogoId })
            .IsUnique(true);
        modelBuilder.Entity<Participante>()
            .HasIndex(p => new { p.UsuarioId, p.BolaoId })
            .IsUnique(true);
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Bolao> Boloes { get; set; }
    public DbSet<Palpite> Palpites { get; set; }
    public DbSet<Time> Time { get; set; }
    public DbSet<Campeonato> Campeonato { get; set; }
    public DbSet<CampeonatoAnual> CampeonatoAnual { get; set; }


}
