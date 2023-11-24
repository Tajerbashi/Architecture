using System.ComponentModel;

namespace Domain.Library.Enums
{
    public enum GenderTypeEnum : byte
    {
        [Description("مذکر")]
        MALE = 0,
        [Description("مونث")]
        FEMALE= 1,
    }
}
