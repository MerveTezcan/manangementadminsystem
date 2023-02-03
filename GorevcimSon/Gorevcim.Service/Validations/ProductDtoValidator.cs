using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Gorevcim.Core.DTOs;
using Gorevcim.Core.Services;

namespace Gorevcim.Service.Validations
{
    public class ProductDtoValidator : AbstractValidator<ProductDto>
    {
        public ProductDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.SalePrice).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} 0 dan büyük olması gerekiyor");
           // RuleFor(x => x.CategoryId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName}  kategori Id 0 olamaz");
        }
    }
}
