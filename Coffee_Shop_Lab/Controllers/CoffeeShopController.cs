using Coffee_Shop_Lab.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_Lab.Controllers
{
    public class CoffeeShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegistrationView() 
        {
            return View();
        }
        public IActionResult HandleRegistration(Registration registration) 
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("RegistrationView");
            }
            return RedirectToAction("Summary", registration);
        }

        public IActionResult Summary(Registration registration) 
        {
            return View(registration);
        }
    }
}
