using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace behsoftbolao.api.Migrations
{
    /// <inheritdoc />
    public partial class add_seed_para_paginacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("3d80aad3-54df-40f6-911e-b47d0254050a"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("a979e67e-0313-46ff-b952-91568c6767fd"));

            migrationBuilder.InsertData(
                table: "Boloes",
                columns: new[] { "Id", "CampeonatoAnualId", "Codigo", "CriadoEm", "DonoId", "Titulo", "Updated" },
                values: new object[,]
                {
                    { new Guid("00ad539e-1270-4024-ae43-618c857b1c84"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN005", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 5", false },
                    { new Guid("0388ebd9-6a91-43ec-9ef4-e8713876b54c"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN058", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 58", false },
                    { new Guid("03b8c00b-35d5-44a4-9c11-f61955a52b7e"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN090", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 90", false },
                    { new Guid("05ffb1ae-3098-4292-bea8-5c304797f978"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN012", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 12", false },
                    { new Guid("0f1ff8b2-cb4f-47ba-b5a8-52b2aee6ed4d"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN033", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 33", false },
                    { new Guid("124a97f7-5d34-41af-ac30-bc2159e3b41e"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN093", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 93", false },
                    { new Guid("12d9b894-6440-4b83-96d6-e94bc28a6999"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN073", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 73", false },
                    { new Guid("14d612f5-afe3-499c-a5a9-e65ccf343f2f"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN053", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 53", false },
                    { new Guid("17038752-c57b-442b-a147-5d5fd539620f"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN004", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 4", false },
                    { new Guid("1745ef08-b9b3-4fc8-b567-4da70d1d6f53"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN027", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 27", false },
                    { new Guid("1abba436-5dc7-4391-8c5b-5d0e5a2da0cc"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN062", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 62", false },
                    { new Guid("1bd5780a-fb27-4100-994b-f78b2127f921"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN087", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 87", false },
                    { new Guid("1e24b887-00ac-4af9-8b99-cdfe0719aa74"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN081", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 81", false },
                    { new Guid("21f66624-02c9-4231-9ff4-0681b4539a18"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN024", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 24", false },
                    { new Guid("2627d703-c504-4b94-ae8e-4d09490343af"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN001", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 1", false },
                    { new Guid("28faf52a-3647-4ac3-9b6c-7217c5826dd6"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN055", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 55", false },
                    { new Guid("299fe09a-7790-4014-b87b-e3a63cf1c80a"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN035", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 35", false },
                    { new Guid("2ae4949e-c4a9-48ae-b546-bad32c91492d"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN094", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 94", false },
                    { new Guid("2e77640c-22a8-4406-9492-34d81d237c37"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN060", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 60", false },
                    { new Guid("30d52d1c-3700-4bab-b059-7bfdc34c3ce9"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN088", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 88", false },
                    { new Guid("311ebcd3-eb9d-4426-836f-0ceccb06ef75"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN066", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 66", false },
                    { new Guid("36e9709a-c691-43b6-8767-5e81f876c5e6"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN000", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 0", false },
                    { new Guid("3c9e7b95-2975-4e19-93fc-bd8e60ca8b3d"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN069", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 69", false },
                    { new Guid("3da0e5cb-5281-42ea-8f7e-7c34c6de7502"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN082", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 82", false },
                    { new Guid("3de6f0a7-219d-4e73-aabb-be24ea72c86b"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN048", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 48", false },
                    { new Guid("41920598-a1c5-4275-83b3-bbe4c4700124"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN077", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 77", false },
                    { new Guid("4316c3b0-d02a-4892-a86c-f6159bdb85d2"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN022", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 22", false },
                    { new Guid("441d30e2-d0a0-4c33-86da-93382ab96621"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN036", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 36", false },
                    { new Guid("44a999e1-9b1f-49d4-99dc-f32fe573b2e5"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN015", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 15", false },
                    { new Guid("4553ea69-c009-4d04-8903-1df72148583f"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN009", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 9", false },
                    { new Guid("4623b4d4-85c8-4e16-adf2-45758c7c2a7e"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN049", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 49", false },
                    { new Guid("4670e6f2-b623-4ec8-be41-5257a0a2301b"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN026", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 26", false },
                    { new Guid("49019fad-5df0-4441-9fb7-ff1294581ef3"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN067", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 67", false },
                    { new Guid("4a7e4e86-53c0-47ca-809f-a7ba546bc720"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN065", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 65", false },
                    { new Guid("4d5fa54c-62e3-496a-9d4a-d9b5d5d93cc5"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN029", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 29", false },
                    { new Guid("54d3b16f-6515-4962-a913-cac49384153d"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN086", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 86", false },
                    { new Guid("5576b040-83f5-47a0-a656-708748ddd36b"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN017", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 17", false },
                    { new Guid("55c36ef4-dcd4-4334-ad52-09e71ea0a74d"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN013", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 13", false },
                    { new Guid("55fbd585-a297-4216-9048-5bd57343afc0"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN074", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 74", false },
                    { new Guid("637c833d-f45b-4360-92fb-7693b144c82f"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN070", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 70", false },
                    { new Guid("6388be74-1bb9-4636-97e5-14e5e8d0e442"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN084", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 84", false },
                    { new Guid("68c1e204-78ec-429a-ace4-6edd87e60031"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN041", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 41", false },
                    { new Guid("6bdfcf52-3a94-4169-8090-2fdf8ab5209d"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN006", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 6", false },
                    { new Guid("6d74bece-4768-482c-9099-04fe30db1544"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN019", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 19", false },
                    { new Guid("6ea93590-d8b3-4ede-9b4a-e4a8963930b1"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN056", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 56", false },
                    { new Guid("7189d6c7-565c-4aae-958a-7bf60f28ce12"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN097", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 97", false },
                    { new Guid("781bd315-ef76-438a-9859-bcaa8f21cbdd"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN045", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 45", false },
                    { new Guid("7a6319c5-f28a-4b00-ae90-35c69bf59b49"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN095", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 95", false },
                    { new Guid("7bcd0722-0268-460e-8082-f3911b50f7e6"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN003", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 3", false },
                    { new Guid("80e326bc-c88b-486b-a5c9-bfa9503c4a7c"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN047", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 47", false },
                    { new Guid("82a48848-29ff-4f64-9f77-fc835fdc0ca2"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN046", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 46", false },
                    { new Guid("8446a899-4c7f-4b62-ac92-ed5320aafe6a"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN083", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 83", false },
                    { new Guid("857415f2-3411-454b-b993-d9756a3ba183"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN059", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 59", false },
                    { new Guid("85abe0dd-cdd3-400c-8044-e4f3d4d23be1"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN092", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 92", false },
                    { new Guid("86f26a9c-89f5-42fa-9cd6-02e7e5977c40"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN078", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 78", false },
                    { new Guid("884cf49d-1af7-4c60-b5d8-b7bf235601d7"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN057", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 57", false },
                    { new Guid("8abdd214-8320-4b90-93a2-22c6c791a7e3"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN014", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 14", false },
                    { new Guid("8ca828ee-baa5-4d25-83c3-8457b0e8d635"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN091", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 91", false },
                    { new Guid("8caeae22-e12e-439a-bacb-02c4a51711f3"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN044", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 44", false },
                    { new Guid("8daf313d-71b0-42b1-a5f5-887ca5e98453"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN075", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 75", false },
                    { new Guid("8ed3548e-3de2-4300-ae4f-144718a14aba"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN072", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 72", false },
                    { new Guid("8f482d48-43f6-48b9-ba09-37591381906b"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN025", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 25", false },
                    { new Guid("90b4fccd-c6e7-4b1b-a92e-9a386fb55484"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN068", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 68", false },
                    { new Guid("93f1fcaf-1cf0-4c88-be71-34b9e87a070e"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN032", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 32", false },
                    { new Guid("951da53a-b0fe-473e-b6db-464ddeb40bb8"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN016", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 16", false },
                    { new Guid("99d4c1cf-48cf-449d-8c98-3ef5492b33cc"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN043", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 43", false },
                    { new Guid("9d6f7543-c0b8-4702-817a-3d3c29a2cee4"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN008", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 8", false },
                    { new Guid("9f776d79-7c5d-4fe5-9ffa-398fc40af0e4"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN050", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 50", false },
                    { new Guid("a3b2e75b-e473-415b-a276-887e0252d211"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN096", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 96", false },
                    { new Guid("a451db38-3182-4f9b-8989-93ebc3a7d705"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN039", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 39", false },
                    { new Guid("a4ba7d42-8207-4a00-8584-622403e00bb5"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN054", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 54", false },
                    { new Guid("a514e294-7207-4f6f-86b0-ab87f4bae374"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN064", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 64", false },
                    { new Guid("a708c743-348a-4643-bc8f-961c93c64db4"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN089", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 89", false },
                    { new Guid("a991e7f6-618f-433a-97d6-68c2ed5eb03e"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN011", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 11", false },
                    { new Guid("ab2ca290-ba70-46e4-8ebc-f8d5860c8011"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN099", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 99", false },
                    { new Guid("ac05c84d-a257-4882-9f81-ddc7ae0df1a2"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN051", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 51", false },
                    { new Guid("ace8a5e0-958c-44b1-b02f-550c034b9987"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN040", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 40", false },
                    { new Guid("b4d6dee6-b2f5-49fa-b872-ff9cf6b79947"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN031", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 31", false },
                    { new Guid("b7e493fe-8ade-45eb-ac8d-29395cf2951c"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN037", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 37", false },
                    { new Guid("b8ca08b9-8c15-4d69-b43e-ef4f78f3ad91"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN030", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 30", false },
                    { new Guid("bfc06fb6-1919-4484-b046-f62ddf179690"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN052", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 52", false },
                    { new Guid("c49c15ab-2a23-4ea0-a198-16127f6f8c64"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN076", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 76", false },
                    { new Guid("c8e7b33e-a529-4dfc-859d-c813bf838f86"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN007", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 7", false },
                    { new Guid("c98101c2-5759-4f76-beaa-d41053ded26b"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN042", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 42", false },
                    { new Guid("c9b4cd05-b66b-4893-8e10-ff39b0900175"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN061", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 61", false },
                    { new Guid("ccea5603-0501-44ce-b117-938b884fb6c3"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN063", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 63", false },
                    { new Guid("d0ad8522-195f-48aa-aa72-82348c4d0d25"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN020", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 20", false },
                    { new Guid("d1ec4012-3223-48d2-aa58-24d7587fbf90"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN034", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 34", false },
                    { new Guid("d7e3467f-3605-4b97-b301-034704eb9e7d"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN079", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 79", false },
                    { new Guid("dc7b733c-72ba-4de7-9ea0-6a8693e007a2"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN018", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 18", false },
                    { new Guid("df3c427d-a17e-4646-8568-7a978091814d"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN002", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 2", false },
                    { new Guid("e1431594-0944-4437-a57c-3ccfbf8e5352"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN080", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 80", false },
                    { new Guid("e2ec19c3-fcd2-4bc0-98cf-1133515d3724"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN028", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 28", false },
                    { new Guid("eaf6fff8-5860-4368-9e93-d81f8b5951b4"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN038", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 38", false },
                    { new Guid("eba3b82a-bd54-40d0-b22e-690c68af2ed8"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN021", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 21", false },
                    { new Guid("eced80e0-3315-44b0-8a3a-ae274e296c08"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN010", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 10", false },
                    { new Guid("ee434476-97c3-41c0-838a-d7c51948f295"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN098", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 98", false },
                    { new Guid("f0cf9dea-f303-44c8-b07e-25ec8e99604a"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN085", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 85", false },
                    { new Guid("f4b29308-f0fb-44e8-92fc-8edfbb82d5af"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN071", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 71", false },
                    { new Guid("fe6a1863-5b61-42d7-abc4-b1733806a9c0"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BAN023", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024 - 23", false }
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: "29784a75-4721-4da4-b8b7-d167c588d5cf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "43a68c11-1e6a-4189-aee4-dc1a4e48f93f", "0fd45a31-56ef-49d4-961c-9b179945236a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("00ad539e-1270-4024-ae43-618c857b1c84"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("0388ebd9-6a91-43ec-9ef4-e8713876b54c"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("03b8c00b-35d5-44a4-9c11-f61955a52b7e"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("05ffb1ae-3098-4292-bea8-5c304797f978"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("0f1ff8b2-cb4f-47ba-b5a8-52b2aee6ed4d"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("124a97f7-5d34-41af-ac30-bc2159e3b41e"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("12d9b894-6440-4b83-96d6-e94bc28a6999"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("14d612f5-afe3-499c-a5a9-e65ccf343f2f"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("17038752-c57b-442b-a147-5d5fd539620f"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("1745ef08-b9b3-4fc8-b567-4da70d1d6f53"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("1abba436-5dc7-4391-8c5b-5d0e5a2da0cc"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("1bd5780a-fb27-4100-994b-f78b2127f921"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("1e24b887-00ac-4af9-8b99-cdfe0719aa74"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("21f66624-02c9-4231-9ff4-0681b4539a18"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("2627d703-c504-4b94-ae8e-4d09490343af"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("28faf52a-3647-4ac3-9b6c-7217c5826dd6"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("299fe09a-7790-4014-b87b-e3a63cf1c80a"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("2ae4949e-c4a9-48ae-b546-bad32c91492d"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("2e77640c-22a8-4406-9492-34d81d237c37"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("30d52d1c-3700-4bab-b059-7bfdc34c3ce9"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("311ebcd3-eb9d-4426-836f-0ceccb06ef75"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("36e9709a-c691-43b6-8767-5e81f876c5e6"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("3c9e7b95-2975-4e19-93fc-bd8e60ca8b3d"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("3da0e5cb-5281-42ea-8f7e-7c34c6de7502"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("3de6f0a7-219d-4e73-aabb-be24ea72c86b"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("41920598-a1c5-4275-83b3-bbe4c4700124"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("4316c3b0-d02a-4892-a86c-f6159bdb85d2"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("441d30e2-d0a0-4c33-86da-93382ab96621"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("44a999e1-9b1f-49d4-99dc-f32fe573b2e5"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("4553ea69-c009-4d04-8903-1df72148583f"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("4623b4d4-85c8-4e16-adf2-45758c7c2a7e"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("4670e6f2-b623-4ec8-be41-5257a0a2301b"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("49019fad-5df0-4441-9fb7-ff1294581ef3"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("4a7e4e86-53c0-47ca-809f-a7ba546bc720"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("4d5fa54c-62e3-496a-9d4a-d9b5d5d93cc5"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("54d3b16f-6515-4962-a913-cac49384153d"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("5576b040-83f5-47a0-a656-708748ddd36b"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("55c36ef4-dcd4-4334-ad52-09e71ea0a74d"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("55fbd585-a297-4216-9048-5bd57343afc0"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("637c833d-f45b-4360-92fb-7693b144c82f"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("6388be74-1bb9-4636-97e5-14e5e8d0e442"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("68c1e204-78ec-429a-ace4-6edd87e60031"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("6bdfcf52-3a94-4169-8090-2fdf8ab5209d"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("6d74bece-4768-482c-9099-04fe30db1544"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("6ea93590-d8b3-4ede-9b4a-e4a8963930b1"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("7189d6c7-565c-4aae-958a-7bf60f28ce12"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("781bd315-ef76-438a-9859-bcaa8f21cbdd"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("7a6319c5-f28a-4b00-ae90-35c69bf59b49"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("7bcd0722-0268-460e-8082-f3911b50f7e6"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("80e326bc-c88b-486b-a5c9-bfa9503c4a7c"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("82a48848-29ff-4f64-9f77-fc835fdc0ca2"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("8446a899-4c7f-4b62-ac92-ed5320aafe6a"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("857415f2-3411-454b-b993-d9756a3ba183"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("85abe0dd-cdd3-400c-8044-e4f3d4d23be1"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("86f26a9c-89f5-42fa-9cd6-02e7e5977c40"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("884cf49d-1af7-4c60-b5d8-b7bf235601d7"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("8abdd214-8320-4b90-93a2-22c6c791a7e3"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("8ca828ee-baa5-4d25-83c3-8457b0e8d635"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("8caeae22-e12e-439a-bacb-02c4a51711f3"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("8daf313d-71b0-42b1-a5f5-887ca5e98453"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("8ed3548e-3de2-4300-ae4f-144718a14aba"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("8f482d48-43f6-48b9-ba09-37591381906b"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("90b4fccd-c6e7-4b1b-a92e-9a386fb55484"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("93f1fcaf-1cf0-4c88-be71-34b9e87a070e"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("951da53a-b0fe-473e-b6db-464ddeb40bb8"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("99d4c1cf-48cf-449d-8c98-3ef5492b33cc"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("9d6f7543-c0b8-4702-817a-3d3c29a2cee4"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("9f776d79-7c5d-4fe5-9ffa-398fc40af0e4"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("a3b2e75b-e473-415b-a276-887e0252d211"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("a451db38-3182-4f9b-8989-93ebc3a7d705"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("a4ba7d42-8207-4a00-8584-622403e00bb5"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("a514e294-7207-4f6f-86b0-ab87f4bae374"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("a708c743-348a-4643-bc8f-961c93c64db4"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("a991e7f6-618f-433a-97d6-68c2ed5eb03e"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("ab2ca290-ba70-46e4-8ebc-f8d5860c8011"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("ac05c84d-a257-4882-9f81-ddc7ae0df1a2"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("ace8a5e0-958c-44b1-b02f-550c034b9987"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("b4d6dee6-b2f5-49fa-b872-ff9cf6b79947"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("b7e493fe-8ade-45eb-ac8d-29395cf2951c"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("b8ca08b9-8c15-4d69-b43e-ef4f78f3ad91"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("bfc06fb6-1919-4484-b046-f62ddf179690"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("c49c15ab-2a23-4ea0-a198-16127f6f8c64"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("c8e7b33e-a529-4dfc-859d-c813bf838f86"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("c98101c2-5759-4f76-beaa-d41053ded26b"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("c9b4cd05-b66b-4893-8e10-ff39b0900175"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("ccea5603-0501-44ce-b117-938b884fb6c3"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("d0ad8522-195f-48aa-aa72-82348c4d0d25"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("d1ec4012-3223-48d2-aa58-24d7587fbf90"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("d7e3467f-3605-4b97-b301-034704eb9e7d"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("dc7b733c-72ba-4de7-9ea0-6a8693e007a2"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("df3c427d-a17e-4646-8568-7a978091814d"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("e1431594-0944-4437-a57c-3ccfbf8e5352"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("e2ec19c3-fcd2-4bc0-98cf-1133515d3724"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("eaf6fff8-5860-4368-9e93-d81f8b5951b4"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("eba3b82a-bd54-40d0-b22e-690c68af2ed8"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("eced80e0-3315-44b0-8a3a-ae274e296c08"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("ee434476-97c3-41c0-838a-d7c51948f295"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("f0cf9dea-f303-44c8-b07e-25ec8e99604a"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("f4b29308-f0fb-44e8-92fc-8edfbb82d5af"));

            migrationBuilder.DeleteData(
                table: "Boloes",
                keyColumn: "Id",
                keyValue: new Guid("fe6a1863-5b61-42d7-abc4-b1733806a9c0"));

            migrationBuilder.InsertData(
                table: "Boloes",
                columns: new[] { "Id", "CampeonatoAnualId", "Codigo", "CriadoEm", "DonoId", "Titulo", "Updated" },
                values: new object[,]
                {
                    { new Guid("3d80aad3-54df-40f6-911e-b47d0254050a"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "BANESE", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Banese 2024", false },
                    { new Guid("a979e67e-0313-46ff-b952-91568c6767fd"), new Guid("70eb28a3-833f-4a63-8d6f-b1dcf9660111"), "JUNCOS", new DateTime(2024, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "29784a75-4721-4da4-b8b7-d167c588d5cf", "Bolão do Junco", false }
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: "29784a75-4721-4da4-b8b7-d167c588d5cf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "40775525-ea1d-4e6f-bfe4-f0c23461b250", "d9f30982-33ec-4282-8cd5-b1adee7bb54a" });
        }
    }
}
