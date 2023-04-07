using DeskShiraz.Models;

namespace DeskShiraz.Services
{
    public interface ITeacherServices
    {
        bool Insert(Teacher teacher);
        bool Update(int Id, Teacher teacher);
        bool Delete(int Id);
        Teacher Read(int Id);
        Teacher Read(string Name);
        IEnumerable<Teacher> ReadAll();
        void Save();
    }
}
