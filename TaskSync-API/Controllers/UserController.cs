using Microsoft.AspNetCore.Mvc;

namespace TaskSync_API.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}