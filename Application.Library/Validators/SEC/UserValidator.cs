using Application.Library.Models.DTOs.SEC;
using FluentValidation;

namespace Application.Library.Validators
{
    public class UserValidator : AbstractValidator<UserDTO>
    {
        public UserValidator()
        {
            RuleFor(user => user.Name).NotEmpty().WithMessage("Name is required.");
            RuleFor(user => user.Age).InclusiveBetween(18, 99).WithMessage("Age must be between 18 and 99.");
        }
    }
}
