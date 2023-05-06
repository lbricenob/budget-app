using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text.Encodings.Web;

namespace Budget.Web.App.Auth.AuthnHandlers
{
  public class BudgetAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
  {
    public BudgetAuthenticationHandler(
      IOptionsMonitor<AuthenticationSchemeOptions> options, 
      ILoggerFactory logger, 
      UrlEncoder encoder, 
      ISystemClock clock) : base(options, logger, encoder, clock)
    {
    }

    protected async override Task<AuthenticateResult> HandleAuthenticateAsync()
    {
      ClaimsIdentity identity = new ClaimsIdentity("Test");
      identity.AddClaim(new Claim(ClaimTypes.Name, "Humano"));
      ClaimsPrincipal principal = new ClaimsPrincipal(identity);
      AuthenticationTicket authenticationTicket = new AuthenticationTicket(principal, this.Scheme.Name);
      return AuthenticateResult.Success(authenticationTicket);
    }
  }
}
