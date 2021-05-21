using Revachess.Storage;
using Revachess.Storage.Repositories;

namespace PizzaBox.Storage
{
  public class UnitOfWork
  {
    private readonly ChessContext _context;

    public GameRepository Games { get; set; }
    public UserRepository Users { get; set; }

    public UnitOfWork(ChessContext context)
    {
      _context = context;

      Games = new GameRepository(_context);
      Users = new UserRepository(_context);
    }

    public void Save()
    {
      _context.SaveChanges();
    }
  }
}