using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }
        [StringLength(50)]
        public int WriterName { get; set; }
        [StringLength(50)]
        public int WriterSurName { get; set; }
        [StringLength(150)]
        public int WriterImage { get; set; }
        [StringLength(50)]
        public int WriterMail { get; set; }
        [StringLength(25)]
        public int WriterPassword { get; set; }

        //bire çok ilişki
        public ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}
