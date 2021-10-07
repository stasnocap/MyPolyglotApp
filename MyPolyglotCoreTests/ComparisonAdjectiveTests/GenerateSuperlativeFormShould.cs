using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCoreTests.ComparisonAdjectiveTests
{
    public class GenerateSuperlativeFormShould
    {
        [Theory]
        [InlineData("tall", "tallest")]
        [InlineData("old", "oldest")]
        [InlineData("long", "longest")]
        public void AddingEstToOneSyllableAdjective(string oneSyllableAdjective, string superlativeForm)
        {
            var comparisonAdjective = new ComparisonAdjective(oneSyllableAdjective, 1);

            Assert.Equal(superlativeForm, comparisonAdjective.SuperlativeForm);
        }

        [Theory]
        [InlineData("large", "largest")]
        [InlineData("wise", "wisest")]
        public void AddingStToOneSyllableAdjectiveIfItEndsWithE(string oneSyllableAdjective, string superlativeForm)
        {
            var comparisonAdjective = new ComparisonAdjective(oneSyllableAdjective, 1);

            Assert.Equal(superlativeForm, comparisonAdjective.SuperlativeForm);
        }

        [Theory]
        [InlineData("big", "biggest")]
        [InlineData("thin", "thinnest")]
        [InlineData("fat", "fattest")]
        public void DoubleLastCharacterPlusEstIfOneSyllableAdjectiveEndsWithSingleVowelPlusSingleConsonant(string oneSyllableAdjective, string superlativeForm)
        {
            var comparisonAdjective = new ComparisonAdjective(oneSyllableAdjective, 1);

            Assert.Equal(superlativeForm, comparisonAdjective.SuperlativeForm);
        }

        [Theory]
        [InlineData("happy", "happiest")]
        [InlineData("angry", "angriest")]
        [InlineData("busy", "busiest")]
        public void AddingIestIfTwoSyllableAdjectiveEndsWithY(string twoSyllableAdjective, string superlativeForm)
        {
            var comparisonAdjective = new ComparisonAdjective(twoSyllableAdjective, 2);

            Assert.Equal(superlativeForm, comparisonAdjective.SuperlativeForm);
        }

        [Theory]
        [InlineData("gentle", "gentlest")]
        [InlineData("humble", "humblest")]
        [InlineData("simple", "simplest")]
        public void AddingStIfTwoSyllableAdjectiveEndsWithLe(string twoSyllableAdjective, string superlativeForm)
        {
            var comparisonAdjective = new ComparisonAdjective(twoSyllableAdjective, 2);

            Assert.Equal(superlativeForm, comparisonAdjective.SuperlativeForm);
        }

        [Theory]
        [InlineData("narrow", "narrowest")]
        [InlineData("bitter", "bitterest")]
        public void AddingEstIfTwoSyllableAdjectiveEndsWithErOrOw(string twoSyllableAdjective, string superlativeForm)
        {
            var comparisonAdjective = new ComparisonAdjective(twoSyllableAdjective, 2);

            Assert.Equal(superlativeForm, comparisonAdjective.SuperlativeForm);
        }

        [Theory]
        [InlineData("peaceful", "most peaceful")]
        [InlineData("pleasant", "most pleasant")]
        [InlineData("careful", "most careful")]
        [InlineData("thoughtful", "most thoughtful")]
        public void AddingMostForDefaultTwoSyllableAdjectives(string twoSyllableAdjective, string superlativeForm)
        {
            var comparisonAdjective = new ComparisonAdjective(twoSyllableAdjective, 2);

            Assert.Equal(superlativeForm, comparisonAdjective.SuperlativeForm);
        }

        [Theory]
        [InlineData("generous", "most generous")]
        [InlineData("important", "most important")]
        public void AddingMostToThreeSyllableAdjective(string threeSyllableAdjective, string superlativeForm)
        {
            var comparisonAdjective = new ComparisonAdjective(threeSyllableAdjective, 3);

            Assert.Equal(superlativeForm, comparisonAdjective.SuperlativeForm);
        }

        [Fact]
        public void AddingMoreToFourSyllableAdjective()
        {
            var fourSyllableAdjective = "intelligent";
            var superlativeForm = "most intelligent";

            var comparisonAdjective = new ComparisonAdjective(fourSyllableAdjective, 4);

            Assert.Equal(superlativeForm, comparisonAdjective.SuperlativeForm);
        }

        [Theory]
		[InlineData("angry", "angriest", 2)]
		[InlineData("beautiful", "most beautiful", 5)]
		[InlineData("big", "biggest", 1)]
		[InlineData("bitter", "bitterest", 2)]
		[InlineData("black", "blackest", 1)]
		[InlineData("bland", "blandest", 1)]
		[InlineData("bloody", "bloodiest", 2)]
		[InlineData("blue", "bluest", 1)]
		[InlineData("bold", "boldest", 1)]
		[InlineData("bossy", "bossiest", 2)]
		[InlineData("brave", "bravest", 1)]
		[InlineData("brief", "briefest", 1)]
		[InlineData("bright", "brightest", 1)]
		[InlineData("broad", "broadest", 1)]
		[InlineData("busy", "busiest", 2)]
		[InlineData("calm", "calmest", 1)]
		[InlineData("cheap", "cheapest", 1)]
		[InlineData("chewy", "chewiest", 2)]
		[InlineData("chubby", "chubbiest", 2)]
		[InlineData("classy", "classiest", 2)]
		[InlineData("clean", "cleanest", 1)]
		[InlineData("clear", "clearest", 1)]
		[InlineData("clever", "cleverest", 2)]
		[InlineData("close", "closest", 1)]
		[InlineData("cloudy", "cloudiest", 2)]
		[InlineData("clumsy", "clumsiest", 2)]
		[InlineData("coarse", "coarsest", 1)]
		[InlineData("cold", "coldest", 1)]
		[InlineData("cool", "coolest", 1)]
		[InlineData("crazy", "craziest", 2)]
		[InlineData("creamy", "creamiest", 2)]
		[InlineData("creepy", "creepiest", 2)]
		[InlineData("crispy", "crispiest", 2)]
		[InlineData("cruel", "most cruel", 2)]
		[InlineData("crunchy", "crunchiest", 2)]
		[InlineData("curly", "curliest", 2)]
		[InlineData("curvy", "curviest", 2)]
		[InlineData("cute", "cutest", 1)]
		[InlineData("damp", "dampest", 1)]
		[InlineData("dark", "darkest", 1)]
		[InlineData("deadly", "deadliest", 2)]
		[InlineData("deep", "deepest", 1)]
		[InlineData("dense", "densest", 1)]
		[InlineData("difficult", "most difficult", 3)]
		[InlineData("dirty", "dirtiest", 2)]
		[InlineData("dry", "dryest", 1)]
		[InlineData("dull", "dullest", 1)]
		[InlineData("dumb", "dumbest", 1)]
		[InlineData("dusty", "dustiest", 2)]
		[InlineData("early", "earliest", 2)]
		[InlineData("easy", "easiest", 2)]
		[InlineData("expensive", "most expensive", 3)]
		[InlineData("faint", "faintest", 1)]
		[InlineData("fair", "fairest", 1)]
		[InlineData("fancy", "fanciest", 2)]
		[InlineData("fast", "fastest", 1)]
		[InlineData("fat", "fattest", 1)]
		[InlineData("few", "fewest", 1)]
		[InlineData("fierce", "fiercest", 1)]
		[InlineData("filthy", "filthiest", 2)]
		[InlineData("fine", "finest", 1)]
		[InlineData("firm", "firmest", 1)]
		[InlineData("fit", "fittest", 1)]
		[InlineData("flaky", "flakiest", 2)]
		[InlineData("flat", "flattest", 1)]
		[InlineData("fresh", "freshest", 1)]
		[InlineData("friendly", "friendliest", 2)]
		[InlineData("full", "fullest", 1)]
		[InlineData("funny", "funniest", 2)]
		[InlineData("gentle", "gentlest", 1)]
		[InlineData("gloomy", "gloomiest", 2)]
		[InlineData("grand", "grandest", 1)]
		[InlineData("grave", "gravest", 1)]
		[InlineData("greasy", "greasiest", 2)]
		[InlineData("great", "greatest", 1)]
		[InlineData("greedy", "greediest", 2)]
		[InlineData("gross", "grossest", 1)]
		[InlineData("guilty", "guiltiest", 2)]
		[InlineData("hairy", "hairiest", 2)]
		[InlineData("handy", "handiest", 2)]
		[InlineData("happy", "happiest", 2)]
		[InlineData("hard", "hardest", 1)]
		[InlineData("harsh", "harshest", 1)]
		[InlineData("healthy", "healthiest", 2)]
		[InlineData("heavy", "heaviest", 2)]
		[InlineData("high", "highest", 1)]
		[InlineData("hip", "hippest", 1)]
		[InlineData("hot", "hottest", 1)]
		[InlineData("humble", "humblest", 1)]
		[InlineData("hungry", "hungriest", 2)]
		[InlineData("icy", "iciest", 2)]
		[InlineData("interesting", "most interesting", 4)]
		[InlineData("itchy", "itchiest", 2)]
		[InlineData("juicy", "juiciest", 2)]
		[InlineData("kind", "kindest", 1)]
		[InlineData("large", "largest", 1)]
		[InlineData("late", "latest", 1)]
		[InlineData("lazy", "laziest", 2)]
		[InlineData("light", "lightest", 1)]
		[InlineData("likely", "likeliest", 2)]
		[InlineData("little", "littlest", 1)]
		[InlineData("lively", "liveliest", 2)]
		[InlineData("lonely", "loneliest", 2)]
		[InlineData("long", "longest", 1)]
		[InlineData("loud", "loudest", 1)]
		[InlineData("lovely", "loveliest", 2)]
		[InlineData("low", "lowest", 1)]
		[InlineData("mad", "maddest", 1)]
		[InlineData("mean", "meanest", 1)]
		[InlineData("messy", "messiest", 2)]
		[InlineData("mild", "mildest", 1)]
		[InlineData("modern", "most modern", 2)]
		[InlineData("moist", "moistest", 1)]
		[InlineData("narrow", "narrowest", 2)]
		[InlineData("nasty", "nastiest", 2)]
		[InlineData("naughty", "naughtiest", 2)]
		[InlineData("near", "nearest", 1)]
		[InlineData("neat", "neatest", 1)]
		[InlineData("needy", "neediest", 2)]
		[InlineData("new", "newest", 1)]
		[InlineData("nice", "nicest", 1)]
		[InlineData("noisy", "noisiest", 2)]
		[InlineData("odd", "oddest", 1)]
		[InlineData("oily", "oiliest", 2)]
		[InlineData("old", "oldest", 1)]
		[InlineData("plain", "plainest", 1)]
		[InlineData("polite", "politest", 2)]
		[InlineData("poor", "poorest", 1)]
		[InlineData("popular", "most popular", 3)]
		[InlineData("pretty", "prettiest", 2)]
		[InlineData("proud", "proudest", 1)]
		[InlineData("pure", "purest", 1)]
		[InlineData("quick", "quickest", 1)]
		[InlineData("quiet", "quietest", 1)]
		[InlineData("rare", "rarest", 1)]
		[InlineData("raw", "rawest", 1)]
		[InlineData("rich", "richest", 1)]
		[InlineData("ripe", "ripest", 1)]
		[InlineData("risky", "riskiest", 2)]
		[InlineData("roomy", "roomiest", 2)]
		[InlineData("rough", "roughest", 1)]
		[InlineData("rude", "rudest", 1)]
		[InlineData("rusty", "rustiest", 2)]
		[InlineData("sad", "saddest", 1)]
		[InlineData("safe", "safest", 1)]
		[InlineData("salty", "saltiest", 2)]
		[InlineData("sane", "sanest", 1)]
		[InlineData("scary", "scariest", 2)]
		[InlineData("shallow", "shallowest", 2)]
		[InlineData("sharp", "sharpest", 1)]
		[InlineData("shiny", "shiniest", 2)]
		[InlineData("short", "shortest", 1)]
		[InlineData("shy", "shyest", 1)]
		[InlineData("silly", "silliest", 2)]
		[InlineData("simple", "simplest", 1)]
		[InlineData("sincere", "most sincere", 2)]
		[InlineData("skinny", "skinniest", 2)]
		[InlineData("sleepy", "sleepiest", 2)]
		[InlineData("slim", "slimmest", 1)]
		[InlineData("slimy", "slimiest", 2)]
		[InlineData("slow", "slowest", 1)]
		[InlineData("small", "smallest", 1)]
		[InlineData("smart", "smartest", 1)]
		[InlineData("smelly", "smelliest", 2)]
		[InlineData("smoky", "smokiest", 2)]
		[InlineData("smooth", "smoothest", 1)]
		[InlineData("soft", "softest", 1)]
		[InlineData("soon", "soonest", 1)]
		[InlineData("sore", "sorest", 1)]
		[InlineData("sorry", "sorriest", 2)]
		[InlineData("sour", "sourest", 1)]
		[InlineData("spicy", "spiciest", 2)]
		[InlineData("steep", "steepest", 1)]
		[InlineData("stingy", "stingiest", 2)]
		[InlineData("strange", "strangest", 1)]
		[InlineData("strict", "strictest", 1)]
		[InlineData("strong", "strongest", 1)]
		[InlineData("sunny", "sunniest", 2)]
		[InlineData("sweaty", "sweatiest", 2)]
		[InlineData("sweet", "sweetest", 1)]
		[InlineData("tall", "tallest", 1)]
		[InlineData("tan", "tannest", 1)]
		[InlineData("tasty", "tastiest", 2)]
		[InlineData("thick", "thickest", 1)]
		[InlineData("thin", "thinnest", 1)]
		[InlineData("thirsty", "thirstiest", 2)]
		[InlineData("tiny", "tiniest", 2)]
		[InlineData("tired", "most tired", 2)]
		[InlineData("tough", "toughest", 1)]
		[InlineData("true", "truest", 1)]
		[InlineData("ugly", "ugliest", 2)]
		[InlineData("warm", "warmest", 1)]
		[InlineData("weak", "weakest", 1)]
		[InlineData("wealthy", "wealthiest", 2)]
		[InlineData("weird", "weirdest", 1)]
		[InlineData("wet", "wettest", 1)]
		[InlineData("wide", "widest", 1)]
		[InlineData("wild", "wildest", 1)]
		[InlineData("windy", "windiest", 2)]
		[InlineData("wise", "wisest", 1)]
		[InlineData("worldly", "worldliest", 2)]
		[InlineData("worthy", "worthiest", 2)]
		[InlineData("young", "youngest", 1)]
		public void OverallTest(string adjective, string superlativeForm, int countOfSyllables)
        {
            var comparisonAdjective = new ComparisonAdjective(adjective, countOfSyllables);

            Assert.Equal(superlativeForm, comparisonAdjective.SuperlativeForm);
        }
    }
}
