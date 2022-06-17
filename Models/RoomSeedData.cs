using Microsoft.EntityFrameworkCore;

namespace Prototype.Models
{
  public static class RoomSeedData
  {
    public static void EnsurePopulated(IApplicationBuilder app)
    {
      MainDbContext context = app.ApplicationServices
        .CreateScope().ServiceProvider.GetRequiredService<MainDbContext>();

      if (context.Database.GetPendingMigrations().Any())
      {
        context.Database.Migrate();
      }

      if(!context.Rooms.Any())
      {
        context.Rooms.AddRange(
          new Room {
            Name = "Quarto 12",
            Description = "Bla bla bla e muito conforto.",
            Beds = 2,
            Adults = 2,
            Children = 2,
            Daily = 120,
            Localization = "Campos do Jordão"
          },
          new Room {
            Name = "Quarto 213",
            Description = "Bla ble ble ble bli bla e muito conforto.",
            Beds = 1,
            Adults = 2,
            Children = 0,
            Daily = 225,
            Localization = "Gramado"
          },
          new Room {
            Name = "Quarto 2413",
            Description = "Muito bom meu mano",
            Beds = 2,
            Adults = 2,
            Children = 1,
            Daily = 190,
            Localization = "São Paulo"
          },
          new Room {
            Name = "Quarto 14",
            Description = "Ba ble ble ble bli bla.",
            Beds = 2,
            Adults = 2,
            Children = 0,
            Daily = 200
          },
          new Room {
            Name = "Quarto 992",
            Description = "Anotehra dskoa .",
            Beds = 3,
            Adults = 2,
            Children = 3,
            Daily = 315,
            Localization = "Monte Verde"
          },
          new Room {
            Name = "Quarto 53",
            Beds = 1,
            Adults = 2,
            Children = 0,
            Daily = 70,
            Localization = "Fortaleza"
          },
          new Room {
            Name = "Quarto 71",
            Beds = 1,
            Adults = 2,
            Children = 0,
            Daily = 57,
            Localization = "Salvador"
          },
          new Room {
            Name = "Quarto 314",
            Beds = 2,
            Adults = 2,
            Children = 1,
            Daily = 120,
            Localization = "Salvador"
          }
        );

        context.SaveChanges();
      }
    }
  }
}