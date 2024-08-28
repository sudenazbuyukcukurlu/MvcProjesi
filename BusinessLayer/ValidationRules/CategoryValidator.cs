using EntityLayer;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator() 
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("açıkalmayı boş geçemezsiniz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("En az 3 karakter girişi yapabilirsiniz");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("En fazla 20 karakter girişi yapabilirsiniz");
        }

        public ValidationResult Validate(Category p)
        {
            throw new NotImplementedException();
        }
    }
}
