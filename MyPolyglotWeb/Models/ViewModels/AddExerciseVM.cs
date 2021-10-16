using MyPolyglotWeb.Constants;
using MyPolyglotWeb.Models.ViewModels.CustomAttributes;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyPolyglotWeb.Models.ViewModels
{
    public class AddExerciseVM
    {
        [Required(ErrorMessage = "Вы забыли указать урок!")]
        [Range(1, 31, ErrorMessage = CustomConst.UserTriesToBreakMe)]
        public virtual string LessonId { get; set; }

        [Required(ErrorMessage = "Вы забыли ввести русскую фразу!")]
        [DisplayName("На русском")]
        public string RusPhrase { get; set; }

        [Required(ErrorMessage = "Вы забыли ввести английскую фразу!")]
        [DisplayName("На английском")]
        public string EngPhrase { get; set; }

        [RecognizedWordsByUser(ErrorMessage = "Вы забыли указать тип слова!")]
        [DisplayName("Нераспознанные слова")]
        public List<UnrecognizedWordVM> UnrecognizedWords { get; set; }
    }
}