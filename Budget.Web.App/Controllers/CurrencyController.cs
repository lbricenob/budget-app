using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Text.Json;
using Budget.Web.App.Entity;

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
            string json = System.IO.File.ReadAllText(@"Files/Currencies.json");

            List<Currency> ListofCurrency =JsonSerializer.Deserialize<List<Currency>>(json);
            return Ok(ListofCurrency);
            //return Content(json, "application/json");
        }
    }
}
