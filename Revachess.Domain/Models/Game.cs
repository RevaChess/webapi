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
    public bool Started = false;
    public bool Ended = false;

    public Game()
    {
      States = new List<GameState>();
    }

    public Game(string Player1Username, string Player2Username)
    {
      States = new List<GameState>();
      Player1 = new User();
      Player2 = new User();
      Player1.UserName = Player1Username;
      Player2.UserName = Player2Username;
    }

  }
}