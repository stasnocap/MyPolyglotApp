using System;
using System.Collections.Generic;
using System.Linq;
using MyPolyglotCore.Words;

namespace MyPolyglotCore
{
    public static class Vocabulary
    {
        #region Letters
        public static readonly IEnumerable<char> Consonants = new char[]
        {
            'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm',
            'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z'
        };
        public static readonly IEnumerable<char> Vowels = new char[]
        {
            'a', 'e', 'i', 'o', 'u', 'y'
        };
        #endregion

        public static readonly IEnumerable<string> ThirdPersonESEndings = new string[] { "ch", "s", "sh", "x", "z" };

        public static readonly IEnumerable<Preposition> Prepositions = new Preposition[]
        {
            new Preposition("ago"),
            new Preposition("aboard"),
            new Preposition("about"),
            new Preposition("across"),
            new Preposition("after"),
            new Preposition("against"),
            new Preposition("along"),
            new Preposition("amid"),
            new Preposition("among"),
            new Preposition("anti"),
            new Preposition("around"),
            new Preposition("as"),
            new Preposition("at"),
            new Preposition("before"),
            new Preposition("behind"),
            new Preposition("beneath"),
            new Preposition("beside"),
            new Preposition("besides"),
            new Preposition("between"),
            new Preposition("beyond"),
            new Preposition("but"),
            new Preposition("by"),
            new Preposition("concerning"),
            new Preposition("considering"),
            new Preposition("despite"),
            new Preposition("down"),
            new Preposition("during"),
            new Preposition("except"),
            new Preposition("excepting"),
            new Preposition("excluding"),
            new Preposition("following"),
            new Preposition("for"),
            new Preposition("from"),
            new Preposition("in"),
            new Preposition("into"),
            new Preposition("minus"),
            new Preposition("near"),
            new Preposition("of"),
            new Preposition("off"),
            new Preposition("on"),
            new Preposition("onto"),
            new Preposition("opposite"),
            new Preposition("over"),
            new Preposition("past"),
            new Preposition("per"),
            new Preposition("plus"),
            new Preposition("regarding"),
            new Preposition("round"),
            new Preposition("save"),
            new Preposition("since"),
            new Preposition("than"),
            new Preposition("through"),
            new Preposition("to"),
            new Preposition("toward"),
            new Preposition("towards"),
            new Preposition("under"),
            new Preposition("underneath"),
            new Preposition("unlike"),
            new Preposition("until"),
            new Preposition("up"),
            new Preposition("upon"),
            new Preposition("versus"),
            new Preposition("via"),
            new Preposition("with"),
            new Preposition("within"),
            new Preposition("without"),
        };

        public static readonly IEnumerable<QuestionWord> QuestionWords = new QuestionWord[]
        {
            new QuestionWord("what"),
            new QuestionWord("who"),
            new QuestionWord("where"),
            new QuestionWord("when"),
            new QuestionWord("why"),
            new QuestionWord("how"),
        };

        public static readonly IEnumerable<ComparisonAdjective> IrregularComparisonAdjectives = new ComparisonAdjective[]
        {
            new ComparisonAdjective("good", "better", "best"),
            new ComparisonAdjective("bad", "worse", "worst"),
            new ComparisonAdjective("far", "farther", "farthest"),
            new ComparisonAdjective("little", "less", "least"),
        };

        #region Adverbs

        public static readonly IEnumerable<Adverb> MannerAdverbs = new Adverb[]
        {
            new Adverb("beautifully"),
            new Adverb("generously"),
            new Adverb("happily"),
            new Adverb("neatly"),
            new Adverb("patiently"),
            new Adverb("softly"),
            new Adverb("quickly"),
            new Adverb("well"),
        };

        public static readonly IEnumerable<Adverb> TellHowItHappenedAdverbs = new Adverb[]
        {
            new Adverb("briskly"),
            new Adverb("brutally"),
            new Adverb("cheerfully"),
            new Adverb("expertly"),
            new Adverb("randomly"),
            new Adverb("sloppily"),
            new Adverb("uneasily"),
            new Adverb("weirdly"),
            new Adverb("wholeheartedly"),
            new Adverb("wickedly"),
        };

