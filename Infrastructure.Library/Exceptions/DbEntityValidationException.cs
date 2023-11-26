namespace Infrastructure.Library.Exceptions
{
    public abstract class DbEntityValidationException : Exception
    {
        public List<ErrorReult> EntityValidationErrors { get; set; }
    }
    public abstract class ErrorReult
    {
        public List<ErrorModel> ValidationErrors { get; set; }
    }
    public abstract class ErrorModel
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
    }
}
