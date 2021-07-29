using MyPolyglotCore;
using MyPolyglotCore.Words;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MyPolyglotCoreTests
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var verb = new Verb("play") { AdditionalForms = new List<string>() { "am"} };

            var word = new Word("am");

            Assert.True(verb.Equals(word));
        }

        [Fact]
        public void Test2()
        {
            var recognizer = new Recognizer("arst arsta am rst");

        }
    }
}
