using Microsoft.AspNetCore.Mvc;

namespace Simulation.MVC.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
