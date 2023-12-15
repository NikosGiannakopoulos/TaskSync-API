using Microsoft.AspNetCore.Mvc;

namespace TaskSync_API.Controllers
{
    public class StageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}