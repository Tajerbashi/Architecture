using System.Globalization;

namespace External.Provider.Client.Extentions
{
    public static class DateConvertor
    {
        public static string ToPersian(this DateTime date,string format="")
        {
            return date.ToPersian(format);
        } 
        public static string ConvertPersian(this DateTime date,string format="")
        {
            var calendar = new PersianCalendar();
            var persianDate = new DateTime(calendar.GetYear(date), calendar.GetMonth(date), calendar.GetDayOfMonth(date));
            var result = persianDate.ToString(format, CultureInfo.GetCultureInfo("fa-Ir"));
            return date.ToPersian(format);
        } 
        public static string ConvertToPersian(this DateTime date,string format="")
        {
            PersianCalendar pc = new PersianCalendar();
            return string.Format("{0}/{1}/{2}", pc.GetYear(date), pc.GetMonth(date), pc.GetDayOfMonth(date));
        }
        public static DateTime ToGregorian(this string date)
        {
            string[] d = date.Split('/');
            return new DateTime(int.Parse(d[0]), int.Parse(d[1]), int.Parse(d[2]), new HijriCalendar());
        }
    }
}
