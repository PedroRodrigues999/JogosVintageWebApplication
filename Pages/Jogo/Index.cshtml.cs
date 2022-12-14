using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JogosVintageWebApplication.Data;
using JogosVintageWebApplication.Models;

namespace JogosVintageWebApplication.Pages.Jogo
{
    public class IndexModel : PageModel
    {
        private readonly JogosVintageWebApplication.Data.JogosVintageWebApplicationContext _context;

        public IndexModel(JogosVintageWebApplication.Data.JogosVintageWebApplicationContext context)
        {
            _context = context;
        }

        public IList<Jogos> Jogos { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Jogos != null)
            {
                Jogos = await _context.Jogos.ToListAsync();
            }
        }
    }
}
