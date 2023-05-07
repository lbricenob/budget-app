using Microsoft.Data.SqlClient;

namespace Budget.Web.App.Database.DataAccess;
public class DataAccess : IDataAccess
{
  string _connectionString;
  public DataAccess(string connectionString)
  {
    _connectionString = connectionString;
  }

  public T Create<T>(SqlCommand command)
  {
    throw new NotImplementedException();
  }

  public T Get<T>(SqlCommand command)
  {
    throw new NotImplementedException();
  }

  public List<T> GetAll<T>(SqlCommand command)
  {
    throw new NotImplementedException();
  }

  public T Update<T>(SqlCommand command)
  {
    throw new NotImplementedException();
  }
}
