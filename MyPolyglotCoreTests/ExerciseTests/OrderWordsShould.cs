using MyPolyglotCore;
using MyPolyglotCore.Words;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MyPolyglotCoreTests.ExerciseTests
{
    public class OrderWordsShould
    {
        [Fact]
        public void ReturnWordsInOrder()
        {
            var engPhrase = "Cool is a nice word.";
            var exercise = new Exercise(engPhrase, new List<Word> { new Adjective("cool"), new Adjective("nice"), new Noun("word") });
            var wordsInOrder = engPhrase.SplitToWords();

            var exerciseWordsList = exercise.Words.ToList();
            var wordsInOrderList = wordsInOrder.ToList();

            for (int i = 0; i < wordsInOrderList.Count; i++)
            {
                Assert.True(exerciseWordsList[i].Equals(wordsInOrderList[i]));
            }
        }
    }
}
