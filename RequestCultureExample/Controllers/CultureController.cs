namespace RequestCultureExample.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class CultureController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var date = DateTime.Now.ToString();
            return Ok(date);
        }
    }
}
