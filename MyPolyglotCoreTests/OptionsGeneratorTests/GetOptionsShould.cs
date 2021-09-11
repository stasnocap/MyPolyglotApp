using System;
using System.Linq;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;
using Xunit;

namespace MyPolyglotCore.Tests.OptionsGeneratorTests
{
    public class GetOptionsShould
    {
        private readonly Random _random = new Random();

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
            var options = optionsGenerator.GetOptions(word);
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
            var options = optionsGenerator.GetOptions(word);
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
            var irregularVerbVocabulary = Vocabulary.IrregularVerbs.ToList();
            var randomVerb = irregularVerbVocabulary[_random.Next(irregularVerbVocabulary.Count)];

            var verbForms = new string[]
            {
                randomVerb.Text,
                randomVerb.PastForm,
                randomVerb.PastParticipleForm,
                randomVerb.PresentParticipleForm,
                randomVerb.ThirdPersonForm,
            };

            var optionsGenerator = new OptionsGenerator();
            var options = optionsGenerator.GetOptions(randomVerb);

            foreach (var form in verbForms)
            {
                Assert.Contains(form, options);
            }
        }

        [Fact]
        public void GenerateOptionsForRegularVerbs()
        {
            var verb = new Verb("play");

            var verbForms = new string[]
            {
                verb.Text,
                verb.PastForm,
                verb.PastParticipleForm,
                verb.ThirdPersonForm,
            };

            var optionsGenerator = new OptionsGenerator();
            var options = optionsGenerator.GetOptions(verb);

            foreach (var form in verbForms)
            {
                Assert.Contains(form, options);
            }
        }

        [Fact]
        public void GivenModalVerb_ReturnCollectionThatContainsPassedModalVerbTextAndNegativeForm()
        {
            var modalVerbVocabulary = Vocabulary.ModalVerbs.ToList();
            var randomModalVerb = modalVerbVocabulary[_random.Next(modalVerbVocabulary.Count)];

            var optionsGenerator = new OptionsGenerator();
            var options = optionsGenerator.GetOptions(randomModalVerb);

            Assert.Contains(randomModalVerb.Text, options);
            Assert.Contains(randomModalVerb.NegativeForm, options);
        }

        [Fact]
        public void GivenModalVerb_ReturnCollectionWithRandomModalVerbs()
        {
            var modalVerbVocabulary = Vocabulary.ModalVerbs.ToList();
            var randomModalVerb = modalVerbVocabulary[_random.Next(modalVerbVocabulary.Count)];

            var optionsGenerator = new OptionsGenerator();
            var options = optionsGenerator.GetOptions(randomModalVerb);

            var modalVerbsTextsAndNegativeForms = modalVerbVocabulary
                .Select(x => x.Text)
                .Concat(modalVerbVocabulary.Select(x => x.NegativeForm));

            foreach (var option in options)
            {
                Assert.Contains(option, modalVerbsTextsAndNegativeForms);
            }
        }
    }
}