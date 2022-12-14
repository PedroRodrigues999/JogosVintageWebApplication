using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JogosVintageWebApplication.Data;
using JogosVintageWebApplication.Models;

namespace JogosVintageWebApplication.Pages.Consola
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
        public Consolas Consolas { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Consolas == null || Consolas == null)
            {
                return Page();
            }

            _context.Consolas.Add(Consolas);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
