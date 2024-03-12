using Blogy.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BussinessLayer.ValidationRules.CategoryValidation
{
    public class CreateCategoryValidation : AbstractValidator<Category>
    {
        public CreateCategoryValidation()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Can not be empty!");
            RuleFor(c => c.Name).MinimumLength(3).WithMessage("Can be min 3 length!");
            RuleFor(c => c.Name).MaximumLength(30).WithMessage("Can be max 30 length!");
        }
    }
}
