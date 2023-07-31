using Application.Library.Models.DTOs.SEC;
using FluentValidation;

namespace Application.Library.Validators
{
    public class UserValidator : AbstractValidator<UserDTO>
    {
        public UserValidator()
        {
            RuleFor(user => user.Name).NotEmpty().WithMessage("نام خالی است");
        }
    }
}
