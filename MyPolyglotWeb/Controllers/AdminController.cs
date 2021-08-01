using Microsoft.AspNetCore.Mvc;
using MyPolyglotCore;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Presentation;
using System.Linq;

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
        public IActionResult AddExercise(AddExerciseViewModel viewModel)
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
