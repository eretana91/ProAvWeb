using Microsoft.AspNetCore.Mvc;

namespace TareaSemana2.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Games()
        {
            return View();
        }

        public IActionResult Movies()
        {
            return View();
        }
    }
}
