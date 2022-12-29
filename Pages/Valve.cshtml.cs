using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JogosVintageWebApplication.Pages
{
    public class ValveModel : PageModel
    {
        private readonly ILogger<ValveModel> _logger;

        public ValveModel(ILogger<ValveModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
