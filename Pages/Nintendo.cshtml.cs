using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JogosVintageWebApplication.Pages
{
    public class NintendoModel : PageModel
    {
        private readonly ILogger<NintendoModel> _logger;

        public NintendoModel(ILogger<NintendoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
