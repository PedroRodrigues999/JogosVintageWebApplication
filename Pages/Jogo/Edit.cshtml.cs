using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JogosVintageWebApplication.Data;
using JogosVintageWebApplication.Models;

namespace JogosVintageWebApplication.Pages.Jogo
{
    public class EditModel : PageModel
    {
        private readonly JogosVintageWebApplication.Data.JogosVintageWebApplicationContext _context;

        public EditModel(JogosVintageWebApplication.Data.JogosVintageWebApplicationContext context)
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

            var jogos =  await _context.Jogos.FirstOrDefaultAsync(m => m.ID == id);
            if (jogos == null)
            {
                return NotFound();
            }
            Jogos = jogos;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Jogos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JogosExists(Jogos.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool JogosExists(int id)
        {
          return (_context.Jogos?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
