using System.Linq;

namespace Prototype.Models
{
  public static class UserRepository
  {
    private static List<User> users = new List<User>();
    public static IQueryable<User> Users => users.AsQueryable<User>();
    public static bool IsValid(User user)
    {
      return !users.Exists(u => u.Email == user.Email 
        || u.Username == user.Username);
    }

    public static void Create(User newUser)
    {
      users.Add(new User() {
        Id = users.Count + 1,
        Username = newUser.Username,
        Email = newUser.Email,
        Password = newUser.Password
      });
    }
  }
}