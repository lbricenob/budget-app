using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.Web.App.Identity.Queries
{
  public static class UserQuery
  {
    public static string Create()
    {
      return "INSERT INTO Users VALUES (@id, '2023-05-05', '2023-05-05', @email, @password);" +
        "SELECT * FROM Users WHERE id = @id";
    }
  }
}
