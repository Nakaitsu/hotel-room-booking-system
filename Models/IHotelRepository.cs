namespace Prototype.Models
{
    public interface IHotelRepository
    {
         IQueryable<Room> Rooms { get; }
    }
}