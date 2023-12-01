using External.Provider.Models;
using External.Provider.Models.Enums;

namespace External.Provider.ContextData
{
    public static class ApplicationContext
    {
        public static List<LogModel> LogData = new List<LogModel>()
        {
            new LogModel
            {
                Id = 1,
                Service="Main",
                Method  = "Index",
                Param = new {},
                RequestTime = DateTime.Now,
                ResponseTime = DateTime.Now,
                Url="https://localhost:8080/Home/Index",
                Username = "Main",
                Model = HttpMode.None
            }
        };

        public static List<Contact> Contacts = new List<Contact>()
        {
            new Contact
            {
                ContactID = 1,
                OwnerID = "",
                Name = "Kamran" ,
                Family = "Tajerbashi",
            }
        };

    }
}
