using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace UStorage.Web.Controllers.V1
{
    [ApiVersion("1.0")]
    public class AliveController : ApiBaseController
    {
        [HttpGet("")]
        [HttpGet("now")]
        [AllowAnonymous]
        public IActionResult GetAlive()
        {
            return Ok(new { Time = DateTime.Now.ToString("HH:mm:ss:ffff, dd.MM.yyyy") });
        }
    }
}