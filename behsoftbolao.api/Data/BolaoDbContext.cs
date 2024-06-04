using Core.Models;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace behsoftbolao.api.Data;

public class BolaoDbContext : DbContext
{
    public BolaoDbContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

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

        // Seeds
        GerarSeed(modelBuilder);
        
    }    

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Bolao> Boloes { get; set; }
    public DbSet<Palpite> Palpites { get; set; }
    public DbSet<Time> Time { get; set; }
    public DbSet<Campeonato> Campeonato { get; set; }
    public DbSet<CampeonatoAnual> CampeonatoAnual { get; set; }




    private void GerarSeed(ModelBuilder modelBuilder)
    {
        var campeonatos = new[] {
            new Campeonato() { Id = Guid.NewGuid(), Nome = "Copa do Mundo", Sigla = "FWC" },
            new Campeonato() { Id = Guid.NewGuid(), Nome = "Brasileirão - Série A", Sigla = "BRA-A" },
            new Campeonato() { Id = Guid.NewGuid(), Nome = "Brasileirão - Série B", Sigla = "BRA-B" }
        };
        modelBuilder.Entity<Campeonato>().HasData(campeonatos);

        var campeonato = new CampeonatoAnual { Id = Guid.NewGuid(), Ano = 2026, CampeonatoId = campeonatos[0].Id };
        modelBuilder.Entity<CampeonatoAnual>().HasData(campeonato);

        var usuario = new Usuario
        {
            Id = Guid.NewGuid().ToString(),
            Nome = "Admin"
        };
        modelBuilder.Entity<Usuario>().HasData(usuario);

        var boloes = new[] {
         new Bolao
            {
                Id = Guid.NewGuid(),
                Titulo = "Bolão do Banese 2024",
                Codigo = "BANESE",
                DonoId = usuario.Id,
                CampeonatoAnualId = campeonato.Id,
                CriadoEm = DateTime.Now,
            },
            new Bolao
            {
                Id = Guid.NewGuid(),
                Titulo = "Bolão do Junco",
                Codigo = "JUNCOS",
                DonoId = usuario.Id,
                CampeonatoAnualId = campeonato.Id,
                CriadoEm = DateTime.Now,
            }};
        modelBuilder.Entity<Bolao>().HasData(boloes);
    }

}
