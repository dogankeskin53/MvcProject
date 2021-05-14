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
    public class CategoryController : Controller
    {

        // GET: Category
        /// <summary>
        /// Business sınıfından Category manager çağrılır.
        /// </summary>
        /// <returns></returns>
        CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());


        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// View eklemesi yapıyoruz. Göstermek için.
        /// </summary>
        /// <returns></returns>
        public ActionResult GetCategoryList()
        {
            //var values = categoryManager.GetAllCategoryBL();
            var values = categoryManager.Getlist();            
            return View(values);
        }

        /// <summary>
        /// Sayfa yüklendiği zaman http get çalışacak.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult AddCategory()
        { 
            return View();
        }

        /// <summary>
        /// Herhangi bir butona tıklanınca Post methodu devreye girer.
        /// Kategori eklenip ve gösterilme actiona gönderiliyor
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            //categoryManager.CategoryAddBL(p);
            //actiona geri dönüyoruz.

            CategoryValidatior categoryValidatior = new CategoryValidatior();

            //Parametreden gelen değerleri, categoryValidatior a deki kurallara göre karşılaştır .
            ValidationResult results = categoryValidatior.Validate(p);
            if (results.IsValid)
            {
                categoryManager.CategortAdd(p);
                return RedirectToAction("GetCategoryList");

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