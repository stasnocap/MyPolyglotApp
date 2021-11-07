using MyPolyglotCore;
using MyPolyglotCore.Interfaces;
using MyPolyglotCore.Words;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests
{
    public class OptionsChecker
    {
        protected readonly Random _random = new Random();
        protected readonly IOptionsGenerator _optionsGenerator = new OptionsGenerator();

        protected void CheckIfFiveWordsFromVocabularyWasReturned(Word word)
        {
            var vocabulary = Vocabulary.GetVocabulary(word.GetType());
            CheckIfFiveWordsFromVocabularyWasReturned(word, vocabulary);
        }

        protected void CheckIfFiveWordsFromVocabularyWasReturned(Word word, IEnumerable<Word> vocabulary)
        {
            var options = _optionsGenerator.GetOptions(word);

            foreach (var option in options)
            {
                if (option == word.Text)
                {
                    continue;
                }

                Assert.Contains(option, vocabulary.Select(x => x.Text));
            }

            Assert.Contains(word.Text, options);
        }

        protected void CheckIfRightWordWasReturned(Word word)
        {
            var options = _optionsGenerator.GetOptions(word);

            Assert.Contains(word.Text, options);
        }

        protected void CheckIfAllWordsFromVocabularyWasReturned(Word word)
        {
            CheckIfAllWordsFromVocabularyWasReturned(word, Vocabulary.GetVocabulary(word.GetType()));
        }

        protected void CheckIfAllWordsFromVocabularyWasReturned(Word word, IEnumerable<Word> vocabulary)
        {
            var options = _optionsGenerator.GetOptions(word);
            foreach (var wordFromVocabulary in vocabulary)
            {
                Assert.Contains(wordFromVocabulary.Text, options);
            }
        }

    }
}
