using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JogosVintageWebApplication.Data;
using JogosVintageWebApplication.Models;

namespace JogosVintageWebApplication.Pages.Jogo
{
    public class CreateModel : PageModel
    {
        private readonly JogosVintageWebApplication.Data.JogosVintageWebApplicationContext _context;

        public CreateModel(JogosVintageWebApplication.Data.JogosVintageWebApplicationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Jogos Jogos { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Jogos == null || Jogos == null)
            {
                return Page();
            }

            _context.Jogos.Add(Jogos);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
