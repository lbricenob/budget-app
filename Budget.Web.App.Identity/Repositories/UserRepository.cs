using Budget.Web.App.Database.DataAccess;
using Budget.Web.App.Identity.Models;
using Budget.Web.App.Identity.Queries;
using Microsoft.Data.SqlClient;

namespace Budget.Web.App.Identity.Repositories
{
  public class UserRepository : IUserRepository
  {
    private readonly IDataAccess<User> _userDataAccess;
    public UserRepository(IDataAccess<User> userDataAccess)
    {
      _userDataAccess = userDataAccess;
    }
    public async Task<User> CreateUser(User user)
    {
      SqlCommand createCommand = new SqlCommand(UserQuery.Create());
      createCommand.Parameters.AddWithValue("id", Guid.NewGuid());
      createCommand.Parameters.AddWithValue("email", user.Email);
      createCommand.Parameters.AddWithValue("password", user.Password);
      return await _userDataAccess.Create(createCommand);
    }
  }
}
