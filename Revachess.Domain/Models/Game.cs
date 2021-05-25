using System;
using System.Collections.Generic;
using Revachess.Domain.Abstracts;

namespace Revachess.Domain.Models
{
  public class Game : Entity
  {
    public string Name { get; set; }
    public User Player1 { get; set; }
    public User Player2 { get; set; }
    public User Winner { get; set; }
    public List<GameState> States { get; set; }

  }
}