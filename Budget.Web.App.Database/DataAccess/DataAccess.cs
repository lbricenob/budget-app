using Budget.Web.App.Database.DataModels;
using Microsoft.Data.SqlClient;

namespace Budget.Web.App.Database.DataAccess;
public class DataAccess<T> : IDataAccess<T> where T : DataEntity, new()
{
  string _connectionString;
  public DataAccess(string connectionString)
  {
    _connectionString = connectionString;
  }

  public T Create(SqlCommand command)
  {
    using (SqlConnection connection = new SqlConnection(_connectionString))
    {
      try
      {
        connection.Open();
        command.Connection = connection;
        using (SqlDataReader reader = command.ExecuteReader())
        {
          while (reader.Read())
          {
            return ConvertReader(reader);
          }
          return default(T);
        }
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
    }
  }

  public T Get(SqlCommand command)
  {
    throw new NotImplementedException();
  }

  public List<T> GetAll(SqlCommand command)
  {
    throw new NotImplementedException();
  }

  public T Update(SqlCommand command)
  {
    throw new NotImplementedException();
  }

  public T ConvertReader(SqlDataReader reader) 
  {
    T t = new T();
    t.Id = Guid.Parse(reader["Id"].ToString());
    t.Created = DateTime.Parse(reader["CreatedAt"].ToString());
    t.Updated = DateTime.Parse(reader["UpdatedAt"].ToString());
    t.CreatedBy = reader["CreatedBy"].ToString();
    t.UpdatedBy = reader["UpdatedBy"].ToString();
    return t;
  }
}
