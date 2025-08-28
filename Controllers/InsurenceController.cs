using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RadhaCapitalFinance.Controllers
{
    public class InsurenceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Finence()
        {
            ViewBag.Products = new List<SelectListItem>
{
            new SelectListItem { Text = "Health Insurance", Value = "Health Insurance" },
            new SelectListItem { Text = "Car Insurance", Value = "Car Insurance" },
            new SelectListItem { Text = "Life Insurance", Value = "Life Insurance" },
            new SelectListItem { Text = "Travel Insurance", Value = "Travel Insurance" }
        };
            return View();


        }
        public IActionResult SIP()
        {
            return View();
        }
        public IActionResult Health()
        {
            return View();
        }
        public IActionResult Retairement()
        {
            return View();
        }
        public IActionResult Travel()
        {
            return View();
        }
    }
}
