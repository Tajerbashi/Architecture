using Application.Library.Bases;

namespace Application.Library.Models.Views
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
