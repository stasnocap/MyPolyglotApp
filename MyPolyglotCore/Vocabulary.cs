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
            new Adverb("tonight"),
            new Adverb("noon"),
            new Adverb("tomorrow"),
            new Adverb("yesterday"),
            new Adverb("already"),
            new Adverb("yet"),
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
            new LetterNumber("one", 1),
            new LetterNumber("two", 2),
            new LetterNumber("three", 3),
            new LetterNumber("four", 4),
            new LetterNumber("five", 5),
            new LetterNumber("six", 6),
            new LetterNumber("seven", 7),
            new LetterNumber("eight", 8),
            new LetterNumber("nine", 9),
            new LetterNumber("ten", 10),
            new LetterNumber("eleven", 11),
            new LetterNumber("twelve", 12),
            new LetterNumber("thirteen", 13),
            new LetterNumber("fourteen", 14),
            new LetterNumber("fifteen", 15),
            new LetterNumber("sixteen", 16),
            new LetterNumber("seventeen", 17),
            new LetterNumber("eighteen", 18),
            new LetterNumber("nineteen", 19),
            new LetterNumber("twenty", 20),
            new LetterNumber("twenty-one", 21),
            new LetterNumber("twenty-two", 22),
            new LetterNumber("twenty-three", 23),
            new LetterNumber("twenty-four", 24),
            new LetterNumber("twenty-five", 25),
            new LetterNumber("twenty-six", 26),
            new LetterNumber("twenty-seven", 27),
            new LetterNumber("twenty-eight", 28),
            new LetterNumber("twenty-nine", 29),
            new LetterNumber("thirty", 30),
            new LetterNumber("thirty-one", 31),
            new LetterNumber("thirty-two", 32),
            new LetterNumber("thirty-three", 33),
            new LetterNumber("thirty-four", 34),
            new LetterNumber("thirty-five", 35),
            new LetterNumber("thirty-six", 36),
            new LetterNumber("thirty-seven", 37),
            new LetterNumber("thirty-eight", 38),
            new LetterNumber("thirty-nine", 39),
            new LetterNumber("forty", 40),
            new LetterNumber("forty-one", 41),
            new LetterNumber("forty-two", 42),
            new LetterNumber("forty-three", 43),
            new LetterNumber("forty-four", 44),
            new LetterNumber("forty-five", 45),
            new LetterNumber("forty-six", 46),
            new LetterNumber("forty-seven", 47),
            new LetterNumber("forty-eight", 48),
            new LetterNumber("forty-nine", 49),
            new LetterNumber("fifty", 50),
            new LetterNumber("fifty-one", 51),
            new LetterNumber("fifty-two", 52),
            new LetterNumber("fifty-three", 53),
            new LetterNumber("fifty-four", 54),
            new LetterNumber("fifty-five", 55),
            new LetterNumber("fifty-six", 56),
            new LetterNumber("fifty-seven", 57),
            new LetterNumber("fifty-eight", 58),
            new LetterNumber("fifty-nine", 59),
            new LetterNumber("sixty", 60),
            new LetterNumber("sixty-one", 61),
            new LetterNumber("sixty-two", 62),
            new LetterNumber("sixty-three", 63),
            new LetterNumber("sixty-four", 64),
            new LetterNumber("sixty-five", 65),
            new LetterNumber("sixty-six", 66),
            new LetterNumber("sixty-seven", 67),
            new LetterNumber("sixty-eight", 68),
            new LetterNumber("sixty-nine", 69),
            new LetterNumber("seventy", 70),
            new LetterNumber("seventy-one", 71),
            new LetterNumber("seventy-two", 72),
            new LetterNumber("seventy-three", 73),
            new LetterNumber("seventy-four", 74),
            new LetterNumber("seventy-five", 75),
            new LetterNumber("seventy-six", 76),
            new LetterNumber("seventy-seven", 77),
            new LetterNumber("seventy-eight", 78),
            new LetterNumber("seventy-nine", 79),
            new LetterNumber("eighty", 80),
            new LetterNumber("eighty-one", 81),
            new LetterNumber("eighty-two", 82),
            new LetterNumber("eighty-three", 83),
            new LetterNumber("eighty-four", 84),
            new LetterNumber("eighty-five", 85),
            new LetterNumber("eighty-six", 86),
            new LetterNumber("eighty-seven", 87),
            new LetterNumber("eighty-eight", 88),
            new LetterNumber("eighty-nine", 89),
            new LetterNumber("ninety", 90),
            new LetterNumber("ninety-one", 91),
            new LetterNumber("ninety-two", 92),
            new LetterNumber("ninety-three", 93),
            new LetterNumber("ninety-four", 94),
            new LetterNumber("ninety-five", 95),
            new LetterNumber("ninety-six", 96),
            new LetterNumber("ninety-seven", 97),
            new LetterNumber("ninety-eight", 98),
            new LetterNumber("ninety-nine", 99),
        };

        public static readonly IEnumerable<City> Cities = new City[]
        {
            new City("hong kong"),
            new City("bangkok"),
            new City("london"),
            new City("macau"),
            new City("singapore"),
            new City("paris"),
            new City("dubai"),
            new City("new york city"),
            new City("kuala lumpur"),
            new City("istanbul"),
            new City("delhi"),
            new City("antalya"),
            new City("shenzhen"),
            new City("mumbai"),
            new City("phuket"),
            new City("rome"),
            new City("tokyo"),
            new City("pattaya"),
            new City("taipei"),
            new City("mecca"),
            new City("guangzhou"),
            new City("prague"),
            new City("medina"),
            new City("seoul"),
            new City("amsterdam"),
            new City("agra"),
            new City("miami"),
            new City("osaka"),
            new City("las vegas"),
            new City("shanghai"),
            new City("ho chi minh city"),
            new City("denpasar"),
            new City("barcelona"),
            new City("los angeles"),
            new City("milan"),
            new City("chennai"),
            new City("vienna"),
            new City("johor bahru"),
            new City("jaipur"),
            new City("cancun"),
            new City("berlin"),
            new City("cairo"),
            new City("athens"),
            new City("orlando"),
            new City("moscow"),
            new City("venice"),
            new City("madrid"),
            new City("ha long"),
            new City("riyadh"),
            new City("dublin"),
            new City("florence"),
            new City("hanoi"),
            new City("toronto"),
            new City("johannesburg"),
            new City("sydney"),
            new City("munich"),
            new City("jakarta"),
            new City("beijing"),
            new City("saint petersburg"),
            new City("brussels"),
            new City("budapest"),
            new City("jerusalem"),
            new City("lisbon"),
            new City("dammam"),
            new City("penang island"),
            new City("heraklion"),
            new City("kyoto"),
            new City("zhuhai"),
            new City("vancouver"),
            new City("chiang mai"),
            new City("copenhagen"),
            new City("san francisco"),
            new City("melbourne"),
            new City("warsaw"),
            new City("marrakesh"),
            new City("kolkata"),
            new City("cebu city"),
            new City("auckland"),
            new City("tel aviv"),
            new City("guilin"),
            new City("honolulu"),
            new City("hurghada"),
            new City("krakow"),
            new City("mugla"),
            new City("buenos aires"),
            new City("chiba"),
            new City("frankfurt am main"),
            new City("stockholm"),
            new City("lima"),
            new City("da nang"),
            new City("batam"),
            new City("fukuoka"),
            new City("abu dhabi"),
            new City("jeju"),
            new City("porto"),
            new City("rhodes"),
            new City("rio de janeiro"),
            new City("krabi"),
            new City("bangalore"),
            new City("mexico city"),
            new City("punta cana"),
            new City("são paulo"),
            new City("zurich"),
            new City("montreal"),
            new City("washington"),
            new City("chicago"),
            new City("dusseldorf"),
            new City("boston"),
            new City("chengdu"),
            new City("edinburgh"),
            new City("san jose"),
            new City("tehran"),
            new City("houston"),
            new City("hamburg"),
            new City("cape town"),
            new City("manila"),
            new City("bogota"),
            new City("beirut"),
            new City("geneva"),
            new City("colombo"),
            new City("xiamen"),
            new City("bucharest"),
            new City("casablanca"),
            new City("atlanta"),
            new City("sofia"),
            new City("dalian"),
            new City("montevideo"),
            new City("amman"),
            new City("hangzhou"),
            new City("pune"),
            new City("durban"),
            new City("dallas"),
            new City("accra"),
            new City("quito"),
            new City("tianjin"),
            new City("qingdao"),
            new City("philadelphia"),
            new City("lagos"),        
        };

        public static readonly IEnumerable<Language> Languages = new Language[]
        {
            new Language("mandarin chinese"),
            new Language("spanish"),
            new Language("english"),
            new Language("hindi"),
            new Language("bengali"),
            new Language("portuguese"),
            new Language("russian"),
            new Language("japanese"),
            new Language("western punjabi"),
            new Language("marathi"),
            new Language("telugu"),
            new Language("wu chinese"),
            new Language("turkish"),
            new Language("korean"),
            new Language("french"),
            new Language("german"),
            new Language("vietnamese"),
            new Language("tamil"),
            new Language("yue chinese"),
            new Language("urdu"),
            new Language("javanese"),
            new Language("italian"),
            new Language("egyptian arabic"),
            new Language("gujarati"),
            new Language("iranian persian"),
            new Language("bhojpuri"),
            new Language("southern min"),
            new Language("hakka"),
            new Language("jin chinese"),
            new Language("hausa"),
            new Language("kannada"),
            new Language("indonesian"),
            new Language("polish"),
            new Language("yoruba"),
            new Language("xiang chinese"),
            new Language("malayalam"),
            new Language("odia"),
            new Language("maithili"),
            new Language("burmese"),
            new Language("eastern punjabi"),
            new Language("sunda"),
            new Language("sudanese arabic"),
            new Language("algerian arabic"),
            new Language("moroccan arabic"),
            new Language("ukrainian"),
            new Language("igbo"),
            new Language("northern uzbek"),
            new Language("sindhi"),
            new Language("north levantine arabic"),
            new Language("romanian"),
            new Language("tagalog"),
            new Language("dutch"),
            new Language("saʽidi arabic"),
            new Language("gan chinese"),
            new Language("amharic"),
            new Language("northern pashto"),
            new Language("magahi"),
            new Language("thai"),
            new Language("saraiki"),
            new Language("khmer"),
            new Language("chhattisgarhi"),
            new Language("somali"),
            new Language("malaysian"),
            new Language("cebuano"),
            new Language("nepali"),
            new Language("mesopotamian arabic"),
            new Language("assamese"),
            new Language("sinhalese"),
            new Language("northern kurdish"),
            new Language("hejazi arabic"),
            new Language("nigerian fulfulde"),
            new Language("bavarian"),
            new Language("south azerbaijani"),
            new Language("greek"),
            new Language("chittagonian"),
            new Language("kazakh"),
            new Language("deccan"),
            new Language("hungarian"),
            new Language("kinyarwanda"),
            new Language("zulu"),
            new Language("south levantine arabic"),
            new Language("tunisian arabic"),
            new Language("sanaani spoken arabic"),
            new Language("northern min"),
            new Language("southern pashto"),
            new Language("rundi"),
            new Language("czech"),
            new Language("taʽizzi-adeni arabic"),
            new Language("uyghur"),
            new Language("eastern min"),
            new Language("sylheti"),
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
            .Concat(LetterNumbers)
            .Concat(Cities)
            .Concat(Languages);
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
                Type city when city == typeof(City) => Cities,
                Type language when language == typeof(Language) => Languages,
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