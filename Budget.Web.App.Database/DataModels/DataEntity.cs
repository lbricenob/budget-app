using Microsoft.Data.SqlClient;

namespace Budget.Web.App.Database.DataModels
{
  public class DataEntity
  {
    public Guid Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
    public string CreatedBy { get; set; }
    public string UpdatedBy { get; set; }
  }
}
