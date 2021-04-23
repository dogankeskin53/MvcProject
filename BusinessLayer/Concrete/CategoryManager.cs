using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        /// <summary>
        /// GenericRepository Interface ye Entity clasımızı verip onun fonksiyonlarını kullanabiliyoruz.
        /// </summary>
        GenericRepository<Category> repoCategory = new GenericRepository<Category>();

        public List<Category> GetAllBL()
        {
            return repoCategory.List();
        }

        public void CategoryAddBL(Category p)
        {
            if (p.CategoryName=="" || p.CategoryName.Length < 3 || p.CategoryDescription=="" || p.CategoryName.Length > 50)
            {
                //Hata mesajı gelmesi lazım.
            }
            else
            {
                repoCategory.Insert(p);                
            }
        }

    }
}
