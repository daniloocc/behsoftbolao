using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace behsoftbolao.api.Migrations
{
    /// <inheritdoc />
    public partial class add_seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Usuarios",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CriadoEm",
                table: "Participante",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CriadoEm",
                table: "Palpites",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "Jogo",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataEncerramento",
                table: "CampeonatoAnual",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CriadoEm",
                table: "Boloes",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.InsertData(
                table: "Campeonato",
                columns: new[] { "Id", "Nome", "Sigla" },
                values: new object[,]
                {
                    { new Guid("0533d7c1-26d3-48c7-a03b-cc70e1765c9e"), "Brasileirão - Série B", "BRA-B" },
                    { new Guid("7214a1fc-bb8d-45d9-aa16-a2667ee04546"), "Brasileirão - Série A", "BRA-A" },
                    { new Guid("c3d7a609-49ea-46b9-b08e-d332132ddbd7"), "Copa do Mundo", "FWC" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e4684961-3831-4b37-9987-f67292adca63", 0, "1d932d97-a251-4f34-a626-72ac606f3e3d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, null, "Admin", null, null, null, null, false, "a78199f3-4aba-44f5-a418-23a55e919227", false, null });

            migrationBuilder.InsertData(
                table: "CampeonatoAnual",
                columns: new[] { "Id", "Ano", "CampeonatoId", "DataEncerramento" },
                values: new object[] { new Guid("cca0d45e-6cb1-4227-90f8-90d1b99fa589"), 2026, new Guid("c3d7a609-49ea-46b9-b08e-d332132ddbd7"), null });

            migrationBuilder.InsertData(
                table: "Boloes",
                columns: new[] { "Id", "CampeonatoAnualId", "Codigo", "CriadoEm", "DonoId", "Titulo", "Updated" },
                values: new object[,]
                {
                    { new Guid("2794e6ae-6824-4c24-addf-7b2f62d81c41"), new Guid("cca0d45e-6cb1-4227-90f8-90d1b99fa589"), "BANESE", new DateTime(2024, 6, 4, 11, 6, 4, 919, DateTimeKind.Local).AddTicks(50), "e4684961-3831-4b37-9987-f67292adca63", "Bolão do Banese 2024", false },
                    { new Guid("3194c198-b7e0-48ac-b698-14fe63e5d381"), new Guid("cca0d45e-6cb1-4227-90f8-90d1b99fa589"), "JUNCOS", new DateTime(2024, 6, 4, 11, 6, 4, 919, DateTimeKind.Local).AddTicks(63), "e4684961-3831-4b37-9987-f67292adca63", "Bolão do Junco", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("2794e6ae-6824-4c24-addf-7b2f62d81c41"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("3194c198-b7e0-48ac-b698-14fe63e5d381"));

            migrationBuilder.DeleteData(
                table: "Campeonato",
                keyColumn: "Id",
                keyValue: new Guid("0533d7c1-26d3-48c7-a03b-cc70e1765c9e"));

            migrationBuilder.DeleteData(
                table: "Campeonato",
                keyColumn: "Id",
                keyValue: new Guid("7214a1fc-bb8d-45d9-aa16-a2667ee04546"));

            migrationBuilder.DeleteData(
                table: "CampeonatoAnual",
                keyColumn: "Id",
                keyValue: new Guid("cca0d45e-6cb1-4227-90f8-90d1b99fa589"));

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: "e4684961-3831-4b37-9987-f67292adca63");

            migrationBuilder.DeleteData(
                table: "Campeonato",
                keyColumn: "Id",
                keyValue: new Guid("c3d7a609-49ea-46b9-b08e-d332132ddbd7"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Usuarios",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CriadoEm",
                table: "Participante",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CriadoEm",
                table: "Palpites",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "Jogo",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataEncerramento",
                table: "CampeonatoAnual",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CriadoEm",
                table: "Boloes",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");
        }
    }
}