        public static readonly IEnumerable<Adverb> TellWhereItHappenedAdverbs = new Adverb[]
        {
            new Adverb("here"),
            new Adverb("there"),
            new Adverb("downstairs"),
            new Adverb("upstairs"),
            new Adverb("inside"),
            new Adverb("outside"),
            new Adverb("underground"),
            new Adverb("above"),
            new Adverb("back"),
            new Adverb("below"),
            new Adverb("out"),
        };

        public static readonly IEnumerable<Adverb> TellWhenItHappenedAdverbs = new Adverb[]
        {
            new Adverb("early"),
            new Adverb("first"),
            new Adverb("last"),
            new Adverb("later"),
            new Adverb("now"),
            new Adverb("regularly"),
            new Adverb("today"),
            new Adverb("tomorrow"),
            new Adverb("yesterday"),
            new Adverb("already"),
            new Adverb("immediately"),
            new Adverb("lately"),
            new Adverb("recently"),
            new Adverb("soon"),
        };

        public static readonly IEnumerable<Adverb> TellTheExtentOfTheActionAdverbs = new Adverb[]
        {
            new Adverb("almost"),
            new Adverb("also"),
            new Adverb("enough"),
            new Adverb("only"),
            new Adverb("quite"),
            new Adverb("rather"),
            new Adverb("so"),
            new Adverb("too"),
            new Adverb("very"),
            new Adverb("hardly"),
            new Adverb("just"),
            new Adverb("nearly"),
        };

        public static readonly IEnumerable<Adverb> IntensifierAdverbs = new Adverb[]
        {
            new Adverb("literally"),
            new Adverb("simply"),
            new Adverb("really"),
            new Adverb("sure"),
            new Adverb("completely"),
            new Adverb("heartily"),
            new Adverb("totally"),
            new Adverb("absolutely"),
            new Adverb("somewhat"),
            new Adverb("mildly"),
        };

        public static readonly IEnumerable<Adverb> FrequencyAdverbs = new Adverb[]
        {
            new Adverb("again"),
            new Adverb("always"),
            new Adverb("every"),
            new Adverb("never"),
            new Adverb("normally"),
            new Adverb("rarely"),
            new Adverb("seldom"),
            new Adverb("usually"),
        };

        #endregion

        #region Pronouns

        public static readonly IEnumerable<Pronoun> SubjectPronouns = new Pronoun[]
        {
            new Pronoun("i"),
            new Pronoun("you"),
            new Pronoun("he"),
            new Pronoun("she"),
            new Pronoun("it"),
            new Pronoun("we"),
            new Pronoun("they"),
        };

        public static readonly IEnumerable<Pronoun> ObjectPronouns = new Pronoun[]
        {
            new Pronoun("me"),
            new Pronoun("him"),
            new Pronoun("us"),
            new Pronoun("them"),
        };

        public static readonly IEnumerable<Pronoun> PossessiveAdjectives = new Pronoun[]
        {
            new Pronoun("my"),
            new Pronoun("your"),
            new Pronoun("his"),
            new Pronoun("her"),
            new Pronoun("its"),
            new Pronoun("our"),
            new Pronoun("their"),
        };

        public static readonly IEnumerable<Pronoun> PossessivePronouns = new Pronoun[]
        {
            new Pronoun("mine"),
            new Pronoun("hers"),
            new Pronoun("ours"),
            new Pronoun("theirs"),
        };

        public static readonly IEnumerable<Pronoun> ReflexivePronouns = new Pronoun[]
        {
            new Pronoun("myself"),
            new Pronoun("yourself"),
            new Pronoun("himself"),
            new Pronoun("herself"),
            new Pronoun("itself"),
            new Pronoun("ourselves"),
            new Pronoun("yourselves"),
            new Pronoun("themselves"),
        };

        public static readonly IEnumerable<Pronoun> DemonstrativePronouns = new Pronoun[]
        {
            new Pronoun("this"),
            new Pronoun("that"),
            new Pronoun("these"),
            new Pronoun("those"),
        };

        #endregion

        #region Compounds

        public static readonly IEnumerable<Compound> SomeCompounds = new Compound[]
        {
            new Compound("something"),
            new Compound("somebody"),
            new Compound("someone"),
            new Compound("somewhere"),
            new Compound("sometimes"),
        };

