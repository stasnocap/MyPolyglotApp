using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Presentations;

namespace MyPolyglotWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly HomePresentation _homePresentation;
        private readonly ICompositeViewEngine _compositeViewEngine;

        public HomeController(HomePresentation homePresentation, ICompositeViewEngine compositeViewEngine)
        {
            _homePresentation = homePresentation;
            _compositeViewEngine = compositeViewEngine;
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

            var doExerciseVM = _homePresentation.GetDoExerciseVM(lessonId);

            if (doExerciseVM == null)
            {
                return View($"/Views/Home/NoExercises.cshtml");
            }

            return View(doExerciseVM);
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
            var viewPath = $"/Views/Home/LessonInfos/LessonInfo{lessonId}.cshtml";

            if (!_compositeViewEngine.GetView("", viewPath, false).Success)
            {
                return View("/Views/Home/NoLessonInfo.cshtml");
            }

            return View(viewPath);
        }
    }
}
