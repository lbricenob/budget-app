using Budget.Web.App.Database.DataModels;
using Microsoft.Data.SqlClient;

namespace Budget.Web.App.Database.DataAccess;
public interface IDataAccess<T> where T : DataEntity
{
  T Create(SqlCommand command);
  T Get(SqlCommand command);
  List<T> GetAll(SqlCommand command);
  T Update(SqlCommand command);
  T ConvertReader(SqlDataReader reader);
}
