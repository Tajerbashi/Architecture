using Application.Library.Models.DTOs.SEC;
using FluentValidation;

namespace Application.Library.Validators
{
    public class UserValidator : AbstractValidator<UserDTO>
    {
        public UserValidator()
        {
            RuleFor(user => user.Name)
                .NotEmpty().NotNull()
                .WithMessage("نام خالی است")
                .MaximumLength(50).WithMessage("حداکثر نام 50 حرف است")
                .MinimumLength(3).WithMessage("حداقل نام 3 حرف است")
                ;
            RuleFor(user => user.Family)
               .NotEmpty().NotNull()
               .WithMessage("فامیل خالی است")
               .MaximumLength(50).WithMessage("حداکثر فامیل 50 حرف است")
               .MinimumLength(3).WithMessage("حداقل فامیل 3 حرف است")
               ;
            RuleFor(user => user.DisplayName)
               .NotEmpty().NotNull()
               .WithMessage("نام کامل خالی است")
               .MaximumLength(100).WithMessage("حداکثر نام کامل 100 حرف است")
               .MinimumLength(5).WithMessage("حداقل نام کامل 50 حرف است")
               ;
            RuleFor(user => user.Email)
               .NotEmpty().NotNull()
               .WithMessage("ایمیل خالی است")
               .MaximumLength(100).WithMessage("حداکثر ایمیل 100 حرف است")
               .MinimumLength(5).WithMessage("حداقل ایمیل 5 حرف است")
               .EmailAddress().WithMessage("فرمت ایمیل اشتباه است")
               .Matches(@"^(([^<>()[\]\\.,;:\s@\""]+"
                      + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                      + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
                      + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                      + @"[a-zA-Z]{2,}))$").WithMessage("فرمت ایمیل اشتباه است")
               ;
            RuleFor(user => user.Phone)
               .NotEmpty().NotNull()
               .WithMessage("تلفن خالی است")
               .MaximumLength(11).WithMessage("فرمت اشتباه است")
               .MinimumLength(11).WithMessage("فرمت اشتباه است")
               ;
            RuleFor(user => user.Address)
               .NotEmpty().NotNull()
               .WithMessage("آدرس خالی است")
               .MaximumLength(100).WithMessage("حداکثر آدرس 100 حرف است")
               ;
            RuleFor(user => user.Age)
                 .NotEmpty().NotNull().WithMessage("سن خالی است")
                ;
        }
    }
}
