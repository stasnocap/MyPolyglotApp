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

        [Theory]
        [InlineData(typeof(Noun))]
        [InlineData(typeof(Adjective))]
        public void AddRandomFiveWordsWithRightAnswer(Type type)
        {
            var textOfWord = "no matter";

            var word = InstantiateWord(type, textOfWord);

            var optionsGenerator = new OptionsGenerator();
            var options = optionsGenerator.GetOptionsForWord(word);

            Assert.Contains(textOfWord, options);
            Assert.True(options.Count() == 6);
        }


        [Fact]
        public void GivenNoun_ReturnFiveWordsFromNounVocabularyWithRightAnswer()
        {
            var word = new Noun("no matter");
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

        private Word InstantiateWord(Type type, string textOfWord)
        {
            return type.Name switch
            {
                nameof(SubjectPronoun) => new SubjectPronoun(textOfWord),
                nameof(ObjectPronoun) => new ObjectPronoun(textOfWord),
                nameof(PossessiveAdjective) => new PossessiveAdjective(textOfWord),
                nameof(PossessivePronoun) => new PossessivePronoun(textOfWord),
                nameof(ReflexivePronoun) => new ReflexivePronoun(textOfWord),
                nameof(Determiner) => new Determiner(textOfWord),
                nameof(Noun) => new Noun(textOfWord),
                nameof(Adjective) => new Adjective(textOfWord),
                _ => throw new NotImplementedException()
            };
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