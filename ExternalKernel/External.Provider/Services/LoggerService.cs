using External.Provider.ContextData;
using External.Provider.Models;
using External.Provider.Repositories;

namespace External.Provider.Services
{
    public class LoggerService : ILoggerRepository
    {
        public LoggerService()
        {
        }
        public void Add()
        {
            ApplicationContext.LogData.Add
                (
                 new LogModel
                 {
                     Id = 1,
                     Service = "logger",
                     Method = "Add",
                     Param = new { },
                     RequestTime = DateTime.Now,
                     ResponseTime = DateTime.Now,
                     Url = "https://localhost:8080/Home/Index",
                 }
                );
        }

        public LogModel Read()
        {
            throw new NotImplementedException();
        }

        public List<LogModel> ReadAll()
        {
            return ApplicationContext.LogData.ToList();
        }
    }
}
