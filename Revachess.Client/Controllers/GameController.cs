using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storage;
using Revachess.Storage;

namespace Revachess.Client.Controllers
{
  [Route("[controller]")]
  [EnableCors("public")]
  public class GameController : ControllerBase
  {
    private readonly UnitOfWork _unitOfWork;
    public GameController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    [HttpGet]
    public IActionResult GetUsers()
    {
      var data = new DataViewModel();
      data.Load(_unitOfWork);

      return Ok(data.Users);
    }
  }
}