using MyPolyglotCore;
using MyPolyglotCore.Words;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MyPolyglotCoreTests.ExerciseTests
{
    public class NextOptionsShould
    {
        [Fact]
        public void ReturnOptionsIfNextWordExist()
        {
            var exercise = new Exercise("I am cool.", new List<Word>() { new Adjective("cool") });

            for (int i = 0; i < 3; i++)
            {
                Assert.NotEmpty(exercise.NextOptions());
            }
        }

        [Fact]
        public void ReturnEmptyIfOutOfBoundary()
        {
            var exercise = new Exercise("I am cool.", new List<Word>() { new Adjective("cool") });

            var options = Enumerable.Empty<string>();
            for (int i = 0; i < 4; i++)
            {
                options = exercise.NextOptions();
            }

            Assert.Empty(options);
        }
    }
}
