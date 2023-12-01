using External.Provider.Models;

namespace External.Provider.Repositories
{
    public interface ILoggerRepository
    {
        void Add();
        LogModel Read();
        List<LogModel> ReadAll();
    }
}
