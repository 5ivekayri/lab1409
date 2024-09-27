using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Pages.Shared
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            PersonalComputer OptiPlex = new PersonalComputer("Intel", 8, 512, "Windows", "GTX650");
            return View();
        }
    }
}
