using Blogy.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BussinessLayer.ValidationRules.CategoryValidation
{
    public class UpdateCategoryValidation : AbstractValidator<Category>
    {
        public UpdateCategoryValidation()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Can not be empty!").MinimumLength(3).WithMessage("min 3 lenght").MaximumLength(30).WithMessage("max 30 length").Equal("a").WithMessage("use in a");
        }
    }
}
