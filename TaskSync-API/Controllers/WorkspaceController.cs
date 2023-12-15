using Microsoft.AspNetCore.Mvc;

namespace TaskSync_API.Controllers
{
    public class WorkspaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}