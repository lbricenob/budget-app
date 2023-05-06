using Budget.Web.App.Auth.AuthnHandlers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace Budget.Web.App.Auth.Startup
{
  public static class BudgetAuthStartup
  {
    public static void SetupBudgetAuthentication(this IServiceCollection services)
    {
      services.AddAuthentication("BudgetAuthScheme").AddScheme<AuthenticationSchemeOptions, BudgetAuthenticationHandler>(
        "BudgetAuthScheme",
        opts => { }
        );
    }
  }
}
