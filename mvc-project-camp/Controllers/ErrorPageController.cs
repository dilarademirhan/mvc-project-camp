using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcProjeKampi.Controllers
{
	public class ErrorPageController : Controller
	{
		public IActionResult Page403()
		{
			Response.StatusCode = 403;
			return View();
		}

		public IActionResult Page404()
		{
			Response.StatusCode = 404;
			return View();
		}

	}
}
