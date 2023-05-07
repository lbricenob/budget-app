using Budget.Web.App.Database.DataAccess;
using Budget.Web.App.Identity.Models;
using Budget.Web.App.Identity.Queries;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
      return _userDataAccess.Create(createCommand);
    }
  }
}
