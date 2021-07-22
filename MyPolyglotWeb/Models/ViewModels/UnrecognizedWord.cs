using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyPolyglotCore;

namespace MyPolyglotWeb.Models.ViewModels
{
    public class UnrecognizedWord
    {
        public string Text { get; set; }
        public UnrecognizableType Type { get; set; }
    }
}
