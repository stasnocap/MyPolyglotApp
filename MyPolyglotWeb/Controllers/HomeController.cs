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
        public IActionResult DoExercise(long lessonId)
        {
            if (lessonId < 1 || lessonId > 31)
            {
                return View(_homePresentation.GetExerciseVM(1));
            }

            var exerciseVM = _homePresentation.GetExerciseVM(lessonId);

            return View(exerciseVM);
        }

        [HttpPost]
        public IActionResult DoExercise(DoExerciseVM exerciseVM)
        {
            if (!ModelState.IsValid)
                {
                return View(exerciseVM);
            }

            if (!_homePresentation.CheckAnswer(exerciseVM.ExerciseId, exerciseVM.UserAnswer))
            {
                TempData["Feilure"] = "Please, try again!";
                return View(exerciseVM);
            }

            TempData["Success"] = "Splendid!";

            return RedirectToAction("DoExercise", new { lessonId = exerciseVM.LessonId });
        }

        [HttpGet]
        public IActionResult LessonInfo(long lessonId)
        {
            return View($"LessonInfo{lessonId}");
        }
    }
}
