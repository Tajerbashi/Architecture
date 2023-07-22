using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Library.Bases
{
    public abstract class BaseEntity:IEntity
    {
        public DateTime CreateDate { get; set; }
        public long CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public long UpdateBy { get; set; }
        public DateTime DeleteDate { get; set; }
        public long DeleteBy { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;
    }
}
