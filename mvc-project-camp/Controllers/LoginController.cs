using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace mvc_project_camp.Controllers
{
	[AllowAnonymous]
	public class LoginController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(Admin admin)
		{
			Context c = new Context();
			var adminuserinfo = c.Admins.FirstOrDefault(x => x.AdminUserName == admin.AdminUserName && x.AdminPassword == admin.AdminPassword);

			if (adminuserinfo != null)
			{
				var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name, adminuserinfo.AdminUserName)
				};

				var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
				await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

				HttpContext.Session.SetString("AdminUserName", adminuserinfo.AdminUserName);
				return RedirectToAction("Index", "AdminCategory");
			}
			else
			{
				ViewBag.Hata = "Kullanıcı adı ya da şifre yanlış.";
				return View();
			}
		}

		[HttpPost]
		public async Task<IActionResult> LogOut()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			HttpContext.Session.Clear();
			return RedirectToAction("Index");
		}
	}
}
