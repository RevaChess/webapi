using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Revachess.Domain.Models;

namespace Revachess.Storage.Repositories
{
  public class GameRepository
  {
    private readonly ChessContext _context;
    public GameRepository(ChessContext context)
    {
      _context = context;
    }
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Game entry)
    {
      _context.Games.Add(entry);
      return true;
    }

    public IEnumerable<Game> Select(Func<Game, bool> filter)
    {
      return _context.Games
      .Include(a => a.Id)
      .Include(a => a.Name)
      .Include(a => a.Player1).ThenInclude(a => a.UserName)
      .Include(a => a.Player2).ThenInclude(a => a.UserName)
      .Include(a => a.Winner).ThenInclude(a => a.UserName)
      .Where(filter);
    }
    public void Update(Game entry)
    {
      _context.Games.Update(entry);
    }
  }
}