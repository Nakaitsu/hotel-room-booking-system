using System.Linq;

namespace Prototype.Models
{
  public class EFHotelRepository : IHotelRepository
  {
    private MainDbContext context;

    public EFHotelRepository(MainDbContext ctx)
    {
      context = ctx;
    }

    public IQueryable<Room> Rooms => context.Rooms;
  }
}