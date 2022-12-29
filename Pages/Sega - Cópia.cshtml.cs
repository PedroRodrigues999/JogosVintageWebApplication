using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JogosVintageWebApplication.Pages
{
    public class SegaModel : PageModel
    {
        private readonly ILogger<SegaModel> _logger;

        public SegaModel(ILogger<SegaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
