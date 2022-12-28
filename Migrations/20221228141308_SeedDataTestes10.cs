using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JogosVintageWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataTestes10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "idioma",
                table: "Jogos",
                newName: "Idioma");

            migrationBuilder.InsertData(
                table: "Consolas",
                columns: new[] { "ID", "Ano", "Descrição", "Imagem", "Name", "Processador", "RAM", "Saida" },
                values: new object[,]
                {
                    { 3, 1983, "O Nintendo Entertainment System (NES, popularmente chamado de Nintendinho no Brasil) é um console de videogame de 8 bits lançado pela Nintendo na América do Norte, Europa, Ásia, Austrália e Brasil. Originalmente lançado no Japão em 1983 com o nome de Nintendo Family Computer", "lib\\img\\Consolas\\Console1.jpg", "NES", "8 bits", "2 KiB + memória RAM expandida (se presente no cartucho).", "Modulador RF." },
                    { 4, 2022, "Teste1234", "Teste", "Text", "Teste2", "Teste", "Modulador RF." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Consolas",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Consolas",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "Idioma",
                table: "Jogos",
                newName: "idioma");
        }
    }
}
