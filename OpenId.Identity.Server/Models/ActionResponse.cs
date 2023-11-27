using Microsoft.AspNetCore.Mvc;

namespace OpenId.Identity.Server.Models
{
    public class ActionResponse<T> : ActionResult
    {
        public T Result { get; set; }

    }
}

