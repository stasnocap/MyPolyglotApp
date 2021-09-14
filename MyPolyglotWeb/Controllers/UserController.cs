using Microsoft.AspNetCore.Mvc;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Presentation;

namespace MyPolyglotWeb.Controllers
{
    public class UserController : Controller
    {
        private UserPresentation _userPresentation;

        public UserController(UserPresentation userPresentation)
        {
            _userPresentation = userPresentation;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterUserVM registerUserVM)
        {
            if(!ModelState.IsValid)
            {
                return View(registerUserVM);
            }

            _userPresentation.Register(registerUserVM);

            TempData["SuccessfulRegistration"] = "Регистрация прошла успешно!";

            return View();
        }
    }
}
