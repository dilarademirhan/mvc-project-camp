using Microsoft.AspNetCore.Mvc;

namespace mvc_project_camp.Controllers
{
	public class MessageController : Controller
	{
		public IActionResult Inbox()
		{
			return View();
		}
	}
}
