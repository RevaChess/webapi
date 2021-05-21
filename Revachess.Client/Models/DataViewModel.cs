using System.Collections.Generic;
using System.Linq;
using PizzaBox.Storage;
using Revachess.Domain.Models;

namespace PizzaBox.Client.Models
{
  public class DataViewModel
  {
    public List<Game> Games { get; set; }
    public List<User> Users { get; set; }

    public void Load(UnitOfWork unitOfWork)
    {
      Games = unitOfWork.Games.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
      Users = unitOfWork.Users.Select(s => !string.IsNullOrWhiteSpace(s.UserName)).ToList();
    }

  }
}