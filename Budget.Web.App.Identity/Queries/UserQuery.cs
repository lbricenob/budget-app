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
      return "INSERT INTO Users VALUES ('608604ea-011b-4630-8669-f3853f3df38c', '2023-05-05', '2023-05-05', 'lbriceno', 'lbriceno');" +
        "SELECT * FROM Users WHERE id = '608604ea-011b-4630-8669-f3853f3df38c'";
    }
  }
}
