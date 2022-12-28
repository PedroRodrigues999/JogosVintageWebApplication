using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JogosVintageWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Consolas",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Consolas",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Consolas",
                columns: new[] { "ID", "Ano", "Descrição", "Imagem", "Name", "Processador", "RAM", "Saida" },
                values: new object[,]
                {
                    { 1, 1983, "O Nintendo Entertainment System (NES, popularmente chamado de Nintendinho no Brasil) é um console de videogame de 8 bits lançado pela Nintendo na América do Norte, Europa, Ásia, Austrália e Brasil. Originalmente lançado no Japão em 1983 com o nome de Nintendo Family Computer", "lib\\img\\Consolas\\Console1.jpg", "NES", "8 bits", "2 KiB + memória RAM expandida (se presente no cartucho).", "Modulador RF." },
                    { 2, 1988, "Consola de vídeo jogo de 16 bits, desenvolvido e comercializado pela Sega sendo um sucessor do Master System. O console foi lançado em 1988 no Japão como Mega Drive e em 1989 na América do Norte como Genesis.", "lib\\img\\Consolas\\Console2.jpg", "Mega Drive", "16 bits", "64KB", "Modulador RF." }
                });

            migrationBuilder.InsertData(
                table: "Jogos",
                columns: new[] { "ID", "Descrição", "Idioma", "Imagem", "Modelo", "Name", "Plataforma" },
                values: new object[,]
                {
                    { 1, "Jogo eletrônico de plataforma desenvolvido pela Nintendo Research & Development 4 e publicado pela Nintendo para o Famicom em 1985 no Japão e para o Nintendo Entertainment System (NES) em 1985 e 1987 na América do Norte e Europa.", "Inglês", "lib\\img\\Jogos\\Jogo1.jpg", "NES", "Super Mario", "Nintendo" },
                    { 2, "Jogo eletrônico de beat 'em up que foi desenvolvido e publicado pela Sega para o Mega Drive. Foi lançado nos Estados Unidos em 31 de dezembro de 1990 e no Japão no dia 2 de agosto de 1991.", "Inglês", "lib\\img\\Jogos\\Jogo2.jpg", "Mega Drive", "Streets of Rage", "Sega" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Consolas",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Consolas",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jogos",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jogos",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Consolas",
                columns: new[] { "ID", "Ano", "Descrição", "Imagem", "Name", "Processador", "RAM", "Saida" },
                values: new object[,]
                {
                    { 3, 1983, "O Nintendo Entertainment System (NES, popularmente chamado de Nintendinho no Brasil) é um console de videogame de 8 bits lançado pela Nintendo na América do Norte, Europa, Ásia, Austrália e Brasil. Originalmente lançado no Japão em 1983 com o nome de Nintendo Family Computer", "lib\\img\\Consolas\\Console1.jpg", "NES", "8 bits", "2 KiB + memória RAM expandida (se presente no cartucho).", "Modulador RF." },
                    { 4, 2022, "Teste1234", "Teste", "Text", "Teste2", "Teste", "Modulador RF." }
                });
        }
    }
}
