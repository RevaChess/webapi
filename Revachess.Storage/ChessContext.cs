using System.Linq;
using Microsoft.EntityFrameworkCore;
using Revachess.Domain.Models;

namespace Revachess.Storage
{
  public class ChessContext : DbContext
  {
    public DbSet<Game> Games { get; set; }
    public DbSet<User> Users { get; set; }

    public ChessContext(DbContextOptions options) : base(options) { }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="builder"></param>
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Game>().HasKey(e => e.Id);
      builder.Entity<User>().HasKey(e => e.Id);

      OnModelSeeding(builder);
    }

    private static void OnModelSeeding(ModelBuilder builder)
    {
      builder.Entity<User>().HasData(new User[]
      {
        new User() {Id =1, UserName = "Fed"},
        new User() {Id =2, UserName = "fred"}
      });

      builder.Entity<Game>().HasData(new Game[]
      {
        new Game() {Id =1, Name = "FedvsFred"},
        new Game() {Id =2, Name = "fredvsFriday"},
        new Game() {Id =3, Name = "SUNDAYvsSUNDAY"},
      });

    }
  }
}