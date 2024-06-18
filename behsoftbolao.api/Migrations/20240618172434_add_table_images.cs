using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace behsoftbolao.api.Migrations
{
    /// <inheritdoc />
    public partial class add_table_images : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: false),
                    FileDescription = table.Column<string>(type: "text", nullable: true),
                    FileExtension = table.Column<string>(type: "text", nullable: false),
                    FileSizeInBytes = table.Column<long>(type: "bigint", nullable: false),
                    FilePath = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: "29784a75-4721-4da4-b8b7-d167c588d5cf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ea03c43-4979-4c10-9a1a-6d4dfe1c5406", "a6844db1-8c1e-400d-9913-7fd8f9059090" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: "29784a75-4721-4da4-b8b7-d167c588d5cf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "43a68c11-1e6a-4189-aee4-dc1a4e48f93f", "0fd45a31-56ef-49d4-961c-9b179945236a" });
        }
    }
}
