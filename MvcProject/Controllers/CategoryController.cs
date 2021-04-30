using BusinessLayer.Concrete;
using EntityLayer.Concrete;
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
        CategoryManager cm = new CategoryManager();


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
            var values = cm.GetAllCategoryBL();
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
            cm.CategoryAddBL(p);
            return RedirectToAction("GetCategoryList");
        }
    }
}