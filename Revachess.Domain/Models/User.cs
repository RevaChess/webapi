using Revachess.Domain.Abstracts;

namespace Revachess.Domain.Models
{
  public class User : Entity
  {
    public string UserName { get; set; }
    public string Password { get; set; }
  }
}