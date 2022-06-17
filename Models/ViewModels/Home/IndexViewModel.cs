namespace Prototype.Models.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Room> Rooms { get; set;}
        public IEnumerable<Location> Locations { get; set; }
    }
}