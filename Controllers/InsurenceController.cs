using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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
        [HttpPost]
        public async Task<IActionResult>SIP(SIPModel obj)
        {
            if (ModelState.IsValid) { 
            await _SIPService .AddAsync(obj);
            return RedirectToAction("SIPList");
            }
            return View(obj);
        }
        public async Task <IActionResult> SIPList()
        {
            var data = await _SIPService.GetAllDataAsync();
            return View(data);
        }
        [HttpPost]
        public async Task <IActionResult> SIPDataDelete(int Id)
        {
            await _SIPService.DeleteAsync(Id);
            return RedirectToAction("SIPlist");
        }
        public IActionResult Health()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Health(HealthModel obj)
        {
            if (ModelState.IsValid)
            {
                await _healthService.AddAsync(obj);
                return RedirectToAction("HelthList");
            }
            return View(obj);
        }
        public async Task <IActionResult> HelthList()
        {
            var data = await _healthService.GetAllDataAsync();
            return View(data);
        }
        public async Task <IActionResult> HelthDataDelete(int id)
        {
            await _healthService.DeleteAsync(id);
            return RedirectToAction("HelthList");
        }
        public IActionResult Retairement()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Retairement(RetirementModel obj)
        {
            if (ModelState.IsValid)
            {
                await _retirementService.AddAsync(obj);
                return RedirectToAction("RetairementList");
            }
            return View(obj);
        }
        public async Task <IActionResult> RetairementList()
        {
            var data = await _retirementService.GetAllDataAsync();
            return View(data);
        }
        [HttpPost]
        public async Task <IActionResult> RetairementDataDelete(int id)
        {
            await _retirementService.DeleteAsync(id);
            return RedirectToAction("RetairementList");
        }
        public IActionResult Travel()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Travel(TravelModel obj)
        {
            if (ModelState.IsValid) {
                await _travelService.AddAsync(obj);
                return RedirectToAction("TravelList");
            }
            return View(obj);
        }
        
        public async Task<IActionResult> TravelList()
        {
            var data = await _travelService.GetAllDataAsync();
            
            return View(data);
        }
        [HttpPost]
        public async Task <IActionResult> TravelDataDelete(int TravelId)
        {
            await _travelService.DeleteAsync(TravelId);
            return View();
        }
        public IActionResult life()
        {
            LifeInsurenceModel obj = new  LifeInsurenceModel();
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
        [HttpPost]
        public async Task <IActionResult> Car(CarModel obj)
        {
            if (ModelState.IsValid)
            {
                await _carService.AddAsync(obj);
                return RedirectToAction("CarList");
            }
            return View(obj);
        }
        public async Task <IActionResult> CarList()
        {
            var data = await _carService.GetAllDataAsync();
            return View(data);
        }
        public async Task <IActionResult> CardataDelete(int Id)
        {
            await _carService.DeleteAsync(Id);
            return RedirectToAction("CarList");
        }
        public IActionResult Fire()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Fire(FireModel obj)
        {
            if (ModelState.IsValid)
            {
                await _fireService.AddAsync(obj);
                return RedirectToAction("FireList");
            }
            return View(obj);
        }
        public async Task <IActionResult> FireList()
        {
           var data= await _fireService.GetAllDataAsync();
            return View(data);
        }
        [HttpPost]
        public async Task <IActionResult> FireDataDelete(int PolicyId)
        {
            await _fireService.DeleteAsync(PolicyId);
            return RedirectToAction("CarList");
        }
        public IActionResult Property()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Property(PropertyModel obj)
        {
            if (ModelState.IsValid)
            {
                await _propertyService.AddAsync(obj);
                return RedirectToAction("PropertyList");
            }
            return View(obj);
        }
        public async Task <IActionResult> PropertyList()
        {
            var data = await _propertyService.GetAllDataAsync();
            return View(data);
        }
        [HttpPost]
        public async Task <IActionResult> PropertyDataDelete(int id)
        {
            await _propertyService.DeleteAsync(id);
            return RedirectToAction("PropertyList");
        }
        public IActionResult Commercial()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Commercial(CommercialModel obj)
        {
            if (ModelState.IsValid) { 
            await _commercialService.AddAsync(obj);
            return RedirectToAction("CommercialList");
            }
            return View();
        }
        public async Task <IActionResult> CommercialList()
        {
            var data = await _commercialService.GetAllDataAsync();
            return View(data);
        }
        [HttpPost]
        public async Task <IActionResult> CommercialDataDelete(int PolicyId)
        {
            await _commercialService.DeleteAsync(PolicyId);
            return RedirectToAction("CommercialList");
        }
        public IActionResult MoneyBackPolicy()
        {
            return View();
        }
        public IActionResult Marine()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Marine(MarineInsuranceModel obj) 
        {
            if (ModelState.IsValid)
            {
                await _marineService.AddAsync(obj);
                return RedirectToAction("MarineList");
            }
            return View(obj);
        }
        public async Task <IActionResult> MarineList()
        {
            var data = await _marineService.GetAllDataAsync();
            return View(data);
        }
        public async Task <IActionResult>  MarineDataDelete(int PolicyId)
        {
            await _marineService.DeleteAsync(PolicyId);
            return RedirectToAction("MarineList");
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
