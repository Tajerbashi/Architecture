namespace Application.Library.ModelBase.BaseDTOModel
{
    //  This is a Api Method Result and each Repository Method Service must return ResultAction
    public class ResultAction<T> : HttpResponseMessage where T : ResultDTO<T>
    {
        public T Model { get; set; }
        public bool IsSucess { get; set; }
    }
}
