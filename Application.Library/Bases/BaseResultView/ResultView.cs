namespace Application.Library.Bases
{
    public class ResultView<T>
    {
        public List<string> Message { get; set; }
        public bool IsSuccess { get; set; }
        public T Data { get; set; }
    }
    public class ResultView
    {
        public List<string> Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}
