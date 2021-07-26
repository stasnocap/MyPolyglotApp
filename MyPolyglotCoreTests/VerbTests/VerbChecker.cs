using MyPolyglotCore.Words;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MyPolyglotCoreTests.VerbTests
{
    public class VerbChecker
    {
        protected void CheckCorrectGeneration(string text, string expectedText, bool stressOnTheFinalSyllable = false)
        {
            var verb = new Verb(text) { StressOnTheFinalSyllable = stressOnTheFinalSyllable };
            Assert.Equal(expectedText, verb.PresentParticipleForm);
        }
    }
}
