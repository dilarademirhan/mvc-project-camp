using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace mvc_project_camp.Controllers
{
    public class WriterPanelContentController : Controller
    {
        ContentManager cm = new ContentManager(new EfContentDal());
        public IActionResult MyContent()
        {
            var contentValues = cm.GetListByWriter();
            return View(contentValues);
        }
    }
}
