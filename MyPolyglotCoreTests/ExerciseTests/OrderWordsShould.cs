using MyPolyglotCore;
using MyPolyglotCore.Helpers;
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
            var exercise = new Exercise(engPhrase, new List<Word> { new Adjective("cool"), new Adjective("nice"), });
            var wordsInOrder = engPhrase.SplitToWords();

            var exerciseWordsList = exercise.Words.ToList();
            var wordsInOrderList = wordsInOrder.ToList();

            for (int i = 0; i < wordsInOrderList.Count; i++)
            {
                Assert.True(exerciseWordsList[i].Equals(wordsInOrderList[i]));
            }
        }

        [Fact]
        public void ReturnRightCountOfWords()
        {
            var engPhrase = "You will be reading the book the whole day tomorrow.";

            var exercise = new Exercise(engPhrase, Enumerable.Empty<Word>());

            Assert.Equal(engPhrase.SplitToWords().Count(), exercise.Words.Count());
        }
    }
}
