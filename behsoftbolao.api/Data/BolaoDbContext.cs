using Core.Models;
using Core.Utils;
using Database.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
            new Campeonato() { Id = new Guid("9dc2938e-c245-43a2-bb8b-fe58f6c09a9d"), Nome = "Copa do Mundo", Sigla = "FWC" },
            new Campeonato() { Id = new Guid("f28d4dc4-5198-41ce-b785-286d589ceca6"), Nome = "Brasileirão - Série A", Sigla = "BRA-A" },
            new Campeonato() { Id = new Guid("c9df5ae9-6c93-4f6c-ab09-a145faa599da"), Nome = "Brasileirão - Série B", Sigla = "BRA-B" }
        };
        modelBuilder.Entity<Campeonato>().HasData(campeonatos);

        var campeonato = new CampeonatoAnual { Id = new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), Ano = 2026, CampeonatoId = campeonatos[0].Id };
        modelBuilder.Entity<CampeonatoAnual>().HasData(campeonato);

        var usuario = new Usuario
        {
            Id = new Guid("29784a75-4721-4da4-b8b7-d167c588d5cf").ToString(),
            Nome = "Admin",
            CriadoEm = new DateTime(2024, 06, 06, 8, 0, 0),
            Email = "admin@gmail.com",
            AvatarUrl = AvatarUtils.GetAvatarPorNome("Admin")
        };
        modelBuilder.Entity<Usuario>().HasData(usuario);

        var boloes = new[] {
         new Bolao
            {
                Id = new Guid("3d80aad3-54df-40f6-911e-b47d0254050a"),
                Titulo = "Bolão do Banese 2024",
                Codigo = "BANESE",
                DonoId = usuario.Id,
                CampeonatoAnualId = campeonato.Id,
                CriadoEm = new DateTime(2024, 06, 06, 8, 0, 0),
            },
            new Bolao
            {
                Id = new Guid("a979e67e-0313-46ff-b952-91568c6767fd"),
                Titulo = "Bolão do Junco",
                Codigo = "JUNCOS",
                DonoId = usuario.Id,
                CampeonatoAnualId = campeonato.Id,
                CriadoEm = new DateTime(2024, 06, 06, 8, 0, 0),
            }};
        modelBuilder.Entity<Bolao>().HasData(boloes);
    }

}
