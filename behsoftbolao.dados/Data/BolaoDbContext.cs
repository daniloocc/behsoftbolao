using Behsoft.Utils;
using behsoftbolao.api.Models.Domain;
using Core.Models;
using Database.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace behsoftbolao.api.Data;

public class BolaoDbContext : DbContext
{
    public BolaoDbContext(DbContextOptions<BolaoDbContext> options) : base(options)
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
    public DbSet<Image> Images { get; set; }

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

        List<Bolao> boloes = [];
        string[] guids = [
"36e9709a-c691-43b6-8767-5e81f876c5e6","2627d703-c504-4b94-ae8e-4d09490343af","df3c427d-a17e-4646-8568-7a978091814d","7bcd0722-0268-460e-8082-f3911b50f7e6",
"17038752-c57b-442b-a147-5d5fd539620f","00ad539e-1270-4024-ae43-618c857b1c84","6bdfcf52-3a94-4169-8090-2fdf8ab5209d","c8e7b33e-a529-4dfc-859d-c813bf838f86",
"9d6f7543-c0b8-4702-817a-3d3c29a2cee4","4553ea69-c009-4d04-8903-1df72148583f","eced80e0-3315-44b0-8a3a-ae274e296c08","a991e7f6-618f-433a-97d6-68c2ed5eb03e",
"05ffb1ae-3098-4292-bea8-5c304797f978","55c36ef4-dcd4-4334-ad52-09e71ea0a74d","8abdd214-8320-4b90-93a2-22c6c791a7e3","44a999e1-9b1f-49d4-99dc-f32fe573b2e5",
"951da53a-b0fe-473e-b6db-464ddeb40bb8","5576b040-83f5-47a0-a656-708748ddd36b","dc7b733c-72ba-4de7-9ea0-6a8693e007a2","6d74bece-4768-482c-9099-04fe30db1544",
"d0ad8522-195f-48aa-aa72-82348c4d0d25","eba3b82a-bd54-40d0-b22e-690c68af2ed8","4316c3b0-d02a-4892-a86c-f6159bdb85d2","fe6a1863-5b61-42d7-abc4-b1733806a9c0",
"21f66624-02c9-4231-9ff4-0681b4539a18","8f482d48-43f6-48b9-ba09-37591381906b","4670e6f2-b623-4ec8-be41-5257a0a2301b","1745ef08-b9b3-4fc8-b567-4da70d1d6f53",
"e2ec19c3-fcd2-4bc0-98cf-1133515d3724","4d5fa54c-62e3-496a-9d4a-d9b5d5d93cc5","b8ca08b9-8c15-4d69-b43e-ef4f78f3ad91","b4d6dee6-b2f5-49fa-b872-ff9cf6b79947",
"93f1fcaf-1cf0-4c88-be71-34b9e87a070e","0f1ff8b2-cb4f-47ba-b5a8-52b2aee6ed4d","d1ec4012-3223-48d2-aa58-24d7587fbf90","299fe09a-7790-4014-b87b-e3a63cf1c80a",
"441d30e2-d0a0-4c33-86da-93382ab96621","b7e493fe-8ade-45eb-ac8d-29395cf2951c","eaf6fff8-5860-4368-9e93-d81f8b5951b4","a451db38-3182-4f9b-8989-93ebc3a7d705",
"ace8a5e0-958c-44b1-b02f-550c034b9987","68c1e204-78ec-429a-ace4-6edd87e60031","c98101c2-5759-4f76-beaa-d41053ded26b","99d4c1cf-48cf-449d-8c98-3ef5492b33cc",
"8caeae22-e12e-439a-bacb-02c4a51711f3","781bd315-ef76-438a-9859-bcaa8f21cbdd","82a48848-29ff-4f64-9f77-fc835fdc0ca2","80e326bc-c88b-486b-a5c9-bfa9503c4a7c",
"3de6f0a7-219d-4e73-aabb-be24ea72c86b","4623b4d4-85c8-4e16-adf2-45758c7c2a7e","9f776d79-7c5d-4fe5-9ffa-398fc40af0e4","ac05c84d-a257-4882-9f81-ddc7ae0df1a2",
"bfc06fb6-1919-4484-b046-f62ddf179690","14d612f5-afe3-499c-a5a9-e65ccf343f2f","a4ba7d42-8207-4a00-8584-622403e00bb5","28faf52a-3647-4ac3-9b6c-7217c5826dd6",
"6ea93590-d8b3-4ede-9b4a-e4a8963930b1","884cf49d-1af7-4c60-b5d8-b7bf235601d7","0388ebd9-6a91-43ec-9ef4-e8713876b54c","857415f2-3411-454b-b993-d9756a3ba183",
"2e77640c-22a8-4406-9492-34d81d237c37","c9b4cd05-b66b-4893-8e10-ff39b0900175","1abba436-5dc7-4391-8c5b-5d0e5a2da0cc","ccea5603-0501-44ce-b117-938b884fb6c3",
"a514e294-7207-4f6f-86b0-ab87f4bae374","4a7e4e86-53c0-47ca-809f-a7ba546bc720","311ebcd3-eb9d-4426-836f-0ceccb06ef75","49019fad-5df0-4441-9fb7-ff1294581ef3",
"90b4fccd-c6e7-4b1b-a92e-9a386fb55484","3c9e7b95-2975-4e19-93fc-bd8e60ca8b3d","637c833d-f45b-4360-92fb-7693b144c82f","f4b29308-f0fb-44e8-92fc-8edfbb82d5af",
"8ed3548e-3de2-4300-ae4f-144718a14aba","12d9b894-6440-4b83-96d6-e94bc28a6999","55fbd585-a297-4216-9048-5bd57343afc0","8daf313d-71b0-42b1-a5f5-887ca5e98453",
"c49c15ab-2a23-4ea0-a198-16127f6f8c64","41920598-a1c5-4275-83b3-bbe4c4700124","86f26a9c-89f5-42fa-9cd6-02e7e5977c40","d7e3467f-3605-4b97-b301-034704eb9e7d",
"e1431594-0944-4437-a57c-3ccfbf8e5352","1e24b887-00ac-4af9-8b99-cdfe0719aa74","3da0e5cb-5281-42ea-8f7e-7c34c6de7502","8446a899-4c7f-4b62-ac92-ed5320aafe6a",
"6388be74-1bb9-4636-97e5-14e5e8d0e442","f0cf9dea-f303-44c8-b07e-25ec8e99604a","54d3b16f-6515-4962-a913-cac49384153d","1bd5780a-fb27-4100-994b-f78b2127f921",
"30d52d1c-3700-4bab-b059-7bfdc34c3ce9","a708c743-348a-4643-bc8f-961c93c64db4","03b8c00b-35d5-44a4-9c11-f61955a52b7e","8ca828ee-baa5-4d25-83c3-8457b0e8d635",
"85abe0dd-cdd3-400c-8044-e4f3d4d23be1","124a97f7-5d34-41af-ac30-bc2159e3b41e","2ae4949e-c4a9-48ae-b546-bad32c91492d","7a6319c5-f28a-4b00-ae90-35c69bf59b49",
"a3b2e75b-e473-415b-a276-887e0252d211","7189d6c7-565c-4aae-958a-7bf60f28ce12","ee434476-97c3-41c0-838a-d7c51948f295","ab2ca290-ba70-46e4-8ebc-f8d5860c8011" ];

        for (int i = 0; i < guids.Length; i++)
        {
            boloes.Add(new Bolao
            {
                Id = Guid.Parse(guids[i]),
                Titulo = $"Bolão do Banese 2024 - {i}",
                Codigo = $"BAN{i.ToString().PadLeft(3, '0')}",
                DonoId = usuario.Id,
                CampeonatoAnualId = campeonato.Id,
                CriadoEm = new DateTime(2024, 06, 06, 8, 0, 0),
            });
        }
        modelBuilder.Entity<Bolao>().HasData(boloes);
    }

}
