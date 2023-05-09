using Budget.Web.App.Database.DataModels;
using Microsoft.Data.SqlClient;

namespace Budget.Web.App.Database.DataAccess;
public interface IDataAccess<T> where T : DataEntity
{
  Task<T> Create(SqlCommand command);
  Task<T> Get(SqlCommand command);
  Task<List<T>> GetAll(SqlCommand command);
  Task<T> Update(SqlCommand command);
  T ConvertReader(SqlDataReader reader);
}
