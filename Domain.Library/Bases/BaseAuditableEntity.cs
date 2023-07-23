using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Library.Bases
{
    public abstract class BaseAuditableEntity<T> : BaseEntity, IAuditableEntity
    {
        public T ID { get; set; }

    }
    public abstract class BaseAuditableEntity : BaseAuditableEntity<long>
    {

    }


}
