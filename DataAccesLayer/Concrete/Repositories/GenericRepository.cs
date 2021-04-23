using DataAccesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.Repositories
{
    /// <summary>
    /// ctor TAB ile Class ismiyle aynı bir GenericRepository oluşur.
    /// </summary>
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        Context c = new Context();
        DbSet<TEntity> _Object;

        /// <summary>
        /// Hangi Entity Class geldiğini bulmamız lazım? 
        /// Constructor Method : Class ismiyle aynı olan yapıcı bir method
        /// Contect Sınıfına gelen Entity değeri bizim objectimiz olacaktır.
        /// </summary>
        public GenericRepository()
        {            
            _Object = c.Set<TEntity>();
        }

        public void Delete(TEntity p)
        {
            _Object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(TEntity p)
        {
            _Object.Add(p);
            c.SaveChanges();
        }

        public List<TEntity> List()
        {
            return _Object.ToList();
        }

        public List<TEntity> List(Expression<Func<TEntity, bool>> filter)
        {
            return _Object.Where(filter).ToList();
        }

        public void Update(TEntity p)
        {
            c.SaveChanges();
        }
    }
}
