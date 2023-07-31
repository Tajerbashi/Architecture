using Application.Library.Models.DTOs.SEC;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Library.Validators
{
    public class RoleValidator: AbstractValidator<RoleDTO>
    {
        public RoleValidator()
        {
            RuleFor(c => c.Title)
                .NotNull().NotEmpty().WithMessage("عنوان نقش خالی است")
                .MaximumLength(20).WithMessage("عنوان حداکثر 20 حرف است")
                .MinimumLength(2).WithMessage("عنوان حداقل 2 حرف است")
                ;
        }
    }
}
