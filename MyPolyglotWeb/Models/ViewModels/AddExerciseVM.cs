using MyPolyglotWeb.Models.ViewModels.CustomAttributes;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyPolyglotWeb.Models.ViewModels
{
    public class AddExerciseVM
    {
        [Required(ErrorMessage = "Вы забыли указать урок!")]
        public string LessonId { get; set; }

        [Required(ErrorMessage = "Вы забыли ввести русское предложение!")]
        [DisplayName("На русском")]
        public string RusPhrase { get; set; }

        [Required(ErrorMessage = "Вы забыли ввести английский перевод!")]
        [DisplayName("На английском")]
        public string EngPhrase { get; set; }

        [RecognizedWordsByUser(ErrorMessage = "Вы забыли указать тип слова!")]
        public IEnumerable<UnrecognizedWordVM> UnrecognizedWords { get; set; }
    }
}