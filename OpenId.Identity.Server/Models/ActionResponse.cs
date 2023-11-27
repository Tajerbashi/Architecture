using Microsoft.AspNetCore.Mvc;

namespace OpenId.Identity.Server.Models
{
    public class ActionResponse<T> : IActionResult
    {
        public T Result { get; set; }

        private readonly ResultStatus _result;

        public ActionResponse(ResultStatus result)
        {
            _result = result;
        }

        public ActionResponse()
        {
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            var objectResult = new ObjectResult(_result.Exception ?? _result.Data)
            {
                StatusCode = _result.Exception != null
                ? StatusCodes.Status500InternalServerError
                : StatusCodes.Status200OK
            };

            await objectResult.ExecuteResultAsync(context);
        }
    }
    public class ResultStatus
    {
        public Exception Exception { get; set; }
        public object Data { get; set; }
    }
}

