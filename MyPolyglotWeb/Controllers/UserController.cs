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
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserVM registerUserVM)
        {
            if (!ModelState.IsValid)
            {
                return View(registerUserVM);
            }

            _userPresentation.Register(registerUserVM);

            await SignInAsync(registerUserVM.Email, registerUserVM.Password);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            CheckCredentials(loginVM);

            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }

            await SignInAsync(loginVM.Email, loginVM.Password);

            return RedirectToAction("Index", "Home");
        }

        private async Task SignInAsync(string email, string password)
        {
            var claimsPrincipal = _userPresentation.GetLoginClaims(email, password);
            await HttpContext.SignInAsync(claimsPrincipal);
        }

        private void CheckCredentials(LoginVM loginVM)
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

        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
