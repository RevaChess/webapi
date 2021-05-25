using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storage;
using Revachess.Domain.Models;
using Revachess.Storage;

namespace Revachess.Client.Controllers
{
  [Route("[controller]")]
  [EnableCors("public")]
  public class RegisterController : ControllerBase
  {
    private readonly UnitOfWork _unitOfWork;
    public RegisterController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    [HttpPost]
    public IActionResult Post(User givenUser)
    {
      var data = new DataViewModel();
      data.Load(_unitOfWork);

      foreach (var storedUser in data.Users)
      {
        if (storedUser.UserName == givenUser.UserName)
        {
          return NotFound("User Exists");
        }
      }
      _unitOfWork.Users.Insert(givenUser);
      _unitOfWork.Save();
      data.Load(_unitOfWork);
      foreach (var storedUser in data.Users)
      {
        if (storedUser.UserName == givenUser.UserName)
        {
          if (storedUser.Password == givenUser.Password)
          {
            return Ok(storedUser);
          }
          return NotFound("Wrong password");
        }
      }
      return NotFound("User Doesn't Exist");
    }
  }
}