using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace mvc_project_camp.Controllers
{
	public class ContactController : Controller
	{
		ContactManager cm = new ContactManager(new EfContactDal());
		ContactValidator cv = new ContactValidator();
		public IActionResult Index()
		{
			var contactvalues = cm.GetList();
			return View(contactvalues);
		}

		public IActionResult GetContactDetails(int id)
		{
			var contactvalue = cm.GetByID(id);
			return View(contactvalue);
		}
		public PartialViewResult MessageListMenu()
		{
			return PartialView();
		}
	}
}
