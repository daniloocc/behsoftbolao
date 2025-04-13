using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace behsoftbolao.api.Data;

public class BolaoAuthDbContext : IdentityDbContext
{
    public BolaoAuthDbContext(DbContextOptions<BolaoAuthDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        var adminRoleId = "8a69c676-14d1-440f-9378-edb1fbd9d641";
        var apostadorRoleId = "5aa492d3-e46d-4231-8237-1d58667a0ca0";

        var roles = new List<IdentityRole>
        {
            new() {
                Id = adminRoleId,
                ConcurrencyStamp = adminRoleId,
                Name = "Administrador",
                NormalizedName = "Administrador".ToUpper()
            },
            new() {
                Id = apostadorRoleId,
                ConcurrencyStamp= apostadorRoleId,
                Name="Apostador",
                NormalizedName ="Apostador".ToUpper()

            }
        };
        builder.Entity<IdentityRole>().HasData(roles);
    }

}
