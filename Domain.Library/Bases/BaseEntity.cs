using Domain.Library.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Library.Bases
{
    public abstract class BaseEntity : IEntity
    {
        [Key]
        public virtual long ID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        //[ForeignKey("CreateByUserRole")]
        public long CreatedByUserRoleID { get; set; }
        //public UserRole? CreateByUserRole { get; set; }



    }
}
