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
    public class DeleteModel : PageModel
    {
        private readonly JogosVintageWebApplication.Data.JogosVintageWebApplicationContext _context;

        public DeleteModel(JogosVintageWebApplication.Data.JogosVintageWebApplicationContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Jogos Jogos { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Jogos == null)
            {
                return NotFound();
            }

            var jogos = await _context.Jogos.FirstOrDefaultAsync(m => m.ID == id);

            if (jogos == null)
            {
                return NotFound();
            }
            else 
            {
                Jogos = jogos;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Jogos == null)
            {
                return NotFound();
            }
            var jogos = await _context.Jogos.FindAsync(id);

            if (jogos != null)
            {
                Jogos = jogos;
                _context.Jogos.Remove(Jogos);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
