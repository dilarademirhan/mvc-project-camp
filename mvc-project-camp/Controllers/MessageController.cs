using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;

namespace mvc_project_camp.Controllers
{
	public class MessageController : Controller
	{
		MessageManager mm = new MessageManager(new EfMessageDal());
		MessageValidator validationRules = new MessageValidator();
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

		public IActionResult GetSendboxMessageDetails(int id)
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
			ValidationResult results = validationRules.Validate(message);
			if (results.IsValid)
			{
				message.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
				mm.MessageAdd(message);
				return RedirectToAction("Sendbox");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}

	}
}
