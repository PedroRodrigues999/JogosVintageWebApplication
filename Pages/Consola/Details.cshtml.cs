using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JogosVintageWebApplication.Data;
using JogosVintageWebApplication.Models;

namespace JogosVintageWebApplication.Pages.Consola
{
    public class DetailsModel : PageModel
    {
        private readonly JogosVintageWebApplication.Data.JogosVintageWebApplicationContext _context;

        public DetailsModel(JogosVintageWebApplication.Data.JogosVintageWebApplicationContext context)
        {
            _context = context;
        }

      public Consolas Consolas { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Consolas == null)
            {
                return NotFound();
            }

            var consolas = await _context.Consolas.FirstOrDefaultAsync(m => m.ID == id);
            if (consolas == null)
            {
                return NotFound();
            }
            else 
            {
                Consolas = consolas;
            }
            return Page();
        }
    }
}
