﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace mvc_project_camp.Controllers
{
	public class AdminCategoryController : Controller
	{
		CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
		public IActionResult Index()
		{
			var categoryValues = categoryManager.GetList();
			return View(categoryValues);
		}
		[HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
		public IActionResult AddCategory(Category category)
		{
			CategoryValidator categoryValidator = new CategoryValidator();
			ValidationResult results = categoryValidator.Validate(category);
			if(results.IsValid) 
			{ 
				categoryManager.CategoryAdd(category);
				return RedirectToAction("Index");
			}
			else
			{
				foreach(var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}
		public IActionResult DeleteCategory(int id)
		{
			var categoryValue = categoryManager.GetById(id);
			categoryManager.CategoryDelete(categoryValue);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult EditCategory(int id)
		{
            var categoryValue = categoryManager.GetById(id);
			return View(categoryValue);
        }

		[HttpPost]
		public IActionResult EditCategory(Category category)
		{
			categoryManager.CategoryUpdate(category);
			return RedirectToAction("Index");
		}
	}
}
