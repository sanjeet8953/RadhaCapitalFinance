using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RadhaCapitalFinance.Core.Entities;
using RadhaCapitalFinance.Core.Interfaces;

namespace RadhaCapitalFinance.Controllers
{
    public class AdminController : Controller
    {
        private readonly IGenericService<AdminModel> _adminModel;

        public AdminController(IGenericService<AdminModel> adminModel)
        {
            _adminModel = adminModel;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Ragistration()
        {
            //var role = HttpContext.Session.GetString("UserRole");
            //if (role != "Admin")
            //{
            //    return RedirectToAction("Login", "Admin"); 
            //}

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Ragistration(AdminModel obj)
        {
           
                if (obj.Id == 0)
                {
                    await _adminModel.AddAsync(obj);
                }
                else
                {
                    await _adminModel.UpdateAsync(obj);
                }

                return RedirectToAction("RagistrationList");
        }

        public async Task <IActionResult> RagistrationList()
        {
             var data  = await _adminModel.GetAllDataAsync();

            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> AdminEdit(int? id)
        {
            AdminModel model;

            if (id == null || id == 0)
            {
                model = new AdminModel();
            }
            else
            {
                model = await _adminModel.GetByIdAsync(id.Value) ?? new AdminModel();
            }
            return View("Ragistration", model);
        }

        [HttpPost]
        public async Task <IActionResult> AdminDataDelete(int Id)
        {
            await _adminModel.DeleteAsync(Id);
            return RedirectToAction("RagistrationList");
        }
        public async Task <IActionResult> UpdateData(AdminModel obj)
        {
            await _adminModel.AddAsync(obj);
            return RedirectToAction("RagistrationList");
        }
        public IActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel obj)
        {
            if (ModelState.IsValid)
            {
                var allUser = await _adminModel.GetAllDataAsync();

                var user = allUser.FirstOrDefault(x =>
                         x.Email == obj.UserId
                      && x.Password == obj.Password);

                if (user != null)
                {
                    //HttpContext.Session.SetString("UserRole", user.Role); 
                    //HttpContext.Session.SetString("UserEmail", user.Email);

                    return RedirectToAction("Ragistration", "Admin");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid UserId or Password");
                    return View(obj);
                }
            }
            return View(obj);
        }

        public IActionResult Dashbord()
        {
            return View();
        }
    }
}
