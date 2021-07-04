using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyPolyglotCore;

namespace MyPolyglotWeb.Models.ViewModels
{
    public class AddViewModel
    {
        public string LessonId { get; set; }
        public string RusPhrase { get; set; }
        public string EngTranslation { get; set; }
    }
}