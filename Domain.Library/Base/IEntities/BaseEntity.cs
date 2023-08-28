namespace Domain.Library.Base
{
    public abstract class BaseEntity<T> : IEntity
    {
        public Guid Guid { get; set; }
        public T ID { get; set; }
    }
    public abstract class BaseEntity : BaseEntity<long>
    {
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;

        public long CreateByUserRoleID { get; set; }
        public long DeleteByUserRoleID { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime DeleteDate { get; set; } = DateTime.Now;
    }
}
