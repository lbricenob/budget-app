using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Budget.Web.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "BudgetAuthScheme")]
    public class CurrencyController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCurrency()
        {
            var json = System.IO.File.ReadAllText(@"Files/Currencies.json");
            return Content(json, "application/json");
        }
    }
}
