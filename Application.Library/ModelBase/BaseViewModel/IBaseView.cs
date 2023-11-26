namespace Application.Library.ModelBase.BaseViewModel
{
    public interface IBaseView
    {
    }
    public abstract class BaseView<T> : IBaseView
    {
        public BaseView() { }

        public T ID { get; set; }
        public Guid Guid { get; set; }
        public T CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public T UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
    }
    public abstract class BaseView : BaseView<long>
    {
    }
}
