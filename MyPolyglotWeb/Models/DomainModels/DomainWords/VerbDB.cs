using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MyPolyglotWeb.Models.DomainModels.DomainWords
{
    public class VerbDB : WordDB
    {
        public string PastForm { get; set; }
        public string PastParticipleForm { get; set; }
        public string PresentParticipleForm { get; set; }
        public string ThirdPersonForm { get; set; }
        public List<WordDB> AdditionalForms { get; set; }
    }
}