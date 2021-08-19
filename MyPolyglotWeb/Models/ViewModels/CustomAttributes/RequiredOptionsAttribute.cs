using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MyPolyglotWeb.Models.ViewModels.CustomAttributes
{
    public class RequiredOptionsAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var options = value as List<string>;
            return !options?.Where(x => string.IsNullOrEmpty(x)).Any() ?? false;
        }
    }
}
