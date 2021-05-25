using System;
using System.Collections.Generic;
using Revachess.Domain.Abstracts;

namespace Revachess.Domain.Models
{
  public class GameState : Entity
  {
    public string State { get; set; }
  }
}