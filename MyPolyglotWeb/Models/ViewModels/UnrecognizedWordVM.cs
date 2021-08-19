using MyPolyglotCore;
using System.ComponentModel.DataAnnotations;

namespace MyPolyglotWeb.Models.ViewModels
{
    public class UnrecognizedWordVM
    {
        [Required]
        public string Text { get; set; }

        [Required]
        public UnrecognizableTypes Type { get; set; }
    }
}
