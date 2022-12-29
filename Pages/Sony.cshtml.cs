using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JogosVintageWebApplication.Pages
{
    public class SonyModel : PageModel
    {
        private readonly ILogger<SonyModel> _logger;

        public SonyModel(ILogger<SonyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