        public static readonly IEnumerable<Compound> AnyCompounds = new Compound[]
{
            new Compound("anything"),
            new Compound("anybody"),
            new Compound("anyone"),
            new Compound("anywhere"),
        };

        public static readonly IEnumerable<Compound> EveryCompounds = new Compound[]
        {
            new Compound("everything"),
            new Compound("everybody"),
            new Compound("everyone"),
            new Compound("everywhere"),
        };

        public static readonly IEnumerable<Compound> NoCompounds = new Compound[]
        {
            new Compound("nothing"),
            new Compound("nobody"),
            new Compound("nowhere"),
        };

        #endregion

        public static readonly IEnumerable<Determiner> Determiners = new Determiner[]
        {
            new Determiner("the"),
            new Determiner("a"),
            new Determiner("an"),
        };

        public static readonly IEnumerable<Adjective> Adjectives = new Adjective[]
        {
            new Adjective("able"),
            new Adjective("big"),
            new Adjective("black"),
            new Adjective("certain"),
            new Adjective("clear"),
            new Adjective("different"),
            new Adjective("easy"),
            new Adjective("economic"),
            new Adjective("federal"),
            new Adjective("free"),
            new Adjective("full"),
            new Adjective("great"),
            new Adjective("hard"),
            new Adjective("high"),
            new Adjective("human"),
            new Adjective("important"),
            new Adjective("international"),
            new Adjective("large"),
            new Adjective("late"),
            new Adjective("local"),
            new Adjective("long"),
            new Adjective("low"),
            new Adjective("major"),
            new Adjective("military"),
            new Adjective("national"),
            new Adjective("new"),
            new Adjective("old"),
            new Adjective("other"),
            new Adjective("political"),
            new Adjective("possible"),
            new Adjective("public"),
            new Adjective("real"),
            new Adjective("recent"),
            new Adjective("right"),
            new Adjective("small"),
            new Adjective("social"),
            new Adjective("special"),
            new Adjective("strong"),
            new Adjective("true"),
            new Adjective("white"),
            new Adjective("whole"),
            new Adjective("young"),
        };

        #region Nouns
        public static readonly IEnumerable<Noun> Occupations = new Noun[]
        {
            new Noun("accountant"),
            new Noun("actor"),
            new Noun("actress"),
            new Noun("architect"),
            new Noun("astronomer"),
            new Noun("author"),
            new Noun("baker"),
            new Noun("bricklayer"),
            new Noun("bus"),
            new Noun("driver"),
            new Noun("butcher"),
            new Noun("carpenter"),
            new Noun("chef"),
            new Noun("cleaner"),
            new Noun("dentist"),
            new Noun("designer"),
            new Noun("doctor"),
            new Noun("dustman"),
            new Noun("electrician"),
            new Noun("engineer"),
            new Noun("farmer"),
            new Noun("fireman"),
            new Noun("fisherman"),
            new Noun("florist"),
            new Noun("gardener"),
            new Noun("hairdresser"),
            new Noun("journalist"),
            new Noun("judge"),
            new Noun("lawyer"),
            new Noun("lecturer"),
            new Noun("librarian"),
            new Noun("lifeguard"),
            new Noun("mechanic"),
            new Noun("model"),
            new Noun("newsreader"),
            new Noun("nurse"),
            new Noun("optician"),
            new Noun("painter"),
            new Noun("pharmacist"),
            new Noun("photographer"),
            new Noun("pilot"),
            new Noun("plumber"),
            new Noun("politician"),
            new Noun("policeman"),
            new Noun("policewoman"),
            new Noun("postman"),
            new Noun("receptionist"),
            new Noun("scientist"),
            new Noun("secretary"),
            new Noun("soldier"),
            new Noun("tailor"),
            new Noun("teacher"),
            new Noun("translator"),
            new Noun("waiter"),
            new Noun("waitress"),
        };

        public static readonly IEnumerable<Noun> DayParts = new Noun[]
        {
            new Noun("morning"),
            new Noun("afternoon"),
            new Noun("evening"),
            new Noun("night"),
        };

