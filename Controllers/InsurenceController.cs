using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RadhaCapitalFinance.Models;

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
            FinanceModel obj = new FinanceModel();
            ViewBag.Products = InsurenceType();
            return View(obj);
        }
        [HttpPost]
        public IActionResult Finence(FinanceModel obj)
        {
            try
            {
                if (ModelState.IsValid)
                {

                }
            }
            catch (Exception ex)
            {

            }
            ViewBag.Products = InsurenceType();
            return View(obj);
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
        public IActionResult life()
        {
            return View();
        }
        public IActionResult Car()
        {
            return View();
        }
        public IActionResult Fire()
        {
            return View();
        }
        public IActionResult Property()
        {
            return View();
        }
        public IActionResult Commercial()
        {
            return View();
        }

        private List<SelectListItem> InsurenceType()
        {
            var insurencelist = new List<SelectListItem>
             {
            new SelectListItem { Text = "Health Insurance", Value = "Health Insurance" },
            new SelectListItem { Text = "Car Insurance", Value = "Car Insurance" },
            new SelectListItem { Text = "Life Insurance", Value = "Life Insurance" },
            new SelectListItem { Text = "Travel Insurance", Value = "Travel Insurance" }
             };
            return insurencelist;
        }
    }
}
