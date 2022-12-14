using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JogosVintageWebApplication.Models;

namespace JogosVintageWebApplication.Data
{
    public class JogosVintageWebApplicationContext : DbContext
    {
        public JogosVintageWebApplicationContext (DbContextOptions<JogosVintageWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<JogosVintageWebApplication.Models.Consolas> Consolas { get; set; } = default!;

        public DbSet<JogosVintageWebApplication.Models.Jogos> Jogos { get; set; } = default!;
    }
}
