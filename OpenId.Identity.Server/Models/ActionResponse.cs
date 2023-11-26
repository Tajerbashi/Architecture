using Microsoft.AspNetCore.Mvc;

namespace OpenId.Identity.Server.Models
{
    public class ActionResponse<T> : IActionResult
    {
        public Task ExecuteResultAsync(ActionContext context)
        {
            throw new NotImplementedException();
        }
        public T Result { get; set; }
    }
}
