using Domain.Library.Base;
using Domain.Library.Base.IEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities
{
    [Table("SystemLogger", Schema = "LOG")]
    public class SystemLogger : GeneralEntity
    {
        public string Event { get; set; }
        public string Exception { get; set; }
        public string Error { get; set; }
        public string Service { get; set; }
        public string Method { get; set; }
        public string Model { get; set; }
        public bool IsSuccess { get; set; }
        public override string ToString()
        {

            return $@"عملیات با عنوان '{Title}'
                    و توضیحات '{Description}'
                    در رویداد '{Event}'
                    برای سرویس '{Service}'
                    مدل '{Model}'
                    در متد '{Method}'
                    با این وضعیت '{(IsSuccess ? "موفق" : "ناموفق")}'
                    اجرا شده و خطای '{Error}'
                    , اعتراض '{Exception}' اجرا شد";
        }
    }
}
