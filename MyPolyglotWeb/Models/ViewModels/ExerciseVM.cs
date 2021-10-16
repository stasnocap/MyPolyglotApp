using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyPolyglotWeb.Models.ViewModels
{
    public class ExerciseVM
    {
        [Required]
        [Range(1, long.MaxValue)]
        public long LessonId { get; set; }

        [Required]
        [Range(1, long.MaxValue)]
        public long ExerciseId { get; set; }

        [Required]
        public string RusPhrase { get; set; }

        [Required]
        public string EngPhrase { get; set; }

        public List<UnrecognizedWordVM> UnrecognizedWords { get; set; }
    }
}
