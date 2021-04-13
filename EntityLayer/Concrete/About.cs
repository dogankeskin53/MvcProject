using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        /// <summary>
        /// Key attirube ataması yapılır. 
        /// NugetPage EntityFramework Eklenir.
        /// using DataAnnotations 
        /// veritabanı uzunlukları belirlenir.
        /// </summary>


        [Key]
        public int AboutId { get; set; }
        [StringLength(1500)]
        public string AboutDetails1 { get; set; }
        [StringLength(1500)]
        public string AboutDetails2 { get; set; }
        [StringLength(100)]
        public string AboutImage1 { get; set; }
        [StringLength(100)]
        public string AboutImage2 { get; set; }
    }
}
