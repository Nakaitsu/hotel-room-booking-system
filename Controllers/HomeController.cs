using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Prototype.Models;

namespace Prototype.Controllers;

public class HomeController : Controller
{
  public IActionResult Index()
  {
    return View(Room.GetRooms());
  }

  public IActionResult Reserva(int? id)
  {
    if (id.HasValue)
      return View(id);
    else
      return RedirectToAction("Index");
  }
}
