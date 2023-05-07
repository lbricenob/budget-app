using Budget.Web.App.Database.DataAccess;
using Budget.Web.App.Identity.Models;
using Budget.Web.App.Identity.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Budget.Web.App.Identity.Extensions
{
  public static class IdentityStartup
  {
    public static void SetupIdentityStartup(this IServiceCollection services, IConfiguration configuration)
    {
      services.AddSingleton<IDataAccess<User>>(da => new DataAccess<User>(configuration.GetConnectionString("UserDatabase")));
      services.AddScoped<IUserRepository, UserRepository>();
    }
  }
}
