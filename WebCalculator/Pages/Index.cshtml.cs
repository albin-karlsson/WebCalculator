using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebCalculator.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        public string? CalcMethod { get; set; }
        public float FirstNumber { get; set; }
        public float SecondNumber { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}
