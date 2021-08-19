using MyPolyglotCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MyPolyglotWeb.Models.ViewModels.CustomAttributes
{
    public class RecognizedWordsByUserAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var unrecognizedWords = value as IEnumerable<UnrecognizedWordVM>;
            return !unrecognizedWords?.Where(x => x.Type == UnrecognizableTypes.Undefined).Any() ?? true;
        }
    }
}
