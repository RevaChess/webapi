using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Revachess.Domain.Models;

namespace Revachess.Storage.Repositories
{
  public class UserRepository
  {
    private readonly ChessContext _context;
    public UserRepository(ChessContext context)
    {
      _context = context;
    }
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(User entry)
    {
      _context.Users.Add(entry);
      return true;
    }

    public IEnumerable<User> Select(Func<User, bool> filter)
    {
      return _context.Users
      .Include(a => a.Id)
      .Include(a => a.UserName)
      .Include(a => a.Password)
      .Where(filter);
    }
    public void Update(User entry)
    {
      _context.Users.Update(entry);
    }
  }
}