using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MyPolyglotWeb.Models.DomainModels.Words
{
    public class Verb : Word
    {
        public string PastForm { get; }
        public string PastParticipleForm { get; }
        public string PresentParticipleForm { get; }
        public string ThirdPersonForm { get; }
        public List<Word> AdditionalForms { get; set; }
    }
}