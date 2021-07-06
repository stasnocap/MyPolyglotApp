using Microsoft.AspNetCore.Mvc;
using MyPolyglotCore;
using MyPolyglotWeb.Models.ViewModels;

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
            var recognizer = new Recognizer();
            var words = recognizer.Split(viewModel.EngPhrase);

            return View();
        }
    }
}
