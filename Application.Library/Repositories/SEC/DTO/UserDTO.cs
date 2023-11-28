using Application.Library.ModelBase.BaseDTOModel;
using Domain.Library.Enums;
using System.Security.Claims;

namespace Application.Library.Repositories.SEC.DTO
{
    public class UserDTO : BaseDTO
    {
        /// <summary>
        /// نام
        /// </summary>
        public string FirstName { set; get; }
        /// <summary>
        /// فامیلی
        /// </summary>
        public string LastName { set; get; }
        /// <summary>
        /// جنسیت
        /// </summary>
        public GenderTypeEnum Gender { set; get; }
        /// <summary>
        /// کد ملی
        /// </summary>
        public string NationalCode { set; get; }
        /// <summary>
        /// آواتار
        /// </summary>
        public string AvatarFile { set; get; }
        /// <summary>
        /// امضاء
        /// </summary>
        public string SignFile { set; get; }
        /// <summary>
        /// نام کاربری
        /// </summary>
        public string UserName { set; get; }
        /// <summary>
        /// نام کاربری معمولی
        /// </summary>
        public string NormalizedUserName { set; get; }
        /// <summary>
        /// جنسیت
        /// </summary>
        public string Email { set; get; }
        /// <summary>
        /// ایمیل
        /// </summary>
        public string NormalizedEmail { set; get; }
        /// <summary>
        /// ایمیل تایید شد؟
        /// </summary>
        public bool EmailConfirmed { set; get; }
        /// <summary>
        /// هش پسورد
        /// </summary>
        public string PasswordHash { set; get; }
        /// <summary>
        /// نقش امنیتی
        /// </summary>
        public string SecurityStamp { set; get; }
        /// <summary>
        /// نقش همزمانی
        /// </summary>
        public string ConcurrencyStamp { set; get; }
        /// <summary>
        /// شماره تلفن
        /// </summary>
        public string PhoneNumber { set; get; }
        /// <summary>
        /// تایید تلقن
        /// </summary>
        public bool PhoneNumberConfirmed { set; get; }
        /// <summary>
        /// احراز هویت دوگانه
        /// </summary>
        public bool TwoFactorEnabled { set; get; }
        /// <summary>
        /// پایان فقل
        /// </summary>
        public DateTime LockoutEnd { set; get; }
        /// <summary>
        /// قفل
        /// </summary>
        public bool LockoutEnabled { set; get; }
        /// <summary>
        /// تعداد درخواست
        /// </summary>
        public int AccessFailedCount { set; get; }

        public List<Claim> Claims { get; set; }
    }
}
