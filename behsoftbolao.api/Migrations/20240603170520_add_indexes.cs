using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace behsoftbolao.api.Migrations
{
    /// <inheritdoc />
    public partial class add_indexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Participante_UsuarioId",
                table: "Participante");

            migrationBuilder.DropIndex(
                name: "IX_Palpites_ParticipanteID",
                table: "Palpites");

            migrationBuilder.DropIndex(
                name: "IX_CampeonatoAnual_CampeonatoId",
                table: "CampeonatoAnual");

            migrationBuilder.CreateIndex(
                name: "IX_Participante_UsuarioId_BolaoId",
                table: "Participante",
                columns: new[] { "UsuarioId", "BolaoId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Palpites_ParticipanteID_JogoId",
                table: "Palpites",
                columns: new[] { "ParticipanteID", "JogoId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CampeonatoAnual_CampeonatoId_Ano",
                table: "CampeonatoAnual",
                columns: new[] { "CampeonatoId", "Ano" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UX_codigo_bolao",
                table: "Boloes",
                column: "Codigo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Participante_UsuarioId_BolaoId",
                table: "Participante");

            migrationBuilder.DropIndex(
                name: "IX_Palpites_ParticipanteID_JogoId",
                table: "Palpites");

            migrationBuilder.DropIndex(
                name: "IX_CampeonatoAnual_CampeonatoId_Ano",
                table: "CampeonatoAnual");

            migrationBuilder.DropIndex(
                name: "UX_codigo_bolao",
                table: "Boloes");

            migrationBuilder.CreateIndex(
                name: "IX_Participante_UsuarioId",
                table: "Participante",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Palpites_ParticipanteID",
                table: "Palpites",
                column: "ParticipanteID");

            migrationBuilder.CreateIndex(
                name: "IX_CampeonatoAnual_CampeonatoId",
                table: "CampeonatoAnual",
                column: "CampeonatoId");
        }
    }
}
