using Application.Library.Bases;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Application.Library.Models.Views.SEC
{
    public class UserView : BaseView
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public byte Age { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateDatePersion { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateDatePersion { get; set; }
        public DateTime DeleteDate { get; set; }
        public string DeleteDatePersion { get; set; }
        public long CreatedByUserRoleID { get; set; }


    }
}
