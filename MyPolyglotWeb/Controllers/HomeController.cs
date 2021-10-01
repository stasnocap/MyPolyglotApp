using Microsoft.AspNetCore.Mvc;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Presentations;

namespace MyPolyglotWeb.Controllers
{
    public class HomeController : Controller
    {
        private HomePresentation _homePresentation;

        public HomeController(HomePresentation homePresentation)
        {
            _homePresentation = homePresentation;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DoExercise(long lessonId)
        {
            if (lessonId < 1 || lessonId > 31)
            {
                return View(_homePresentation.GetDoExerciseVM(1));
            }

            var exerciseVM = _homePresentation.GetDoExerciseVM(lessonId);

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

                if (User.Identity.IsAuthenticated)
                {
                    _homePresentation.MinusPoint(exerciseVM.LessonId);
                }

                return View(exerciseVM);
            }

            TempData["Success"] = "Splendid!";
            if (User.Identity.IsAuthenticated)
            {
                _homePresentation.PlusPoint(exerciseVM.LessonId);
            }

            return RedirectToAction("DoExercise", new { lessonId = exerciseVM.LessonId });
        }

        [HttpGet]
        public IActionResult LessonInfo(long lessonId)
        {
            return View($"LessonInfo{lessonId}");
        }
    }
}
