using Application.Library.Models.DTOs.SEC;
using FluentValidation;

namespace Application.Library.Validators
{
    public class UserValidator : AbstractValidator<UserDTO>
    {
        public UserValidator()
        {
            CascadeMode = CascadeMode.Stop;
            RuleFor(user => user.Name)//.Cascade(CascadeMode.Stop)
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
            //  Use When Methods
            //RuleFor(user => user.Email)
            //   .NotEmpty().NotNull()
            //   .WithMessage("ایمیل خالی است")
            //   .MaximumLength(100).WithMessage("حداکثر ایمیل 100 حرف است")
            //   .MinimumLength(5).WithMessage("حداقل ایمیل 5 حرف است")
            //   .EmailAddress().WithMessage("فرمت ایمیل اشتباه است")
            //   .Matches(@"^(([^<>()[\]\\.,;:\s@\""]+"
            //          + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
            //          + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
            //          + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
            //          + @"[a-zA-Z]{2,}))$").WithMessage("فرمت ایمیل اشتباه است")
            //   ;

            //RuleFor(user => user.Phone)
            //   .NotEmpty().NotNull()
            //   .WithMessage("تلفن خالی است")
            //   .MaximumLength(11).WithMessage("فرمت اشتباه است")
            //   .MinimumLength(11).WithMessage("فرمت اشتباه است")
            //   ;
            RuleFor(user => user.Address)
                .MaximumLength(100).When(x => x.Address != null).WithMessage("آدرس بیش از حد طولانی است")
                .MinimumLength(5).When(x => x.Address != null).WithMessage("آدرس دقیق تر وارد کنید")
               ;
            When(x => !string.IsNullOrEmpty(x.Phone), () =>
            {
                RuleFor(user => user.Phone).NotEmpty().NotNull().Matches(@"^0(9\d{9})$");
                RuleFor(x => x.Email).Null();
            }).Otherwise(() =>
            {
                RuleFor(x => x.Email).NotEmpty().EmailAddress();
                RuleFor(x => x.Phone).Null();
            });
            RuleFor(user => user.Age)
                 .NotEmpty().NotNull().WithMessage("سن خالی است")
                ;
        }
    }
}
