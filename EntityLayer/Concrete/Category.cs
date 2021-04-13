using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        /// <summary>
        /// CategoryStatus aktif veya pasiflik koyuyoruz çünkü, 
        /// silersek category header kısımları da gider dolayısıyla sayfa içeriği de gider.
        /// </summary>
        /// 
        [Key]
        public int CategoryId { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        [StringLength(200)]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }


        public ICollection<Heading> Headings { get; set; }

    }
}
