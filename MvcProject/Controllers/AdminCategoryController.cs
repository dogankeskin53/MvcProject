using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccesLayer.EntityFrameWork;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
        // GET: AdminCategory
        public ActionResult Index()
        {
            var categoryValues = categoryManager.Getlist();
            return View(categoryValues);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidatior categoryValidator = new CategoryValidatior();
            ValidationResult validationResult = categoryValidator.Validate(p);

            /// eğer kural geçerli ise
            if (validationResult.IsValid)
            {
                categoryManager.CategortAdd(p);
                //action adına indexe yönlendir
                return RedirectToAction("Index"); 
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }

            return View();
        }
    }
 
}