using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        //key mutlaka olmalı yoksa hata verir.
        [Key]
        public int ContentID { get; set; }
        [StringLength(1500)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        ///contentin Yazari
        ///contentin başlığı
        ///


        //ilişkili alandan geldiği için değerlere dokunmaya gerek yok.
        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }


        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }

    }
}
