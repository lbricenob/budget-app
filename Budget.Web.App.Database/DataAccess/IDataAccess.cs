using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.Web.App.Database.DataAccess
{
  public interface IDataAccess
  {
    T Create<T>(SqlCommand command);
    T Get<T>(SqlCommand command);
    List<T> GetAll<T>(SqlCommand command);
    T Update<T>(SqlCommand command);
  }
}
