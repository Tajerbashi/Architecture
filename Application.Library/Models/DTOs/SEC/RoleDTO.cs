using Application.Library.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Library.Models.DTOs.SEC
{
    public class RoleDTO : BaseDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
