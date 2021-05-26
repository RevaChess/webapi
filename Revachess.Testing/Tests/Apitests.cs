using Revachess.Domain.Models;
using Xunit;

namespace Revachess.Testing.Tests
{
  public class Apitests
  {
    [Fact]
    public void Test_UserNameNotNull()
    {
      var u = new User();
      u.UserName = "jo";

      Assert.NotNull(u.UserName);
    }

    [Fact]
    public void Test_Correct_Username()
    {
      var u = new User();
      u.UserName = "jo";

      Assert.Equal(u.UserName, "jo");
    }

    [Fact]
    public void Test_GameName()
    {
      var g = new Game();
      g.Name = "jo";

      Assert.Equal(g.Name, "jo");
    }
  }
}