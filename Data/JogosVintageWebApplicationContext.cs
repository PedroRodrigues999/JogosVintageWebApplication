using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JogosVintageWebApplication.Models;
using static System.Net.Mime.MediaTypeNames;

namespace JogosVintageWebApplication.Data
{
    public class JogosVintageWebApplicationContext : DbContext
    {
        public JogosVintageWebApplicationContext(DbContextOptions<JogosVintageWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<JogosVintageWebApplication.Models.Consolas> Consolas { get; set; } = default!;

        public DbSet<JogosVintageWebApplication.Models.Jogos> Jogos { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Consolas>().HasData(
                new Consolas
                {

                    ID =1,
                    Imagem = "lib\\img\\Consolas\\Console1.jpg",
                    Name = "NES",
                    Descrição = "A Nintendo Entertainment System (NES) é uma consola de videojogos de 8 bits lançada pela Nintendo na América do Norte, Europa, Ásia, Austrália e Brasil. Originalmente lançada no Japão em 1983 com o nome de Nintendo Family Computer.",
                    Processador = "8 bits",
                    RAM = "2 KiB + memória RAM expandida (se presente no cartucho).",
                    Saida = "Modulador RF.",
                    Ano = 1983


                },
                new Consolas
                {
                    ID = 2,
                    Imagem = "lib\\img\\Consolas\\Console2.jpg",
                    Name = "Mega Drive",
                    Descrição = "Consola de videojogos de 16 bits, desenvolvida e comercializada pela Sega sendo a sucessora da Master System. A consola foi lançada em 1988 no Japão como Mega Drive e em 1989 na América do Norte como Genesis.",
                    Processador = "16 bits",
                    RAM = "64KB",
                    Saida = "Modulador RF.",
                    Ano = 1988
                }

                );

            modelBuilder.Entity<Jogos>().HasData(
                new Jogos
                {

                    ID = 1,
                    Imagem = "lib\\img\\Jogos\\Jogo1.jpg",
                    Name = "Super Mario Bros",
                    Descrição = "Videojogo de plataforma desenvolvido pela Nintendo para o Famicom em 1985 no Japão e para o Nintendo Entertainment System (NES) em 1985 e 1987 na América do Norte e Europa.",
                    Plataforma = "Nintendo",
                    Modelo = "NES",
                    Idioma = "Inglês"

                },
                new Jogos
                {
                    ID=2,
                    Imagem = "lib\\img\\Jogos\\Jogo2.jpg",
                    Name = "Streets of Rage",
                    Descrição = "Videojogo de beat 'em up, desenvolvido e publicado pela Sega para a Mega Drive. Foi lançado nos Estados Unidos em 31 de dezembro de 1990 e no Japão no dia 2 de agosto de 1991.",
                    Plataforma = "Sega",
                    Modelo = "Mega Drive",
                    Idioma = "Inglês"
                }

                );



        }




    }
}