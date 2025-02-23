using System;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet("[action]/{id?}")]
        public ActionResult<String> Index([FromRoute] String id = "World")
        {
            return $"Hello, {id}!";
        }
    }
}
