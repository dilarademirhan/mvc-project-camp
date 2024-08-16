using Microsoft.AspNetCore.Mvc;

namespace mvc_project_camp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
