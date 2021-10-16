using MyPolyglotCore;
using MyPolyglotWeb.Constants;
using System.ComponentModel.DataAnnotations;

namespace MyPolyglotWeb.Models.ViewModels
{
    public class UnrecognizedWordVM
    {
        public long UnrecognizedWordId { get; set; }

        [Required(ErrorMessage = CustomConst.UserTriesToBreakMe)]
        public string Text { get; set; }

        [Required(ErrorMessage = CustomConst.UserTriesToBreakMe)]
        public UnrecognizableTypes Type { get; set; }

        public bool StressOnTheFinalSyllableInRegularVerb { get; set; }
    }
}
