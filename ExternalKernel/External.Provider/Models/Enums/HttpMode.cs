using System.ComponentModel;

namespace External.Provider.Models.Enums
{
    public enum HttpMode:byte
    {
        [Description("درون برنامه یی")]
        None = 0,
        [Description("درخواست")]
        Request = 1,
        [Description("پاسخ")]
        Response = 2,
    }
}
