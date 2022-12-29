using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JogosVintageWebApplication.Pages
{
    public class AtariModel : PageModel
    {
        private readonly ILogger<AtariModel> _logger;

        public AtariModel(ILogger<AtariModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
