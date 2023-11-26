namespace Application.Library.ModelBase.BaseViewModel
{
    public interface IBaseListView
    {
    }
    public class BaseListView : IBaseView, IBaseListView
    {
        public BaseListView() { }
        public required int Count { get; set; }
    }
}
