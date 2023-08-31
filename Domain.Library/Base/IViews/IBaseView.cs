using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Library.Base.IViews
{
    public interface IBaseView
    {
    }
    public class BaseView<T> : IBaseView
    {
        public T ID { get; set; }
        public Guid Guid { get; set; }

    }
    public class BaseView : BaseView<long>
    {
        public Guid CreateUserRoleGuid { get; set; }
        public Guid UpdateUserRoleGuid { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
    public class ResultView<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
