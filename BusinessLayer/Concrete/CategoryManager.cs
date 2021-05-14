using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        /// <summary>
        /// Bir Field oluşturduk.
        /// </summary>
        ICategoryDal _ICategoryDal;

        /// <summary>
        /// Yapıcı Category manager Method
        /// Amaç generic repository newlemekten kaçınarak
        /// mümkün olduğunda interface kullanarak bağımlılıktan uzaklaşmak.
        /// </summary>
        /// <param name="CategoryDal"></param>
        public CategoryManager(ICategoryDal CategoryDal)
        {
            _ICategoryDal = CategoryDal;
        }

        public void CategortAdd(Category category)
        {
            _ICategoryDal.Insert(category);
        }

        public List<Category> Getlist()
        {
            return _ICategoryDal.List();
        }







        /// <summary>
        /// GenericRepository Interface ye Entity clasımızı verip onun fonksiyonlarını kullanabiliyoruz.
        /// </summary>

        //GenericRepository<Category> repoCategory = new GenericRepository<Category>();

        //public List<Category> GetAllCategoryBL()
        //{
        //    return repoCategory.List();
        //}

        //public void CategoryAddBL(Category p)
        //{ 

        //    if (p.CategoryName == "" || p.CategoryName.Length < 3 || p.CategoryDescription == "" || p.CategoryName.Length > 50)
        //    {
        //        //Hata mesajı gelmesi lazım.
        //    }
        //    else
        //    {
        //        repoCategory.Insert(p);
        //    }
        //}
    }
}
