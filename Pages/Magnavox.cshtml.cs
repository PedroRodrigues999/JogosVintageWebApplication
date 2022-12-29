using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JogosVintageWebApplication.Pages
{
    public class MagnavoxModel : PageModel
    {
        private readonly ILogger<MagnavoxModel> _logger;

        public MagnavoxModel(ILogger<MagnavoxModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}