using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PolyglotWeb.Models.ViewModels;
using PolyglotWeb.Presentation;

namespace PolyglotWeb.Controllers
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

        public IActionResult Lesson(long id)
        {
            var viewModel = _homePresentation.GetLessonViewModel(id);
            return View(viewModel);
        }
    }
}
