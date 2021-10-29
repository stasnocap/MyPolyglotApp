using Microsoft.AspNetCore.Mvc;
using MyPolyglotWeb.Controllers.CustomAttributes;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Presentations;

namespace MyPolyglotWeb.Controllers
{
    [IsAdmin]
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
        public IActionResult AllExercises(int page = 0, int pageSize = 10,
            SortColumn sortColumn = SortColumn.LessonId, SortDirection sortDirection = SortDirection.ASC)
        {
            var allExerciseVM = _adminPresentation.GetAllExercisesVM(page, pageSize, sortColumn, sortDirection);
            return View(allExerciseVM);
        }

        [HttpPost]
        public IActionResult AllExercises(AllExercisesVM allExercisesVM)
        {
            _adminPresentation.UpdateExercises(allExercisesVM);
            return View(allExercisesVM);
        }

        [HttpPost]
        public IActionResult DeleteExercise(long exerciseId, int page, int pageSize,
            SortColumn sortColumn, SortDirection sortDirection)
        {
            _adminPresentation.DeleteExercise(exerciseId);
            return RedirectToAction("AllExercises", new { page = page, pageSize = pageSize, 
                sortColumn = sortColumn, sortDirection = sortDirection });
        }
    }
}
