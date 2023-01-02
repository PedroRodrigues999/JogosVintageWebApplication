using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JogosVintageWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class Final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consolas",
                keyColumn: "ID",
                keyValue: 1,
                column: "Descrição",
                value: "A Nintendo Entertainment System (NES) é uma consola de videojogos de 8 bits lançada pela Nintendo na América do Norte, Europa, Ásia, Austrália e Brasil. Originalmente lançada no Japão em 1983 com o nome de Nintendo Family Computer.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consolas",
                keyColumn: "ID",
                keyValue: 1,
                column: "Descrição",
                value: "Videojogo de plataforma desenvolvido pela Nintendo para o Famicom em 1985 no Japão e para o Nintendo Entertainment System (NES) em 1985 e 1987 na América do Norte e Europa.");
        }
    }
}
