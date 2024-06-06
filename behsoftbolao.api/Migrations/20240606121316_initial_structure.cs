using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace behsoftbolao.api.Migrations
{
    /// <inheritdoc />
    public partial class initial_structure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campeonato",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Sigla = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campeonato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Time",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Sigla = table.Column<string>(type: "text", nullable: false),
                    IconeBandeira = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Time", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    AvatarUrl = table.Column<string>(type: "text", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CampeonatoAnual",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Ano = table.Column<int>(type: "integer", nullable: false),
                    DataEncerramento = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CampeonatoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampeonatoAnual", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampeonatoAnual_Campeonato_CampeonatoId",
                        column: x => x.CampeonatoId,
                        principalTable: "Campeonato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Boloes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    Codigo = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Updated = table.Column<bool>(type: "boolean", nullable: false),
                    DonoId = table.Column<string>(type: "text", nullable: false),
                    CampeonatoAnualId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boloes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Boloes_CampeonatoAnual_CampeonatoAnualId",
                        column: x => x.CampeonatoAnualId,
                        principalTable: "CampeonatoAnual",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Boloes_Usuarios_DonoId",
                        column: x => x.DonoId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jogo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Data = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    PlacarTimeUm = table.Column<int>(type: "integer", nullable: true),
                    PlacarTimeDois = table.Column<int>(type: "integer", nullable: true),
                    CampeonatoAnualId = table.Column<Guid>(type: "uuid", nullable: false),
                    TimeUmId = table.Column<Guid>(type: "uuid", nullable: true),
                    TimeDoisId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jogo_CampeonatoAnual_CampeonatoAnualId",
                        column: x => x.CampeonatoAnualId,
                        principalTable: "CampeonatoAnual",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jogo_Time_TimeDoisId",
                        column: x => x.TimeDoisId,
                        principalTable: "Time",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Jogo_Time_TimeUmId",
                        column: x => x.TimeUmId,
                        principalTable: "Time",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Participante",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Pontuacao = table.Column<int>(type: "integer", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    BolaoId = table.Column<Guid>(type: "uuid", nullable: false),
                    UsuarioId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participante", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participante_Boloes_BolaoId",
                        column: x => x.BolaoId,
                        principalTable: "Boloes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Participante_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Palpites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PontosTimeUm = table.Column<int>(type: "integer", nullable: true),
                    PontosTimeDois = table.Column<int>(type: "integer", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ParticipanteID = table.Column<Guid>(type: "uuid", nullable: false),
                    JogoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Palpites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Palpites_Jogo_JogoId",
                        column: x => x.JogoId,
                        principalTable: "Jogo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Palpites_Participante_ParticipanteID",
                        column: x => x.ParticipanteID,
                        principalTable: "Participante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Campeonato",
                columns: new[] { "Id", "Nome", "Sigla" },
                values: new object[,]
                {
                    { new Guid("9dc2938e-c245-43a2-bb8b-fe58f6c09a9d"), "Copa do Mundo", "FWC" },
                    { new Guid("c9df5ae9-6c93-4f6c-ab09-a145faa599da"), "Brasileirão - Série B", "BRA-B" },
                    { new Guid("f28d4dc4-5198-41ce-b785-286d589ceca6"), "Brasileirão - Série A", "BRA-A" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "AccessFailedCount", "AvatarUrl", "ConcurrencyStamp", "CriadoEm", "DataNascimento", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "29784a75-4721-4da4-b8b7-d167c588d5cf", 0, "https://ui-avatars.com/api/?background=random&name=Admin", "40775525-ea1d-4e6f-bfe4-f0c23461b250", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", false, false, null, "Admin", null, null, null, null, false, "d9f30982-33ec-4282-8cd5-b1adee7bb54a", false, null });

            migrationBuilder.InsertData(
                table: "CampeonatoAnual",
                columns: new[] { "Id", "Ano", "CampeonatoId", "DataEncerramento" },
                values: new object[] { new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), 2026, new Guid("9dc2938e-c245-43a2-bb8b-fe58f6c09a9d"), null });

            migrationBuilder.InsertData(
                table: "Boloes",
                columns: new[] { "Id", "CampeonatoAnualId", "Codigo", "CriadoEm", "DonoId", "Titulo", "Updated" },
                values: new object[,]
                {
                    { new Guid("3d80aad3-54df-40f6-911e-b47d0254050a"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BANESE", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024", false },
                    { new Guid("a979e67e-0313-46ff-b952-91568c6767fd"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "JUNCOS", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Junco", false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boloes_CampeonatoAnualId",
                table: "Boloes",
                column: "CampeonatoAnualId");

            migrationBuilder.CreateIndex(
                name: "IX_Boloes_DonoId",
                table: "Boloes",
                column: "DonoId");

            migrationBuilder.CreateIndex(
                name: "UX_codigo_bolao",
                table: "Boloes",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CampeonatoAnual_CampeonatoId_Ano",
                table: "CampeonatoAnual",
                columns: new[] { "CampeonatoId", "Ano" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jogo_CampeonatoAnualId",
                table: "Jogo",
                column: "CampeonatoAnualId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogo_TimeDoisId",
                table: "Jogo",
                column: "TimeDoisId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogo_TimeUmId",
                table: "Jogo",
                column: "TimeUmId");

            migrationBuilder.CreateIndex(
                name: "IX_Palpites_JogoId",
                table: "Palpites",
                column: "JogoId");

            migrationBuilder.CreateIndex(
                name: "IX_Palpites_ParticipanteID_JogoId",
                table: "Palpites",
                columns: new[] { "ParticipanteID", "JogoId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Participante_BolaoId",
                table: "Participante",
                column: "BolaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Participante_UsuarioId_BolaoId",
                table: "Participante",
                columns: new[] { "UsuarioId", "BolaoId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Palpites");

            migrationBuilder.DropTable(
                name: "Jogo");

            migrationBuilder.DropTable(
                name: "Participante");

            migrationBuilder.DropTable(
                name: "Time");

            migrationBuilder.DropTable(
                name: "Boloes");

            migrationBuilder.DropTable(
                name: "CampeonatoAnual");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Campeonato");
        }
    }
}
