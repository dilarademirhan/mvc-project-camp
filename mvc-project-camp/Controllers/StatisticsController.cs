using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace mvc_project_camp.Controllers
{
    public class StatisticsController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetCategoriesNumber()
        {
            int total = cm.GetList().Count();
            return View(total);
        }

    }
}
