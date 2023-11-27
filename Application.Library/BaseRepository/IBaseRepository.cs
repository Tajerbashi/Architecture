using Application.Library.ModelBase.BaseDTOModel;
using Application.Library.ModelBase.BaseViewModel;
using Domain.Library.Bases;

namespace Application.Library.BaseRepository
{
    public interface IBaseRepository<T>
        :IDisposable
        where T : BaseDTO
    {
        object Create(T model);
        void CreateList(IEnumerable<T> models);
        object Update(T model,object ID);
        object Update(T model,Guid guid);
        object Update(IEnumerable<T> models);
        T Read(object Id);
        T Read(Guid guid);
        List<T> ReadAll();
        object Remove(Guid guid);
        bool ChangeActive(Guid guid);
        bool ChangeActive(object ID);
        object Remove(T model);
        object Remove(object ID);
    }
}
