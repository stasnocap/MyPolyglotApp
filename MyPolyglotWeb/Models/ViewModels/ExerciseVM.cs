using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyPolyglotWeb.Models.ViewModels
{
    public class ExerciseVM
    {
        [Required(ErrorMessage ="Зачем ты пытаешься сломать меня?")]
        public virtual long LessonId { get; set; }

        [Required(ErrorMessage ="Зачем ты пытаешься сломать меня?")]
        public long ExerciseId { get; set; }

        [Required(ErrorMessage ="Зачем ты пытаешься сломать меня?")]
        public string RusPhrase { get; set; }

        [Required(ErrorMessage ="Зачем ты пытаешься сломать меня?")]
        public virtual List<OptionGroup> OptionGroups { get; set; }

        [Required(ErrorMessage ="Зачем ты пытаешься сломать меня?")]
        public string UserAnswer { get; set; }
    }
}
