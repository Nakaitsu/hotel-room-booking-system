using System.ComponentModel.DataAnnotations.Schema;

namespace Prototype.Models
{
  public class Room
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public int Beds { get; set; }
    public int Adults { get; set; }
    public int Children { get; set; }
    [Column(TypeName = "decimal(8,2)")]
    public decimal Daily { get; set; }
    public int SquareFeet { get; set; }
    public string Localization { get; set; }
    public string[] Images { get; set; } // mudar

    private float Rate { get; set; }

    public static IEnumerable<Room> GetRooms()
    {
      return (new Room[] {
            new Room{
              Id = 3389,
              Name = "Quarto 1",
              Beds = 2,
              Adults = 2,
              Children = 2,
              SquareFeet = 32,
              Daily = 1231
            },
            new Room{
              Id = 1239,
              Name = "Quarto 2",
              Beds = 1,
              Adults = 2,
              Children = 0,
              SquareFeet = 28,
              Daily = 720
            },
            new Room{
              Id = 4314,
              Name = "Quarto 3",
              Beds = 2,
              Adults = 2,
              Children = 1,
              SquareFeet = 32,
              Daily = 430,
              Description = "Bla bla bla"
            }
          });
    }
  }
}