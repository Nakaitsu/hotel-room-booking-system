using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Prototype.Models;

namespace Prototype.Controllers;

public class HomeController : Controller
{
    public IActionResult Index(int? id)
    {
        return View(id);
    }
}
