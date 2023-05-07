using Budget.Web.App.Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.Web.App.Identity.Repositories
{
  public class UserRepository : IUserRepository
  {
    public Task<User> CreateUser(User user)
    {
      throw new NotImplementedException();
    }
  }
}
