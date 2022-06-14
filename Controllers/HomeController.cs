using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class HomeController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}