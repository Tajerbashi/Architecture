using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Library.Bases
{
    public interface IEntity<T>
    {
        T ID { set; get; }
        DateTime CreateDate { set; get; }
        T CreatedByUserRoleID { set; get; }
        bool IsDeleted { set; get; }
    }
    public interface IEntity : IEntity<long>
    {

    }
}
