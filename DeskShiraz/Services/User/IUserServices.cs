using DeskShiraz.Models;

namespace DeskShiraz.Services
{
    public interface IUserServices
    {
        bool Insert(User user);
        bool Update(int Id,User user);
        bool Delete(int Id);
        User Read(int Id);
        User Read(string Name);
        IEnumerable<User> ReadAll();
        void Save();
    }
}
