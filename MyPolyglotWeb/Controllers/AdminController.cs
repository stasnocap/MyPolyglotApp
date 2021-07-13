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
            var recognizer = new Recognizer(viewModel.EngPhrase, new Vocabulary());

            recognizer.TryToRecognize();

            viewModel.UnrecognizedWords = recognizer.UnrecognizedWords
                .Select(x => new UnrecognizedWord() { Text = x.Text })
                .ToList();

            return View(viewModel);
        }
    }
}
