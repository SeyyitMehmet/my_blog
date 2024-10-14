using Entitylayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator() 
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Burayı boş geçemezsiniz");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Burayı boş geçemezsiniz");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Burayı boş geçemezsiniz");
        }

      
    }
}
