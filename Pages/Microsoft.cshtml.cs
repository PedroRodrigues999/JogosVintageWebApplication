using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JogosVintageWebApplication.Pages
{
    public class MicrosoftModel : PageModel
    {
        private readonly ILogger<MicrosoftModel> _logger;

        public MicrosoftModel(ILogger<MicrosoftModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}