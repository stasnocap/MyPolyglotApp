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
        public IActionResult AddExercise(AddExerciseVM viewModel)
        {
            _adminPresentation.AddExercise(viewModel);
            return View(viewModel);
        }

        public IActionResult Recognize(string engPhrase)
        {
            var unrecognizedWords = _adminPresentation.GetUnrecognizedWords(engPhrase);
            return Json(unrecognizedWords);
        }
    }
}
