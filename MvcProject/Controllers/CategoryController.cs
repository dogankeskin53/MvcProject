using BusinessLayer.Concrete;
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
            var values = cm.GetAllBL();
            return View(values);
        }
    }
}