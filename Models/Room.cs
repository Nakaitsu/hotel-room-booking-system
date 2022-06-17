using System.ComponentModel.DataAnnotations.Schema;

namespace Prototype.Models
{
  public class Room
  {
    [Column("id")]
    public int Id { get; set; }

    [Column(name: "name", 
      TypeName = "nvarchar(50)"
    )]
    public string Name { get; set; }

    [Column(name: "description",
      TypeName = "nvarchar(1000)"  
    )]
    public string? Description { get; set; }

    [Column("beds_cap")]
    public int Beds { get; set; }

    [Column("adults_cap")]
    public int Adults { get; set; }

    [Column("children_cap")]
    public int Children { get; set; }

    [Column(TypeName = "decimal(8,2)")]
    public decimal? Daily { get; set; }

    public int? SquareFeet { get; set; }

    public string? Localization { get; set; }

    [NotMapped]
    public string? Images { get; set; }

    public float? Rate { get; set; }

  }
}