using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace mvc_project_camp.Controllers
{
	public class MessageController : Controller
	{
		MessageManager mm = new MessageManager(new EfMessageDal());
		public IActionResult Inbox()
		{
			var messagelist = mm.GetListInbox();
			return View(messagelist);
		}

        public IActionResult Sendbox()
        {
            var messagelist = mm.GetListSendbox();
            return View(messagelist);
        }

        public IActionResult GetInboxMessageDetails(int id)
        {
            var value = mm.GetById(id);
            return View(value);
        }

        [HttpGet]
		public IActionResult NewMessage()
		{
			return View();
		}

		[HttpPost]
		public IActionResult NewMessage(Message message)
		{
			return View();
		}

	}
}
