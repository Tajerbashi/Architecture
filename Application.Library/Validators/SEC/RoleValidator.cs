using Application.Library.Models.DTOs;
using FluentValidation;

namespace Application.Library.Validators
{
    public class RoleValidator : AbstractValidator<RoleDTO>
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
