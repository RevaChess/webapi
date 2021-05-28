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
  public class PlayController : ControllerBase
  {
    private readonly UnitOfWork _unitOfWork;
    public PlayController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    [HttpGet]
    [HttpPost]
    public IActionResult AddUser([FromBody] User user)
    {
      
      _unitOfWork.Users.Insert(user);
      _unitOfWork.Save();

      return Ok("User added");
    }
  }
}