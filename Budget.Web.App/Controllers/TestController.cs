using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Budget.Web.App.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  [Authorize(AuthenticationSchemes = "BudgetAuthScheme")]
  public class TestController : ControllerBase
  {
    [HttpGet]
    public IActionResult Test()
    { 
      return Ok($"Hola {HttpContext.User.Identity.Name}!");
    }
  }
}
