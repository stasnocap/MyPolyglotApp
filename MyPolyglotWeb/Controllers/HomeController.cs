using Microsoft.AspNetCore.Mvc;
using MyPolyglotWeb.Presentation;

namespace MyPolyglotWeb.Controllers
{
    public class HomeController : Controller
    {
        private HomePresentation _homePresentation;

        public HomeController(HomePresentation homePresentation)
        {
            _homePresentation = homePresentation;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Lesson(long id)
        {
            var viewModel = _homePresentation.GetExerciseVM(id);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Lesson()
        {
            return View();
        }


    }
}
