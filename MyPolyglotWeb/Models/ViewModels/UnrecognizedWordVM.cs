using MyPolyglotCore;
using System.ComponentModel.DataAnnotations;

namespace MyPolyglotWeb.Models.ViewModels
{
    public class UnrecognizedWordVM
    {
        [Required(ErrorMessage = "Зачем ты пытаешься сломать меня?")]
        public string Text { get; set; }

        [Required(ErrorMessage = "Зачем ты пытаешься сломать меня?")]
        public UnrecognizableTypes Type { get; set; }
    }
}
