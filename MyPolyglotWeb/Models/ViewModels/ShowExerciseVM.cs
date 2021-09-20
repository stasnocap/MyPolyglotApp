using MyPolyglotWeb.Constants;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyPolyglotWeb.Models.ViewModels
{
    public class ShowExerciseVM
    {
        [Required(ErrorMessage = CustomConst.UserTriesToBreakMe)]
        [Range(1, long.MaxValue, ErrorMessage = CustomConst.UserTriesToBreakMe)]
        public virtual long LessonId { get; set; }

        [Required(ErrorMessage = CustomConst.UserTriesToBreakMe)]
        [Range(1, long.MaxValue, ErrorMessage = CustomConst.UserTriesToBreakMe)]
        public long ExerciseId { get; set; }

        [Required(ErrorMessage = CustomConst.UserTriesToBreakMe)]
        public string RusPhrase { get; set; }

        [Required(ErrorMessage = CustomConst.UserTriesToBreakMe)]
        public virtual List<OptionGroup> OptionGroups { get; set; }

        [Required(ErrorMessage = CustomConst.UserTriesToBreakMe)]
        public string UserAnswer { get; set; }
    }
}
