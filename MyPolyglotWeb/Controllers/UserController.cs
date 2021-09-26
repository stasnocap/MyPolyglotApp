using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Presentations;
using System.Threading.Tasks;

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
            if (!ModelState.IsValid)
            {
                return View(registerUserVM);
            }

            _userPresentation.Register(registerUserVM);

            TempData["SuccessfulRegistration"] = "Регистрация прошла успешно!";

            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(LoginVM loginVM)
        {
            SignIn(loginVM);

            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }

            var claimsPrincipal = _userPresentation.GetLoginClaims(loginVM);
            await HttpContext.SignInAsync(claimsPrincipal);

            return RedirectToAction("Index", "Home");
        }

        private void SignIn(LoginVM loginVM)
        {
            var user = _userPresentation.GetUser(loginVM.Email, loginVM.Password);

            if (user == null)
            {
                if (!_userPresentation.IsUserExist(loginVM.Email))
                {
                    ModelState.AddModelError(nameof(LoginVM.Email), "Пользователя с таким электронным адресом не зарегистрировано!");
                }

                ModelState.AddModelError(nameof(LoginVM.Password), "Неправильный пароль!");
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
