using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    /// <summary>
    /// AbstractValidator using kullanılır ,
    /// hangi sınıfı kullanacak isek o verilir.
    /// </summary>
    public class CategoryValidatior:AbstractValidator<Category>
    {
        /// <summary>
        /// Yapıcı Method
        /// Kurallar yapıcı methotlara yapılır.
        /// </summary>
        public CategoryValidatior()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategory adı dolu olmalıdır.");    
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklama bilgisi girmek zorundasınız.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter giriniz.");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("En fazla 20 karakter girebilirsiniz.");
        }
    }
}