        public static readonly IEnumerable<Noun> YearSeasons = new Noun[]
        {
            new Noun("winter"),
            new Noun("spring"),
            new Noun("summer"),
            new Noun("autumn"),
        };

        public static readonly IEnumerable<Noun> IrregularNouns = new Noun[]
        {
            new Noun("child", "children"),
            new Noun("goose", "geese"),
            new Noun("man", "men"),
            new Noun("woman", "women"),
            new Noun("tooth", "teeth"),
            new Noun("foot", "feet"),
            new Noun("mouse", "mice"),
            new Noun("person", "people"),
        };

        public static readonly IEnumerable<Noun> Nouns = new Noun[]
        {
            new Noun("weekend"),
            new Noun("time"),
            new Noun("year"),
            new Noun("way"),
            new Noun("day"),
            new Noun("thing"),
            new Noun("life"),
            new Noun("world"),
            new Noun("school"),
            new Noun("state"),
            new Noun("family"),
            new Noun("student"),
            new Noun("group"),
            new Noun("country"),
            new Noun("problem"),
            new Noun("hand"),
            new Noun("part"),
            new Noun("place"),
            new Noun("case"),
            new Noun("week"),
            new Noun("company"),
            new Noun("system"),
            new Noun("program"),
            new Noun("question"),
            new Noun("government"),
            new Noun("number"),
            new Noun("point"),
            new Noun("home"),
            new Noun("water"),
            new Noun("room"),
            new Noun("mother"),
            new Noun("area"),
            new Noun("money"),
            new Noun("story"),
            new Noun("fact"),
            new Noun("month"),
            new Noun("lot"),
            new Noun("book"),
            new Noun("eye"),
            new Noun("job"),
            new Noun("word"),
            new Noun("business"),
            new Noun("issue"),
            new Noun("side"),
            new Noun("kind"),
            new Noun("head"),
            new Noun("house"),
            new Noun("service"),
            new Noun("friend"),
            new Noun("father"),
            new Noun("power"),
            new Noun("hour"),
            new Noun("game"),
            new Noun("line"),
            new Noun("end"),
            new Noun("member"),
            new Noun("law"),
            new Noun("car"),
            new Noun("city"),
            new Noun("community"),
            new Noun("name"),
            new Noun("president"),
            new Noun("team"),
            new Noun("minute"),
            new Noun("idea"),
            new Noun("kid"),
            new Noun("body"),
            new Noun("information"),
            new Noun("parent"),
            new Noun("face"),
            new Noun("others"),
            new Noun("level"),
            new Noun("office"),
            new Noun("door"),
            new Noun("health"),
            new Noun("art"),
            new Noun("war"),
            new Noun("history"),
            new Noun("party"),
            new Noun("result"),
            new Noun("change"),
            new Noun("reason"),
            new Noun("research"),
            new Noun("girl"),
            new Noun("guy"),
            new Noun("moment"),
            new Noun("air"),
            new Noun("teacher"),
            new Noun("force"),
            new Noun("education"),
        };
        #endregion

