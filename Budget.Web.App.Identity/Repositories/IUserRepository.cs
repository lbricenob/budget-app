using Budget.Web.App.Identity.Models;

namespace Budget.Web.App.Identity.Repositories
{
  public interface IUserRepository
  {
    Task<User> CreateUser(User user);
  }
}
