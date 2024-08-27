using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace mvc_project_camp.Controllers
{
	public class HeadingController : Controller
	{
		HeadingManager hm = new HeadingManager(new EfHeadingDal());
		public IActionResult Index()
		{
			var headingvalues = hm.GetList();
			return View(headingvalues);
		}
	}
}
