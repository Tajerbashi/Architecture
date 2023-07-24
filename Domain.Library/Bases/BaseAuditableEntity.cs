using Domain.Library.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Bases
{
    public abstract class BaseAuditableEntity<T> : BaseEntity, IAuditableEntity
    {
        [Column(TypeName = "datetime2")]
        public DateTime UpdateDate { get; set; }
        //[ForeignKey("UpdateByUserRole")]
        public T? UpdateByUserRoleID { get; set; }
        //public UserRole? UpdateByUserRole { get; set; }


        [Column(TypeName = "datetime2")]
        public DateTime DeleteDate { get; set; }
        [ForeignKey("DeleteByUser")]
        public T? DeleteByUserID { get; set; }
        //public User? DeleteByUser { get; set; }


        [DefaultValue(true)]
        public bool IsActive { get; set; }

        [Required]
        public virtual Guid RowGuid { get; set; }
    }
    public abstract class BaseAuditableEntity : BaseAuditableEntity<long>
    {

    }


}
