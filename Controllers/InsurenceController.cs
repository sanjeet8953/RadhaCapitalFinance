using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RadhaCapitalFinance.Core.Entities;
using RadhaCapitalFinance.Core.Interfaces;

namespace RadhaCapitalFinance.Controllers
{
    public class InsurenceController : Controller
    {
        private readonly IGenericService<FinanceModel> _financeService;
        private readonly IGenericService<HealthModel> _healthService;
        private readonly IGenericService<CarModel> _carService;
        private readonly IGenericService<CommercialModel> _commercialService;
        private readonly IGenericService<FireModel> _fireService;
        private readonly IGenericService<LifeInsurenceModel> _lifeService;
        private readonly IGenericService<MarineInsuranceModel> _marineService;
        private readonly IGenericService<PropertyModel> _propertyService;
        private readonly IGenericService<RetirementModel> _retirementService;
        private readonly IGenericService<SIPModel> _SIPService;
        private readonly IGenericService<TravelModel> _travelService;

        public InsurenceController(
            IGenericService<FinanceModel> financeService,
            IGenericService<HealthModel> helthService,
            IGenericService<CarModel> carService,
            IGenericService<CommercialModel> commercialService,
            IGenericService<LifeInsurenceModel> lifeService,
            IGenericService<MarineInsuranceModel> marineService,
            IGenericService<PropertyModel> propertyService,
            IGenericService<RetirementModel> retirementService,
            IGenericService<SIPModel> sipService,
            IGenericService<TravelModel> travelService,
            IGenericService<FireModel> fireService
            )
        {
            _financeService = financeService;
            _healthService = helthService;
            _carService = carService;
            _commercialService = commercialService;
            _fireService = fireService;
            _lifeService = lifeService;
            _marineService = marineService;
            _propertyService = propertyService;
            _retirementService = retirementService;
            _SIPService = sipService;
            _travelService = travelService;
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
        public async Task<IActionResult> Finence(FinanceModel obj)
        {
            if (ModelState.IsValid)
            {
                await _financeService.AddAsync(obj);
                return RedirectToAction("List");
            }
            ViewBag.Products = InsurenceType();
            return View(obj);
        }

        public async Task<IActionResult> List()
        {
            var data = await _financeService.GetAllDataAsync();
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {

            await _financeService.DeleteAsync(id);
            return RedirectToAction("List");
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
            LifeInsurenceModel obj = new LifeInsurenceModel();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Life(LifeInsurenceModel obj)
        {
            if (ModelState.IsValid)
            {
                await _lifeService.AddAsync(obj);
                return RedirectToAction("LifeList");
            }

            return View(obj);
        }
        public async Task<IActionResult>LifeList()
        {
            var data = await _lifeService.GetAllDataAsync();
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> LifeDataDelete(int PolicyId)
        {
            await _lifeService.DeleteAsync(PolicyId);
            return RedirectToAction("LifeList");

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
