using Blogy.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BussinessLayer.ValidationRules.ArticleValidation
{
    public class CreateArticleValidation : AbstractValidator<Article>
    {
        public CreateArticleValidation() 
        {
            RuleFor(a => a.CategoryId).NotEmpty().WithMessage("Can not be empty!");
            RuleFor(a => a.Title).NotEmpty().WithMessage("Need typing title");
        }
    }
}
