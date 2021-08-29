using MyPolyglotWeb.Constants;
using MyPolyglotWeb.Models.ViewModels.CustomAttributes;
using System.Collections.Generic;

namespace MyPolyglotWeb.Models.ViewModels
{
    public class OptionGroup
    {
        [RequiredOptions(ErrorMessage = CustomConst.UserTriesToBreakMe)]
        public List<string> Options { get; set; }
    }
}
