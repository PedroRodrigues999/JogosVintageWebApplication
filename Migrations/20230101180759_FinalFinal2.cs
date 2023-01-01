using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JogosVintageWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class FinalFinal2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consolas",
                keyColumn: "ID",
                keyValue: 1,
                column: "Descrição",
                value: "Videojogo de plataforma desenvolvido pela Nintendo para o Famicom em 1985 no Japão e para o Nintendo Entertainment System (NES) em 1985 e 1987 na América do Norte e Europa.");

            migrationBuilder.UpdateData(
                table: "Consolas",
                keyColumn: "ID",
                keyValue: 2,
                column: "Descrição",
                value: "Consola de videojogos de 16 bits, desenvolvida e comercializada pela Sega sendo a sucessora da Master System. A consola foi lançada em 1988 no Japão como Mega Drive e em 1989 na América do Norte como Genesis.");

            migrationBuilder.UpdateData(
                table: "Jogos",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Descrição", "Name" },
                values: new object[] { "Videojogo de plataforma desenvolvido pela Nintendo para o Famicom em 1985 no Japão e para o Nintendo Entertainment System (NES) em 1985 e 1987 na América do Norte e Europa.", "Super Mario Bros" });

            migrationBuilder.UpdateData(
                table: "Jogos",
                keyColumn: "ID",
                keyValue: 2,
                column: "Descrição",
                value: "Videojogo de beat 'em up, desenvolvido e publicado pela Sega para a Mega Drive. Foi lançado nos Estados Unidos em 31 de dezembro de 1990 e no Japão no dia 2 de agosto de 1991.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consolas",
                keyColumn: "ID",
                keyValue: 1,
                column: "Descrição",
                value: "O Nintendo Entertainment System (NES, popularmente chamado de Nintendinho no Brasil) é um console de videogame de 8 bits lançado pela Nintendo na América do Norte, Europa, Ásia, Austrália e Brasil. Originalmente lançado no Japão em 1983 com o nome de Nintendo Family Computer");

            migrationBuilder.UpdateData(
                table: "Consolas",
                keyColumn: "ID",
                keyValue: 2,
                column: "Descrição",
                value: "Consola de vídeo jogo de 16 bits, desenvolvido e comercializado pela Sega sendo um sucessor do Master System. O console foi lançado em 1988 no Japão como Mega Drive e em 1989 na América do Norte como Genesis.");

            migrationBuilder.UpdateData(
                table: "Jogos",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Descrição", "Name" },
                values: new object[] { "Jogo eletrônico de plataforma desenvolvido pela Nintendo Research & Development 4 e publicado pela Nintendo para o Famicom em 1985 no Japão e para o Nintendo Entertainment System (NES) em 1985 e 1987 na América do Norte e Europa.", "Super Mario" });

            migrationBuilder.UpdateData(
                table: "Jogos",
                keyColumn: "ID",
                keyValue: 2,
                column: "Descrição",
                value: "Jogo eletrônico de beat 'em up que foi desenvolvido e publicado pela Sega para o Mega Drive. Foi lançado nos Estados Unidos em 31 de dezembro de 1990 e no Japão no dia 2 de agosto de 1991.");
        }
    }
}
