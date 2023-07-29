namespace Application.Library.Bases
{
    public class RequestDTO<T> : BaseDTO where T : class
    {
        public bool Success { get; set; }
        public List<string> Messages { get; set; }
        public T Data { get; set; }
    }
    public class RequestDTO : BaseDTO
    {
        public long ID { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
