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
  public class AddGameController : ControllerBase
  {
    private readonly UnitOfWork _unitOfWork;
    public AddGameController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    [HttpGet]
    [HttpPost]
    public IActionResult AddGame([FromBody] Game Game)
    {

      _unitOfWork.Games.Insert(Game);
      _unitOfWork.Save();

      return Ok("game added");
    }
  }
}