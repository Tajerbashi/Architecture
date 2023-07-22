using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Library.Bases
{
    public interface IBaseView
    {
    }
    public abstract class IBaseView<T> : IBaseView
    {
        public T ID { get; set; }
    }
    public abstract class BaseView : IBaseView<long>
    {
        public DateTime CreateDate { get; set; }
        public long CreateBy { get; set; }

        public DateTime DeleteDate { get; set; }
        public long DeleteBy { get; set; }

        public DateTime UpdateDate { get; set; }
        public long UpdateBy { get; set; }
    }
}
