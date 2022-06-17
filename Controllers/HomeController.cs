using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Prototype.Models;
using Prototype.Models.ViewModels;

namespace Prototype.Controllers;

public class HomeController : Controller
{
  private IHotelRepository repository;

  public HomeController(IHotelRepository repo)
  {
    repository = repo;
  }

  public ViewResult Index()
  {
    return View(repository.Rooms);
  }

  //Não funcionando ainda
  public ViewResult RoomsMenu(string? destiny, int? adults, int? children)
  {
    return View(new IndexViewModel {
      Rooms = repository.Rooms
      .Where(r => r.Adults >= adults
        && (destiny == null || r.Localization.Contains(destiny))
        && r.Children >= children)
      .OrderBy(r => r.Adults)
    });
  }

  public IActionResult Booking(int? id)
  {
    if(id.HasValue)
      return View(repository.Rooms
        .Single(room => room.Id == id));
    
    return RedirectToAction("Index");
  }
}
