using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MyPolyglotWeb.Models.DomainModels.Words
{
    public class VerbDbModel : WordDbModel
    {
        public string PastForm { get; }
        public string PastParticipleForm { get; }
        public string PresentParticipleForm { get; }
        public string ThirdPersonForm { get; }
        public List<WordDbModel> AdditionalForms { get; set; }
    }
}