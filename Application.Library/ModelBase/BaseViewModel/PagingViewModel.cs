namespace Application.Library.ModelBase.BaseViewModel
{
    public class PagingViewModel<T> : IBaseView where T : BaseListView
    {
        public PagingViewModel() { }
        public int Page { get; set; }
        public int Take { get; set; }
        public int Skip { get; set; }
        public T Data { get; set; }

    }
}
