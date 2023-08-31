using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Library.Base.IDTOs
{
    public interface IBaseDTO
    {
    }
    public class BaseDTO<T>:IBaseDTO
    {
        public T ID { get; set; }
        public Guid Guid { get; set; }

    }
    public class BaseDTO:BaseDTO<long>
    {
        public Guid CreateUserRoleGuid { get; set; }
        public Guid UpdateUserRoleGuid { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
    public class ResultDto<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
