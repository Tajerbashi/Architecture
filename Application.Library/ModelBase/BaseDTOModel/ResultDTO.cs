namespace Application.Library.ModelBase.BaseDTOModel
{
    //  This is a Service Method Result and each Service Method Service must return ResultDTO 
    //  This is used in Infrastructure Methods
    public class ResultDTO<T>
    {
        public T Result { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}
