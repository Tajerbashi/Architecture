﻿using Application.Library.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Library.DTOs
{
    public class UserDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
