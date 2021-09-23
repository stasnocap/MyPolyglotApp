using Microsoft.AspNetCore.Mvc;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Presentation;

namespace MyPolyglotWeb.Controllers
{
    public class AdminController : Controller
    {
        public AdminPresentation _adminPresentation;

        public AdminController(AdminPresentation adminPresentation)
        {
            _adminPresentation = adminPresentation;
        }

        [HttpGet]
        public IActionResult AddExercise()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddExercise(AddExerciseVM addExerciseVM)
        {
            if (!ModelState.IsValid)
            {
                return View(addExerciseVM);
            }
            _adminPresentation.AddExercise(addExerciseVM);
            return View(addExerciseVM);
        }

        public IActionResult Recognize(string engPhrase)
        {
            if (string.IsNullOrEmpty(engPhrase))
            {
                return null;
            }

            var unrecognizedWords = _adminPresentation.GetUnrecognizedWords(engPhrase);
            return Json(unrecognizedWords);
        }

        [HttpGet]
        public IActionResult AllExercises()
        {
            var allExerciseVM = _adminPresentation.GetAllExercisesVM();
            return View(allExerciseVM);
        }

        public IActionResult DeleteExercise(long exerciseId)
        {
            _adminPresentation.DeleteExercise(exerciseId);
            return RedirectToAction("AllExercises");
        }
    }
}
