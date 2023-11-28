namespace Application.Library.ModelBase.BaseDTOModel
{
    //  This is a Model DTO Base Each DTO must Extend this class
    public abstract class BaseDTO<T>
    {
        public T ID { get; set; }
        public Guid Guid { get; set; }
        public T CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public T UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsDeleted { set; get; }
        public bool IsActive { set; get; }
    }
    public abstract class BaseDTO : BaseDTO<long>
    {


    }
}