        public static readonly IEnumerable<Verb> IrregularVerbs = new Verb[]
        {
            new Verb("abide", "abode", "abode"),
            new Verb("arise", "arose", "arisen"),
            new Verb("awake", "awoke", "awoken"),
            new Verb("bear", "bore", "born"),
            new Verb("beat", "beat", "beaten"),
            new Verb("become", "became", "become"),
            new Verb("beget", "begot", "begotten"),
            new Verb("begin", "began", "begun"),
            new Verb("bend", "bent", "bent"),
            new Verb("bet", "bet", "bet"),
            new Verb("bid", "bade", "bidden"),
            new Verb("bite", "bit", "bitten"),
            new Verb("bleed", "bled", "bled"),
            new Verb("blow", "blew", "blown"),
            new Verb("break", "broke", "broken"),
            new Verb("bring", "brought", "brought"),
            new Verb("broadcast", "broadcast", "broadcast"),
            new Verb("build", "built", "built"),
            new Verb("burn", "burnt", "burnt"),
            new Verb("burst", "burst", "burst"),
            new Verb("buy", "bought", "bought"),
            new Verb("cast", "cast", "cast"),
            new Verb("catch", "caught", "caught"),
            new Verb("chide", "chid", "chidden"),
            new Verb("choose", "chose", "chosen"),
            new Verb("cling", "clung", "clung"),
            new Verb("clothe", "clad", "clad"),
            new Verb("come", "came", "come"),
            new Verb("cost", "cost", "cost"),
            new Verb("creep", "crept", "crept"),
            new Verb("cut", "cut", "cut"),
            new Verb("deal", "dealt", "dealt"),
            new Verb("dig", "dug", "dug"),
            new Verb("dive", "dived", "dove"),
            new Verb("draw", "drew", "drawn"),
            new Verb("dream", "dreamt", "dreamt"),
            new Verb("drink", "drank", "drunk"),
            new Verb("drive", "drove", "driven"),
            new Verb("dwell", "dwelt", "dwelt"),
            new Verb("eat", "ate", "eaten"),
            new Verb("fall", "fell", "fallen"),
            new Verb("feed", "fed", "fed"),
            new Verb("feel", "felt", "felt"),
            new Verb("fight", "fought", "fought"),
            new Verb("find", "found", "found"),
            new Verb("flee", "fled", "fled"),
            new Verb("fling", "flung", "flung"),
            new Verb("fly", "flew", "flown"),
            new Verb("forbid", "forbade", "forbidden"),
            new Verb("forecast", "forecast", "forecast"),
            new Verb("foresee", "foresaw", "foreseen"),
            new Verb("forget", "forgot", "forgotten"),
            new Verb("forgive", "forgave", "forgiven"),
            new Verb("forsake", "forsook", "forsaken"),
            new Verb("freeze", "froze", "frozen"),
            new Verb("get", "got", "gotten"),
            new Verb("give", "gave", "given"),
            new Verb("go", "went", "gone"),
            new Verb("grind", "ground", "ground"),
            new Verb("grow", "grew", "grown"),
            new Verb("hang", "hung", "hung"),
            new Verb("hear", "heard", "heard"),
            new Verb("hide", "hid", "hidden"),
            new Verb("hit", "hit", "hit"),
            new Verb("hold", "held", "held"),
            new Verb("hurt", "hurt", "hurt"),
            new Verb("keep", "kept", "kept"),
            new Verb("kneel", "knelt", "knelt"),
            new Verb("know", "knew", "known"),
            new Verb("lay", "laid", "laid"),
            new Verb("lead", "led", "led"),
            new Verb("lean", "leant", "leant"),
            new Verb("leap", "leapt", "leapt"),
            new Verb("learn", "learnt", "learnt"),
            new Verb("leave", "left", "left"),
            new Verb("lend", "lent", "lent"),
            new Verb("let", "let", "let"),
            new Verb("lie", "lay", "lain"),
            new Verb("light", "lit", "lit"),
            new Verb("lose", "lost", "lost"),
            new Verb("make", "made", "made"),
            new Verb("mean", "meant", "meant"),
            new Verb("meet", "met", "met"),
            new Verb("mow", "mowed", "mown"),
            new Verb("offset", "offset", "offset"),
            new Verb("overcome", "overcame", "overcome"),
            new Verb("partake", "partook", "partaken"),
            new Verb("pay", "paid", "paid"),
            new Verb("plead", "pled", "pled"),
            new Verb("preset", "preset", "preset"),
            new Verb("prove", "proved", "proven"),
            new Verb("put", "put", "put"),
            new Verb("quit", "quit", "quit"),
            new Verb("read", "read", "read"),
            new Verb("relay", "relaid", "relaid"),
            new Verb("rend", "rent", "rent"),
            new Verb("rid", "rid", "rid"),
            new Verb("ring", "rang", "rung"),
            new Verb("rise", "rose", "risen"),
            new Verb("run", "ran", "run"),
            new Verb("say", "said", "said"),
            new Verb("see", "saw", "seen"),
            new Verb("seek", "sought", "sought"),
            new Verb("sell", "sold", "sold"),
            new Verb("send", "sent", "sent"),
            new Verb("set", "set", "set"),
            new Verb("shake", "shook", "shaken"),
            new Verb("shed", "shed", "shed"),
            new Verb("shine", "shone", "shone"),
            new Verb("shoe", "shod", "shod"),
            new Verb("shoot", "shot", "shot"),
            new Verb("show", "showed", "shown"),
            new Verb("shut", "shut", "shut"),
            new Verb("sing", "sang", "sung"),
            new Verb("sink", "sank", "sunk"),
            new Verb("sit", "sat", "sat"),
            new Verb("slay", "slew", "slain"),
            new Verb("sleep", "slept", "slept"),
            new Verb("slide", "slid", "slid"),
            new Verb("slit", "slit", "slit"),
            new Verb("smell", "smelt", "smelt"),
            new Verb("sow", "sowed", "sown"),
            new Verb("speak", "spoke", "spoken"),
            new Verb("speed", "sped", "sped"),
            new Verb("spell", "spelt", "spelt"),
            new Verb("spend", "spent", "spent"),
            new Verb("spill", "spilt", "spilt"),
            new Verb("spin", "spun", "spun"),
            new Verb("spit", "spat", "spat"),
            new Verb("split", "split", "split"),
            new Verb("spoil", "spoilt", "spoilt"),
            new Verb("spread", "spread", "spread"),
            new Verb("spring", "sprang", "sprung"),
            new Verb("stand", "stood", "stood"),
            new Verb("steal", "stole", "stolen"),
            new Verb("stick", "stuck", "stuck"),
            new Verb("sting", "stung", "stung"),
            new Verb("stink", "stank", "stunk"),
            new Verb("strew", "strewed", "strewn"),
            new Verb("strike", "struck", "stricken"),
            new Verb("strive", "strove", "striven"),
            new Verb("swear", "swore", "sworn"),
            new Verb("sweat", "sweat", "sweat"),
            new Verb("sweep", "swept", "swept"),
            new Verb("swell", "sweated", "swollen"),
            new Verb("swim", "swam", "swum"),
            new Verb("swing", "swung", "swung"),
            new Verb("take", "took", "taken"),
            new Verb("teach", "taught", "taught"),
            new Verb("tear", "tore", "torn"),
            new Verb("tell", "told", "told"),
            new Verb("think", "thought", "thought"),
            new Verb("thrive", "throve", "thriven"),
            new Verb("throw", "threw", "thrown"),
            new Verb("thrust", "thrust", "thrust"),
            new Verb("typeset", "typeset", "typeset"),
            new Verb("undergo", "underwent", "undergone"),
            new Verb("understand", "understood", "understood"),
            new Verb("wake", "woke", "woken"),
            new Verb("wear", "wore", "worn"),
            new Verb("weep", "wept", "wept"),
            new Verb("wet", "wet", "wet"),
            new Verb("win", "won", "won"),
            new Verb("wind", "wound", "wound"),
            new Verb("withdraw", "withdrew", "withdrawn"),
            new Verb("wring", "wrung", "wrung"),
            new Verb("write", "wrote", "written"),
        };

