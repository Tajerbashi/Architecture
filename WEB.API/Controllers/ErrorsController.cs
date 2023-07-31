using Microsoft.AspNetCore.Mvc;
using WEB.API.Models;

namespace WEB.API.Controllers
{
    public class ErrorsController : Controller
    {
        [Route("errors/{statusCode}")]
        public IActionResult CustomError(int statusCode)
        {
            if (HttpContext.Request.Headers["Content-Type"] == "application/json")
            {

                var cuserr = new CustomError() { ErrorMessage = "err", StatusCode = statusCode };
                return new JsonResult(cuserr);
            }
            else
            {
                if (statusCode == 404)
                {
                    return View("~/Views/Errors/404.cshtml");
                }
                return View("~/Views/Errors/500.cshtml");
            }

        }
    }
}
