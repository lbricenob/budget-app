using Budget.Web.App.Database.DataModels;

namespace Budget.Web.App.Identity.Models
{
  public class User : DataEntity
  {
    public string Email { get; set; }
    public string Password { get; set; }
  }
}
