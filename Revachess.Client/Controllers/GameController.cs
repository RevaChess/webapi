using Microsoft.AspNetCore.Mvc;

namespace Revachess.Client.Controllers
{
  [Route("[controller]")]
  public class GameController : ControllerBase
  {
    [HttpGet]
    public IActionResult Get()
    {
      return Ok("Game data");
    }
  }
}