        public static readonly IEnumerable<PrimaryVerb> PrimaryVerbs = new PrimaryVerb[]
        {
            new PrimaryVerb("do", "did", "done", "doing", "does",
                new string[] { "don't", "didn't", "doesn't"},
                new string[] { "do not", "did not", "does not"}),
            new PrimaryVerb("have", "had", "had", "having", "has",
                new string[] { "haven't", "hadn't", "hasn't"},
                new string[] { "have not", "had not", "has not"}),
            new PrimaryVerb("be", "was", "been", "being", "is",
                new string[] { "wasn't", "weren't", "am not", "isn't", "aren't"},
                new string[] { "was not", "were not", "am not", "is not", "are not" },
                new string[] { "were", "am", "are" })
        };

        public static readonly IEnumerable<ModalVerb> ModalVerbs = new ModalVerb[]
        {
            new ModalVerb("can", "cannot", "can't"),
            new ModalVerb("could", "could not", "couldn't"),
            new ModalVerb("may", "may not", "may not"),
            new ModalVerb("might", "might not", "mightn't"),
            new ModalVerb("will", "will not", "won't"),
            new ModalVerb("shall", "shall not", "shan't"),
            new ModalVerb("would", "would not", "wouldn't"),
            new ModalVerb("should", "should not", "shouldn't"),
            new ModalVerb("must", "must not", "mustn't"),
        };

