using Application.Library.ModelBase.BaseDTOModel;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.EndPoint.Models
{
    public class ResponseModel<T> : ActionResult
    {
        public T Model { get; set; }
    }
}
