using System;
using System.Collections.Generic;
using System.Linq;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;
using Xunit;

namespace MyPolyglotCore.Tests.OptionsGeneratorTests
{
    public class GetOptionsShould
    {
        [Fact]
        public void GivenSubjectPronoun_ReturnAllWordsFromSubjectPronounVocabulary()
        {
            var word = new SubjectPronoun("no matter");
            CheckIfAllWordsFromVocabularyHadRecieved(word);
        }

        [Fact]
        public void GivenObjectPronoun_ReturnAllWordsFromObjectPronounVocabulary()
        {
            var word = new ObjectPronoun("no matter");
            CheckIfAllWordsFromVocabularyHadRecieved(word);
        }

        [Fact]
        public void GivenPossessiveAdjective_ReturnAllWordsFromPossessiveAdjectiveVocabulary()
        {
            var word = new PossessiveAdjective("no matter");
            CheckIfAllWordsFromVocabularyHadRecieved(word);
        }

        [Fact]
        public void GivenPossessivePronoun_ReturnAllWordsFromPossessivePronounVocabulary()
        {
            var word = new PossessivePronoun("no matter");
            CheckIfAllWordsFromVocabularyHadRecieved(word);
        }

        [Fact]
        public void GivenReflexivePronoun_ReturnAllWordsFromReflexivePronounVocabulary()
        {
            var word = new ReflexivePronoun("no matter");
            CheckIfAllWordsFromVocabularyHadRecieved(word);
        }

        [Fact]
        public void GivenDeterminer_ReturnAllWordsFromDeterminerVocabulary()
        {
            var word = new Determiner("no matter");
            CheckIfAllWordsFromVocabularyHadRecieved(word);
        }

        private void CheckIfAllWordsFromVocabularyHadRecieved(Word word)
        {
            var optionsGenerator = new OptionsGenerator();
            var options = optionsGenerator.GetOptionsForWord(word);
            var vocabulary = Vocabulary.GetVocabulary(word.GetType());
            foreach (var wordFromVocabulary in vocabulary)
            {
                Assert.Contains(wordFromVocabulary.Text, options);
            }
        }

        [Fact]
        public void GivenNoun_ReturnFiveWordsFromNounVocabularyWithRightAnswer()
        {
            var word = new Noun("no matter");
            CheckIfFiveWordsFromVocabularyWithRightWordHadRecieved(word);
        }

        [Fact]
        public void GivenAdjective_ReturnFiveWordsFromAdjectiveVocabularyWithRightAnswer()
        {
            var word = new Adjective("no matter");
            CheckIfFiveWordsFromVocabularyWithRightWordHadRecieved(word);
        }

        private void CheckIfFiveWordsFromVocabularyWithRightWordHadRecieved(Word word)
        {
            var optionsGenerator = new OptionsGenerator();
            var options = optionsGenerator.GetOptionsForWord(word);
            var vocabulary = Vocabulary.GetVocabulary(word.GetType());


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

        [Fact]
        public void GenerateOptionsForIrregularVerbs()
        {
            var randomVerb = Vocabulary.IrregularVerbs.ToList()[new Random().Next(Vocabulary.IrregularVerbs.Count)];

            var verbForms = new List<string>()
            {
                randomVerb.Text,
                randomVerb.PastForm,
                randomVerb.PastParticipleForm,
                randomVerb.PresentParticipleForm,
                randomVerb.ThirdPersonForm,
            };

            var optionsGenerator = new OptionsGenerator();
            var options = optionsGenerator.GetOptionsForWord(randomVerb);

            foreach (var form in verbForms)
            {
                Assert.Contains(form, options);
            }
        }

        [Fact]
        public void GenerateOptionsForRegularVerbs()
        {
            var verb = new Verb("play");

            var verbForms = new List<string>()
            {
                verb.Text,
                verb.PastForm,
                verb.PastParticipleForm,
                verb.ThirdPersonForm,
            };

            var optionsGenerator = new OptionsGenerator();
            var options = optionsGenerator.GetOptionsForWord(verb);

            foreach (var form in verbForms)
            {
                Assert.Contains(form, options);
            }
        }
    }
}