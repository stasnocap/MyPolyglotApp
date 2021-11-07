using MyPolyglotCore;
using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCoreTests.RecognizerTests.RecognizeShould
{
    public class RecognizeNoun : RecognizingChecker
    {
        [Fact]
        public void RecognizeNounByText()
        {
            var randomNoun = RandomWordHelper.GetRandomNoun();
            CheckIfWordWasRecognizedByText(randomNoun);
        }

        [Fact]
        public void RecognizeNounByPluralForm()
        {
            var randomNoun = RandomWordHelper.GetRandomNoun();
            CheckIfNounWasRecognizedByPluralForm(randomNoun);
        }

        [Fact]
        public void RecognizeIrregularNounByText()
        {
            var randomIrregularNoun = RandomWordHelper.GetRandomIrregularVerb();
            CheckIfWordWasRecognizedByText(randomIrregularNoun);
        }

        [Fact]
        public void RecognizeIrregularNounByPluralForm()
        {
            var randomIrregularNoun = RandomWordHelper.GetRandomOccupation();
            CheckIfNounWasRecognizedByPluralForm(randomIrregularNoun);
        }


        [Fact]
        public void RecognizeDayPartByText()
        {
            var randomDayPart = RandomWordHelper.GetRandomDayPart();
            CheckIfWordWasRecognizedByText(randomDayPart);
        }

        [Fact]
        public void RecognizeDayPartByPluralForm()
        {
            var randomDayPart = RandomWordHelper.GetRandomDayPart();
            CheckIfNounWasRecognizedByPluralForm(randomDayPart);
        }

        [Fact]
        public void RecognizeYearSeasonByText()
        {
            var randomYearSeason = RandomWordHelper.GetRandomYearSeason();
            CheckIfWordWasRecognizedByText(randomYearSeason);
        }

        [Fact]
        public void RecognizeYearSeasonByPluralForm()
        {
            var randomYearSeason = RandomWordHelper.GetRandomYearSeason();
            CheckIfNounWasRecognizedByPluralForm(randomYearSeason);
        }

        [Fact]
        public void RecognizeOccupationByText()
        {
            var randomOccupation = RandomWordHelper.GetRandomOccupation();
            CheckIfWordWasRecognizedByText(randomOccupation);
        }

        [Fact]
        public void RecognizeOccupationByPluralForm()
        {
            var randomOccupation = RandomWordHelper.GetRandomOccupation();
            CheckIfNounWasRecognizedByPluralForm(randomOccupation);
        }

        private void CheckIfNounWasRecognizedByPluralForm(Noun noun)
        {
            var engPhrase =
                $",,.1 s,t! tr , starst nsetnrsit!ta stra {noun.PluralForm}, 2 arstar";

            _recognizer.Recognize(engPhrase);

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, noun));
        }

        [Fact]
        public void DoNounRememberFromWhatItWasRecognized()
        {
            CheckIfWordRememberFromWhatItWasRecognized(typeof(Noun));
        }
    }
}