        public static readonly IEnumerable<LetterNumber> LetterNumbers = new LetterNumber[]
        {
            new LetterNumber("one"),
            new LetterNumber("two"),
            new LetterNumber("three"),
            new LetterNumber("four"),
            new LetterNumber("five"),
            new LetterNumber("six"),
            new LetterNumber("seven"),
            new LetterNumber("eight"),
            new LetterNumber("nine"),
            new LetterNumber("ten"),
            new LetterNumber("eleven"),
            new LetterNumber("twelve"),
            new LetterNumber("thirteen"),
            new LetterNumber("fourteen"),
            new LetterNumber("fifteen"),
            new LetterNumber("sixteen"),
            new LetterNumber("seventeen"),
            new LetterNumber("eighteen"),
            new LetterNumber("nineteen"),
            new LetterNumber("twenty"),
            new LetterNumber("twenty-one"),
            new LetterNumber("twenty-two"),
            new LetterNumber("twenty-three"),
            new LetterNumber("twenty-four"),
            new LetterNumber("twenty-five"),
            new LetterNumber("twenty-six"),
            new LetterNumber("twenty-seven"),
            new LetterNumber("twenty-eight"),
            new LetterNumber("twenty-nine"),
            new LetterNumber("thirty"),
            new LetterNumber("thirty-one"),
            new LetterNumber("thirty-two"),
            new LetterNumber("thirty-three"),
            new LetterNumber("thirty-four"),
            new LetterNumber("thirty-five"),
            new LetterNumber("thirty-six"),
            new LetterNumber("thirty-seven"),
            new LetterNumber("thirty-eight"),
            new LetterNumber("thirty-nine"),
            new LetterNumber("forty"),
            new LetterNumber("forty-one"),
            new LetterNumber("forty-two"),
            new LetterNumber("forty-three"),
            new LetterNumber("forty-four"),
            new LetterNumber("forty-five"),
            new LetterNumber("forty-six"),
            new LetterNumber("forty-seven"),
            new LetterNumber("forty-eight"),
            new LetterNumber("forty-nine"),
            new LetterNumber("fifty"),
            new LetterNumber("fifty-one"),
            new LetterNumber("fifty-two"),
            new LetterNumber("fifty-three"),
            new LetterNumber("fifty-four"),
            new LetterNumber("fifty-five"),
            new LetterNumber("fifty-six"),
            new LetterNumber("fifty-seven"),
            new LetterNumber("fifty-eight"),
            new LetterNumber("fifty-nine"),
            new LetterNumber("sixty"),
            new LetterNumber("sixty-one"),
            new LetterNumber("sixty-two"),
            new LetterNumber("sixty-three"),
            new LetterNumber("sixty-four"),
            new LetterNumber("sixty-five"),
            new LetterNumber("sixty-six"),
            new LetterNumber("sixty-seven"),
            new LetterNumber("sixty-eight"),
            new LetterNumber("sixty-nine"),
            new LetterNumber("seventy"),
            new LetterNumber("seventy-one"),
            new LetterNumber("seventy-two"),
            new LetterNumber("seventy-three"),
            new LetterNumber("seventy-four"),
            new LetterNumber("seventy-five"),
            new LetterNumber("seventy-six"),
            new LetterNumber("seventy-seven"),
            new LetterNumber("seventy-eight"),
            new LetterNumber("seventy-nine"),
            new LetterNumber("eighty"),
            new LetterNumber("eighty-one"),
            new LetterNumber("eighty-two"),
            new LetterNumber("eighty-three"),
            new LetterNumber("eighty-four"),
            new LetterNumber("eighty-five"),
            new LetterNumber("eighty-six"),
            new LetterNumber("eighty-seven"),
            new LetterNumber("eighty-eight"),
            new LetterNumber("eighty-nine"),
            new LetterNumber("ninety"),
            new LetterNumber("ninety-one"),
            new LetterNumber("ninety-two"),
            new LetterNumber("ninety-three"),
            new LetterNumber("ninety-four"),
            new LetterNumber("ninety-five"),
            new LetterNumber("ninety-six"),
            new LetterNumber("ninety-seven"),
            new LetterNumber("ninety-eight"),
            new LetterNumber("ninety-nine"),
        };

