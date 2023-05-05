using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Budget.Web.App.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TestController : ControllerBase
  {
    [HttpGet]
    public IActionResult Test()
    {
      return Ok("Hola mundo!");
    }
  }
}
