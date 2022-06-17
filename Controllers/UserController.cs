using Microsoft.AspNetCore.Mvc;
using Prototype.Models;

namespace Prototype.Controllers
{
    public class UserController : Controller
    {
        public IActionResult SignIn()
        {
          return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
          return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpViewModel userForm)
        {
          if(ModelState.IsValid) 
          { 
            User newUser = new User {
              Username = userForm.Username,
              Email = userForm.Email,
              Password = userForm.Password
            };

            if(UserRepository.IsValid(newUser)) 
            {
              UserRepository.Create(newUser);

              TempData["LoggedUser"] = newUser.Username;
              return RedirectToAction("Index", "Home");
            }
            else 
            {
              return View();
            }
          }
          else
          {
            return View();
          }
        }

        public IActionResult Profile()
        {
          return View();
        }
    }
}