        public static readonly IEnumerable<Word> RecognizableVocabularies = Enumerable.Empty<Word>()
            .Concat(QuestionWords)
            #region Pronouns
            .Concat(SubjectPronouns)
            .Concat(ObjectPronouns)
            .Concat(PossessiveAdjectives)
            .Concat(PossessivePronouns)
            .Concat(ReflexivePronouns)
            .Concat(DemonstrativePronouns)
            #endregion
            #region AdVerbs
            .Concat(FrequencyAdverbs)
            .Concat(IntensifierAdverbs)
            .Concat(MannerAdverbs)
            .Concat(TellHowItHappenedAdverbs)
            .Concat(TellTheExtentOfTheActionAdverbs)
            .Concat(TellWhenItHappenedAdverbs)
            .Concat(TellWhereItHappenedAdverbs)
            #endregion
            #region Compounds
            .Concat(SomeCompounds)
            .Concat(AnyCompounds)
            .Concat(EveryCompounds)
            .Concat(NoCompounds)
            #endregion
            #region Nouns
            .Concat(IrregularNouns)
            .Concat(Nouns)
            .Concat(Occupations)
            .Concat(DayParts)
            .Concat(YearSeasons)
            #endregion
            .Concat(Determiners)
            .Concat(Adjectives)
            .Concat(IrregularVerbs)
            .Concat(PrimaryVerbs)
            .Concat(ModalVerbs)
            .Concat(Prepositions)
            .Concat(IrregularComparisonAdjectives)
            .Concat(LetterNumbers);

        public static IEnumerable<Word> GetVocabulary(Type typeOfWord)
        {
            dynamic vocabulary = typeOfWord switch
            {
                Type pronoun when pronoun == typeof(Pronoun) => GetPronounVocabulary(),
                Type adverb when adverb == typeof(Adverb) => GetAdverbVocabulary(),
                Type compound when compound == typeof(Compound) => GetCompoundVocabulary(),
                Type determiner when determiner == typeof(Determiner) => Determiners,
                Type primaryVerb when primaryVerb == typeof(PrimaryVerb) => PrimaryVerbs,
                Type verb when verb == typeof(Verb) => IrregularVerbs,
                Type noun when noun == typeof(Noun) => GetNounVocabulary(),
                Type adjective when adjective == typeof(Adjective) => Adjectives,
                Type modalVerb when modalVerb == typeof(ModalVerb) => ModalVerbs,
                Type preposition when preposition == typeof(Preposition) => Prepositions,
                Type comparisonAdjective when comparisonAdjective == typeof(ComparisonAdjective) => IrregularComparisonAdjectives,
                Type letterNumber when letterNumber == typeof(LetterNumber) => LetterNumbers,
                _ => throw new NotImplementedException(),
            };
            return vocabulary;
        }

        public static IEnumerable<Pronoun> GetPronounVocabulary()
        {
            return SubjectPronouns
                .Concat(ObjectPronouns)
                .Concat(PossessiveAdjectives)
                .Concat(PossessivePronouns)
                .Concat(ReflexivePronouns)
                .Concat(DemonstrativePronouns);
        }

        public static IEnumerable<Adverb> GetAdverbVocabulary()
        {
            return FrequencyAdverbs
                .Concat(IntensifierAdverbs)
                .Concat(MannerAdverbs)
                .Concat(TellHowItHappenedAdverbs)
                .Concat(TellTheExtentOfTheActionAdverbs)
                .Concat(TellWhenItHappenedAdverbs)
                .Concat(TellWhereItHappenedAdverbs);
        }

        public static IEnumerable<Compound> GetCompoundVocabulary()
        {
            return SomeCompounds
                .Concat(AnyCompounds)
                .Concat(EveryCompounds)
                .Concat(NoCompounds);
        }

        public static IEnumerable<Noun> GetNounVocabulary()
        {
            return Nouns
                .Concat(IrregularNouns)
                .Concat(Occupations)
                .Concat(DayParts)
                .Concat(YearSeasons);
        }
    }
}