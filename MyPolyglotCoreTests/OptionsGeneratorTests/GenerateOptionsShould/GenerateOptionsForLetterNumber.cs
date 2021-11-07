using MyPolyglotCore;
using MyPolyglotCore.Words;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForLetterNumber : OptionsChecker
    {
        [Fact]
        public void ReturnFiveWordsFormLetterNumberVocabulary()
        {
            var randomLetterNumber = RandomWordHelper.GetRandomLetterNumber();
            CheckIfFiveWordsFromVocabularyWasReturned(randomLetterNumber);
        }

        [Fact]
        public void ReturnRightWord()
        {
            var randomLetterNumber = RandomWordHelper.GetRandomLetterNumber();

            var options = _optionsGenerator.GetOptions(randomLetterNumber);

            Assert.Contains(randomLetterNumber.Text, options);
        }

        [Fact]
        public void ReturnFiveNextWordsFromRightWordsIndex_IfNextWordIsNotOutOfBoundary()
        {
            var letterNumber = new LetterNumber("twenty-six", 26);

            var expectedOptions = new List<string>();
            expectedOptions.Add(Vocabulary.LetterNumbers.First(x => x.Number == 27).Text);
            expectedOptions.Add(Vocabulary.LetterNumbers.First(x => x.Number == 28).Text);
            expectedOptions.Add(Vocabulary.LetterNumbers.First(x => x.Number == 29).Text);
            expectedOptions.Add(Vocabulary.LetterNumbers.First(x => x.Number == 30).Text);
            expectedOptions.Add(Vocabulary.LetterNumbers.First(x => x.Number == 31).Text);

            var options = _optionsGenerator.GetOptions(letterNumber);

            foreach (var option in options)
            {
                if (option == letterNumber.Text)
                {
                    continue;
                }
                Assert.Contains(option, expectedOptions);
            }
        }

        [Fact]
        public void ReturnThreeNextWordsAndTwoPrevious_IfNextWordIsOutOfBoundary()
        {
            var letterNumber = new LetterNumber("ninety-six", 96);

            var expectedOptions = new List<string>();
            // three next
            expectedOptions.Add(Vocabulary.LetterNumbers.First(x => x.Number == 97).Text);
            expectedOptions.Add(Vocabulary.LetterNumbers.First(x => x.Number == 98).Text);
            expectedOptions.Add(Vocabulary.LetterNumbers.First(x => x.Number == 99).Text);
            // two previous
            expectedOptions.Add(Vocabulary.LetterNumbers.First(x => x.Number == 95).Text);
            expectedOptions.Add(Vocabulary.LetterNumbers.First(x => x.Number == 94).Text);

            var options = _optionsGenerator.GetOptions(letterNumber);

            foreach (var option in options)
            {
                if (option == letterNumber.Text)
                {
                    continue;
                }
                Assert.Contains(option, expectedOptions);
            }
        }

        [Fact]
        public void ReturnFiveLastWord_IfLetterNumberDoesNotExistInVocabulary()
        {
            var letterNumber = new LetterNumber("one hundred", 100);

            var expectedOptions = new List<string>();
            expectedOptions.Add(Vocabulary.LetterNumbers.First(x => x.Number == 99).Text);
            expectedOptions.Add(Vocabulary.LetterNumbers.First(x => x.Number == 98).Text);
            expectedOptions.Add(Vocabulary.LetterNumbers.First(x => x.Number == 97).Text);
            expectedOptions.Add(Vocabulary.LetterNumbers.First(x => x.Number == 96).Text);
            expectedOptions.Add(Vocabulary.LetterNumbers.First(x => x.Number == 95).Text);

            var options = _optionsGenerator.GetOptions(letterNumber);

            foreach (var option in options)
            {
                if (option == letterNumber.Text)
                {
                    continue;
                }
                Assert.Contains(option, expectedOptions);
            }
        }
    }
}
