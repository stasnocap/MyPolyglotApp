using System.Linq;
using MyPolyglotCore;
using Xunit;

namespace MyPolyglotCoreTests.LessonGeneratorTests
{
    public class GenerateFirstLessonShould
    {
        [Fact]
        public void ReturnCorrectCountOfExercises()
        {
            var generator = new LessonGenerator();

            var lesson = generator.GenerateFirstLesson();

            Assert.True(lesson.Exercises.ToList().Count == LessonGenerator.NumberOfExerciseInLesson);
        }
    }
}
