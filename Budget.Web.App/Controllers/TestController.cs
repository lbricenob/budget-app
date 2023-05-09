using Budget.Web.App.Identity.Repositories;
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
    private readonly IUserRepository _userRepository;
    public TestController(IUserRepository userRepository)
    {
      _userRepository = userRepository;
    }

    [HttpGet]
    public IActionResult Test()
    { 
      return Ok($"Hola {HttpContext.User.Identity.Name}!");
    }

    [HttpGet("createUser")]
    public IActionResult TestCreateUser(string email, string password)
    {
      return Ok(_userRepository.CreateUser(new Identity.Models.User()));
    }
  }
}
