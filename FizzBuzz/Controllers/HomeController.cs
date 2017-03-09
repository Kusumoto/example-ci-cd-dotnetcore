using Microsoft.AspNetCore.Mvc;
using FizzBuzz.ViewModels;
using FizzBuzz.Service;

namespace FizzBuzz.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new FizzBuzzCriteriaViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Calculate(FizzBuzzCriteriaViewModel model)
        {
            if (ModelState.IsValid == true)
            {
                var service = new FizzBuzzService();
                model.Result = service.GetFizzBuzzResult(model.InputNumber);
                return View(model);
            }
            return View(model);
        }
    }
}
