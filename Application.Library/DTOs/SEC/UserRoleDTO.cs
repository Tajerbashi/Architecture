using Application.Library.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Library.DTOs
{
    public class UserRoleDTO : BaseDTO
    {
        public long UserID { get; set; }
        public long RoleID { get; set; }
    }
}
