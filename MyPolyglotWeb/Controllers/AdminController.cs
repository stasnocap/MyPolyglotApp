using Microsoft.AspNetCore.Mvc;
using MyPolyglotCore;
using MyPolyglotWeb.Models.ViewModels;
using System.Linq;

namespace MyPolyglotWeb.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddViewModel viewModel)
        {
            return View(viewModel);
        }

        public IActionResult Recognize(string engPhrase)
        {
            var recognizer = new Recognizer(engPhrase, new Vocabulary());

            recognizer.TryToRecognize();

            var unrecognizedWords = recognizer.UnrecognizedWords
                .Select(x => new UnrecognizedWord() { Text = x.Text });

            return Json(unrecognizedWords);
        }
    }
}
