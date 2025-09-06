using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RadhaCapitalFinance.Models;

namespace RadhaCapitalFinance.Controllers
{
    public class InsurenceController : Controller
    {
        private readonly FinanceDBContext financeDB;

        public InsurenceController(FinanceDBContext financeDB)
        {
            this.financeDB = financeDB;
        }

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
        public async Task <IActionResult> Finence(FinanceModel obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await financeDB.Insurance.AddAsync(obj);
                  await financeDB.SaveChangesAsync();
                    return RedirectToAction("List", "Insurence");
                }
            }
            catch (Exception)
            {

            }
            ViewBag.Products = InsurenceType();
            return View(obj);
        }

        public async Task <IActionResult> List()
        {
            var CustData = await financeDB.Insurance.ToListAsync();
            return View(CustData);
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
        public IActionResult MoneyBackPolicy()
        {
            return View();
        }
        public IActionResult Marine()
        {
            return View();
        }
        public IActionResult HUF()
        {
            return View();
        }
        public IActionResult MWP()
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
