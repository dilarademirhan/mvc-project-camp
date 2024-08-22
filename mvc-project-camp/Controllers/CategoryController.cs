using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace mvc_project_camp.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(); 
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetAllBL();
            return View(categoryvalues);
        }
    }
}
