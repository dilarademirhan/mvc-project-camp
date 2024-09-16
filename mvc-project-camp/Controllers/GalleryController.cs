using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace mvc_project_camp.Controllers
{
	public class GalleryController : Controller
	{
		ImageFileManager ifm = new ImageFileManager(new EfImageFileDal());
		public IActionResult Index()
		{
			var files = ifm.GetList();
			return View(files);
		}
	}
}
