using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCoreTests.Words.VerbTests
{
    public class GeneratePastFormShould
    {
        [Theory]
        [InlineData("stop", "stopped")]
        [InlineData("plan", "planned")]
        public void DoubleLastCharPlusEDIfTextEndsWithVowelAndConsonant(string text, string expectedText)
        {
            CheckCorrectGeneration(text, expectedText);
        }

        [Theory]
        [InlineData("try", "tried")]
        [InlineData("carry", "carried")]
        public void RemoveYAndAddIEDIfTextEndsWithVowelPlusY(string text, string expectedText)
        {
            CheckCorrectGeneration(text, expectedText);
        }

        [Theory]
        [InlineData("play", "played")]
        [InlineData("enjoy", "enjoyed")]
        public void AddEDIfTextEndsWithVowelPlusY(string text, string expectedText)
        {
            CheckCorrectGeneration(text, expectedText);
        }

        [Theory]
        [InlineData("agree", "agreed")]
        [InlineData("like", "liked")]
        [InlineData("escape", "escaped")]
        public void AddDIfTextEndsWithE(string text, string expectedText)
        {
            CheckCorrectGeneration(text, expectedText);
        }
        
        private void CheckCorrectGeneration(string text, string expectedText, bool stressOnTheFinalSyllable = true)
        {
            var verb = new Verb(text, stressOnTheFinalSyllable);
            Assert.Equal(expectedText, verb.PastForm);
        }

        [Theory]
        [InlineData("accept", "accepted")]
        [InlineData("achieve", "achieved")]
        [InlineData("add", "added")]
        [InlineData("admire", "admired")]
        [InlineData("admit", "admitted")]
        [InlineData("adopt", "adopted")]
        [InlineData("advise", "advised")]
        [InlineData("agree", "agreed")]
        [InlineData("allow", "allowed", false)]
        [InlineData("announce", "announced")]
        [InlineData("appreciate", "appreciated")]
        [InlineData("approve", "approved")]
        [InlineData("argue", "argued")]
        [InlineData("arrive", "arrived")]
        [InlineData("ask", "asked")]
        [InlineData("assist", "assisted")]
        [InlineData("attack", "attacked")]
        [InlineData("bake", "baked")]
        [InlineData("beg", "begged")]
        [InlineData("behave", "behaved")]
        [InlineData("boil", "boiled", false)]
        [InlineData("borrow", "borrowed", false)]
        [InlineData("brush", "brushed")]
        [InlineData("bury", "buried")]
        [InlineData("call", "called")]
        [InlineData("challenge", "challenged")]
        [InlineData("change", "changed")]
        [InlineData("chase", "chased")]
        [InlineData("cheat", "cheated", false)]
        [InlineData("cheer", "cheered", false)]
        [InlineData("chew", "chewed")]
        [InlineData("clap", "clapped")]
        [InlineData("clean", "cleaned", false)]
        [InlineData("collect", "collected")]
        [InlineData("compare", "compared")]
        [InlineData("complain", "complained", false)]
        [InlineData("confess", "confessed")]
        [InlineData("construct", "constructed")]
        [InlineData("control", "controlled")]
        [InlineData("copy", "copied")]
        [InlineData("count", "counted")]
        [InlineData("create", "created")]
        [InlineData("cry", "cried")]
        [InlineData("cycle", "cycled")]
        [InlineData("damage", "damaged")]
        [InlineData("dance", "danced")]
        [InlineData("deliver", "delivered", false)]
        [InlineData("destroy", "destroyed")]
        [InlineData("divide", "divided")]
        [InlineData("drag", "dragged")]
        [InlineData("earn", "earned")]
        [InlineData("employ", "employed")]
        [InlineData("encourage", "encouraged")]
        [InlineData("enjoy", "enjoyed")]
        [InlineData("establish", "established")]
        [InlineData("estimate", "estimated")]
        [InlineData("exercise", "exercised")]
        [InlineData("expand", "expanded")]
        [InlineData("explain", "explained", false)]
        [InlineData("fry", "fried")]
        [InlineData("gather", "gathered", false)]
        [InlineData("greet", "greeted", false)]
        [InlineData("guess", "guessed")]
        [InlineData("harass", "harassed")]
        [InlineData("hate", "hated")]
        [InlineData("help", "helped")]
        [InlineData("hope", "hoped")]
        [InlineData("identify", "identified")]
        [InlineData("interrupt", "interrupted")]
        [InlineData("introduce", "introduced")]
        [InlineData("irritate", "irritated")]
        [InlineData("joke", "joked")]
        [InlineData("jump", "jumped")]
        [InlineData("kick", "kicked")]
        [InlineData("kill", "killed")]
        [InlineData("kiss", "kissed")]
        [InlineData("laugh", "laughed")]
        [InlineData("lie", "lied")]
        [InlineData("like", "liked")]
        [InlineData("listen", "listened", false)]
        [InlineData("love", "loved")]
        [InlineData("marry", "married")]
        [InlineData("measure", "measured")]
        [InlineData("move", "moved")]
        [InlineData("murder", "murdered", false)]
        [InlineData("need", "needed", false)]
        [InlineData("obey", "obeyed")]
        [InlineData("offend", "offended")]
        [InlineData("offer", "offered", false)]
        [InlineData("open", "opened", false)]
        [InlineData("paint", "painted")]
        [InlineData("park", "parked")]
        [InlineData("phone", "phoned")]
        [InlineData("pick", "picked")]
        [InlineData("play", "played")]
        [InlineData("pray", "prayed")]
        [InlineData("print", "printed")]
        [InlineData("pull", "pulled")]
        [InlineData("punch", "punched")]
        [InlineData("punish", "punished")]
        [InlineData("purchase", "purchased")]
        [InlineData("push", "pushed")]
        [InlineData("question", "questioned", false)]
        [InlineData("race", "raced")]
        [InlineData("relax", "relaxed")]
        [InlineData("remember", "remembered", false)]
        [InlineData("reply", "replied")]
        [InlineData("retire", "retired")]
        [InlineData("return", "returned")]
        [InlineData("rub", "rubbed")]
        [InlineData("scold", "scolded")]
        [InlineData("select", "selected")]
        [InlineData("smoke", "smoked")]
        [InlineData("snore", "snored")]
        [InlineData("stare", "stared")]
        [InlineData("start", "started")]
        [InlineData("study", "studied")]
        [InlineData("talk", "talked")]
        [InlineData("thank", "thanked")]
        [InlineData("travel", "travelled")]
        [InlineData("trouble", "troubled")]
        [InlineData("type", "typed")]
        [InlineData("use", "used")]
        [InlineData("visit", "visited", false)]
        [InlineData("wait", "waited", false)]
        [InlineData("walk", "walked")]
        [InlineData("want", "wanted")]
        [InlineData("warn", "warned")]
        [InlineData("wink", "winked")]
        [InlineData("worry", "worried")]
        [InlineData("yell", "yelled")]
        public void OverallTest(string present, string pastForm, bool stressOnTheFinalSyllable = true)
        {
            CheckCorrectGeneration(present, pastForm, stressOnTheFinalSyllable);
        }
    }
}
