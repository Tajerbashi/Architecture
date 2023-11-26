using Application.Library.ModelBase.BaseDTOModel;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.EndPoint.Models
{
    public class ResponseModel<T> : IActionResult
    {
        public Task ExecuteResultAsync(ActionContext context)
        {
            return Task.CompletedTask;
        }
        public T Model { get; set; }
    }
}
