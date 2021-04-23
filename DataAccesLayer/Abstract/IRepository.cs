using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    /// <summary>
    /// Entitiy Layer Klasörü altında oluşturduğumuz 
    /// Bir Entity'i 
    /// IRepository ye verip tüm işlemleri burada yapacağız
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity>
    {
        List<TEntity> List();
        /// <summary>
        /// Kategori Eklemek için
        /// </summary>
        /// <param name="p"></param>
        void Insert(TEntity p);

        /// <summary>
        /// Güncelleme işlemleri
        /// </summary>
        /// <param name="p"></param>
        void Update(TEntity p);

        /// <summary>
        /// Silme işlemleri
        /// </summary>
        /// <param name="p"></param>
        void Delete(TEntity p);

        /// <summary>
        /// Şartlı listeleme
        /// Veritabanında bir veri çağırırken filter işlemi ile çağırabiliyoruz.
        /// Örnek, İsmi Ali olanları listele gibi.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        List<TEntity> List(Expression<Func<TEntity,bool>> filter);
    }
}
