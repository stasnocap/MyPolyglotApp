using Microsoft.AspNetCore.Mvc;
using MyPolyglotWeb.Models.ViewModels;
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
        public IActionResult Lesson(ExerciseVM exerciseVM)
        {
            if (_homePresentation.CheckAnswer(exerciseVM.ExerciseId, exerciseVM.UserAnswer))
            {
                TempData["Success"] = "Splendid!";
                return RedirectToAction("Lesson", new { id = exerciseVM.LessonId});
            }

            return View(exerciseVM);
        }
    }
}
