using External.Provider.Client.Extentions;
using External.Provider.Client.Models.Enums;

namespace External.Provider.Client.Models
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string OwnerID { get; set; }
    }
    public class LogModel
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Url { get; set; }
        public string Service { get; set; }
        public string Method { get; set; }
        public object Param { get; set; }
        public HttpMode Model { get; set; }
        public DateTime RequestTime { get; set; }
        public string RequestTimePersian { get => DateConvertor.ConvertPersian(RequestTime); }
        public DateTime ResponseTime { set; get; }
        public string ResponseTimePersian { get => DateConvertor.ConvertPersian(ResponseTime); }
        public override string ToString()
        {
            if (Model == HttpMode.Request)
            {
                return ($@"کاربر فوق با نام کاربری {Username} و لینک فوق {Url} متد {Method} از سرویس {Service} را همراه با پاراماتر های ذیل {Param} در تاریخ {RequestTimePersian} درخواست کرده است");
            }
            else if (Model == HttpMode.Response)
            {
                return ($@"کاربر فوق با نام کاربری {Username} و لینک فوق {Url} متد {Method} از سرویس {Service} را همراه با پاراماتر های ذیل {Param} در تاریخ {ResponseTimePersian} پاسخ دریافت کرده است");
            }
            else
            {
                return ($@"کاربر فوق با نام کاربری 0 و لینک فوق 0 متد 0 از سرویس 0 را همراه با پاراماتر های ذیل 0 در تاریخ 0 درخواست کرده است");
            }
        }
    }

}
