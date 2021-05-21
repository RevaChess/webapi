using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Revachess.Client.Controllers
{
  [Route("[controller]")]
  public class GameController : ControllerBase
  {
    [HttpGet]
    public IActionResult Get()
    {
      var games = new List<string> { "Game1", "Game2" };
      return Ok(games);
    }
  }
}