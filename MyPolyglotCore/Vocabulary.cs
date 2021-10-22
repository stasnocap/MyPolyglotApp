using System;
using System.Collections.Generic;
using System.Linq;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Adverbs;
using MyPolyglotCore.Words.Pronouns;

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

        public static readonly IEnumerable<ComparisonAdjective> IrregularComparativeAdjectives = new ComparisonAdjective[]
        {
            new ComparisonAdjective("good", "better", "best"),
            new ComparisonAdjective("bad", "worse", "worst"),
            new ComparisonAdjective("far", "farther", "farthest"),
            new ComparisonAdjective("little", "less", "least"),
        };

        #region Adverbs

        public static readonly IEnumerable<MannerAdverb> MannerAdverbs = new MannerAdverb[]
        {
            new MannerAdverb("beautifully"),
            new MannerAdverb("generously"),
            new MannerAdverb("happily"),
            new MannerAdverb("neatly"),
            new MannerAdverb("patiently"),
            new MannerAdverb("softly"),
            new MannerAdverb("quickly"),
            new MannerAdverb("well"),
        };

        public static readonly IEnumerable<TellHowItHappenedAdverb> TellHowItHappenedAdverbs = new TellHowItHappenedAdverb[]
        {
            new TellHowItHappenedAdverb("briskly"),
            new TellHowItHappenedAdverb("brutally"),
            new TellHowItHappenedAdverb("cheerfully"),
            new TellHowItHappenedAdverb("expertly"),
            new TellHowItHappenedAdverb("randomly"),
            new TellHowItHappenedAdverb("sloppily"),
            new TellHowItHappenedAdverb("uneasily"),
            new TellHowItHappenedAdverb("weirdly"),
            new TellHowItHappenedAdverb("wholeheartedly"),
            new TellHowItHappenedAdverb("wickedly"),
        };

        public static readonly IEnumerable<TellWhereItHappenedAdverb> TellWhereItHappenedAdverbs = new TellWhereItHappenedAdverb[]
        {
            new TellWhereItHappenedAdverb("here"),
            new TellWhereItHappenedAdverb("there"),
            new TellWhereItHappenedAdverb("downstairs"),
            new TellWhereItHappenedAdverb("upstairs"),
            new TellWhereItHappenedAdverb("inside"),
            new TellWhereItHappenedAdverb("outside"),
            new TellWhereItHappenedAdverb("underground"),
            new TellWhereItHappenedAdverb("above"),
            new TellWhereItHappenedAdverb("back"),
            new TellWhereItHappenedAdverb("below"),
            new TellWhereItHappenedAdverb("out"),
        };

        public static readonly IEnumerable<TellWhenItHappenedAdverb> TellWhenItHappenedAdverbs = new TellWhenItHappenedAdverb[]
        {
            new TellWhenItHappenedAdverb("early"),
            new TellWhenItHappenedAdverb("first"),
            new TellWhenItHappenedAdverb("last"),
            new TellWhenItHappenedAdverb("later"),
            new TellWhenItHappenedAdverb("now"),
            new TellWhenItHappenedAdverb("regularly"),
            new TellWhenItHappenedAdverb("today"),
            new TellWhenItHappenedAdverb("tomorrow"),
            new TellWhenItHappenedAdverb("yesterday"),
            new TellWhenItHappenedAdverb("already"),
            new TellWhenItHappenedAdverb("immediately"),
            new TellWhenItHappenedAdverb("lately"),
            new TellWhenItHappenedAdverb("recently"),
            new TellWhenItHappenedAdverb("soon"),
        };

        public static readonly IEnumerable<TellTheExtentOfTheActionAdverb> TellTheExtentOfTheActionAdverbs = new TellTheExtentOfTheActionAdverb[]
        {
            new TellTheExtentOfTheActionAdverb("almost"),
            new TellTheExtentOfTheActionAdverb("also"),
            new TellTheExtentOfTheActionAdverb("enough"),
            new TellTheExtentOfTheActionAdverb("only"),
            new TellTheExtentOfTheActionAdverb("quite"),
            new TellTheExtentOfTheActionAdverb("rather"),
            new TellTheExtentOfTheActionAdverb("so"),
            new TellTheExtentOfTheActionAdverb("too"),
            new TellTheExtentOfTheActionAdverb("very"),
            new TellTheExtentOfTheActionAdverb("hardly"),
            new TellTheExtentOfTheActionAdverb("just"),
            new TellTheExtentOfTheActionAdverb("nearly"),
        };

        public static readonly IEnumerable<IntensifierAdverb> IntensifierAdverbs = new IntensifierAdverb[]
        {
            new IntensifierAdverb("literally"),
            new IntensifierAdverb("simply"),
            new IntensifierAdverb("really"),
            new IntensifierAdverb("sure"),
            new IntensifierAdverb("completely"),
            new IntensifierAdverb("heartily"),
            new IntensifierAdverb("totally"),
            new IntensifierAdverb("absolutely"),
            new IntensifierAdverb("somewhat"),
            new IntensifierAdverb("mildly"),
        };

        public static readonly IEnumerable<FrequencyAdverb> FrequencyAdverbs = new FrequencyAdverb[]
        {
            new FrequencyAdverb("again"),
            new FrequencyAdverb("always"),
            new FrequencyAdverb("every"),
            new FrequencyAdverb("never"),
            new FrequencyAdverb("normally"),
            new FrequencyAdverb("rarely"),
            new FrequencyAdverb("seldom"),
            new FrequencyAdverb("usually"),
        };

        #endregion

        #region Pronouns

        public static readonly IEnumerable<SubjectPronoun> SubjectPronouns = new SubjectPronoun[]
        {
            new SubjectPronoun("i"),
            new SubjectPronoun("you"),
            new SubjectPronoun("he"),
            new SubjectPronoun("she"),
            new SubjectPronoun("it"),
            new SubjectPronoun("we"),
            new SubjectPronoun("they"),
        };

        public static readonly IEnumerable<ObjectPronoun> ObjectPronouns = new ObjectPronoun[]
        {
            new ObjectPronoun("me"),
            new ObjectPronoun("him"),
            new ObjectPronoun("us"),
            new ObjectPronoun("them"),
        };

        public static readonly IEnumerable<PossessiveAdjective> PossessiveAdjectives = new PossessiveAdjective[]
        {
            new PossessiveAdjective("my"),
            new PossessiveAdjective("your"),
            new PossessiveAdjective("his"),
            new PossessiveAdjective("her"),
            new PossessiveAdjective("its"),
            new PossessiveAdjective("our"),
            new PossessiveAdjective("their"),
        };

        public static readonly IEnumerable<PossessivePronoun> PossessivePronouns = new PossessivePronoun[]
        {
            new PossessivePronoun("mine"),
            new PossessivePronoun("hers"),
            new PossessivePronoun("ours"),
            new PossessivePronoun("theirs"),
        };

        public static readonly IEnumerable<ReflexivePronoun> ReflexivePronouns = new ReflexivePronoun[]
        {
            new ReflexivePronoun("myself"),
            new ReflexivePronoun("yourself"),
            new ReflexivePronoun("himself"),
            new ReflexivePronoun("herself"),
            new ReflexivePronoun("itself"),
            new ReflexivePronoun("ourselves"),
            new ReflexivePronoun("yourselves"),
            new ReflexivePronoun("themselves"),
        };

        public static readonly IEnumerable<DemonstrativePronoun> DemonstrativePronouns = new DemonstrativePronoun[]
        {
            new DemonstrativePronoun("this"),
            new DemonstrativePronoun("that"),
            new DemonstrativePronoun("these"),
            new DemonstrativePronoun("those"),
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
            new Adjective("other"),
            new Adjective("new"),
            new Adjective("old"),
            new Adjective("big"),
            new Adjective("large"),
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
            new Noun("night"),
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
            new Noun("right"),
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
            new Noun("morning"),
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
            .Concat(Determiners)
            .Concat(IrregularNouns)
            .Concat(Nouns)
            .Concat(IrregularVerbs)
            .Concat(PrimaryVerbs)
            .Concat(ModalVerbs)
            .Concat(Prepositions)
            .Concat(IrregularComparativeAdjectives);

        public static IEnumerable<Word> GetVocabulary(Type typeOfWord)
        {
            dynamic vocabulary = typeOfWord switch
            {
                Type subjectPronoun when subjectPronoun == typeof(SubjectPronoun) => SubjectPronouns,
                Type objectPronoun when objectPronoun == typeof(ObjectPronoun) => ObjectPronouns,
                Type possessiveAdjective when possessiveAdjective == typeof(PossessiveAdjective) => PossessiveAdjectives,
                Type possessivePronoun when possessivePronoun == typeof(PossessivePronoun) => PossessivePronouns,
                Type reflexivePronoun when reflexivePronoun == typeof(ReflexivePronoun) => ReflexivePronouns,
                Type demonstrativePronoun when demonstrativePronoun == typeof(DemonstrativePronoun) => DemonstrativePronouns,
                Type frequencyAdverb when frequencyAdverb == typeof(FrequencyAdverb) => FrequencyAdverbs,
                Type intensifierAdverb when intensifierAdverb == typeof(IntensifierAdverb) => IntensifierAdverbs,
                Type mannerAdverb when mannerAdverb == typeof(MannerAdverb) => MannerAdverbs,
                Type tellHowItHappendAdverb when tellHowItHappendAdverb == typeof(TellHowItHappenedAdverb) => TellHowItHappenedAdverbs,
                Type tellTheExtentOfTheActionAdverb when tellTheExtentOfTheActionAdverb == typeof(TellTheExtentOfTheActionAdverb) => TellTheExtentOfTheActionAdverbs,
                Type tellWhenItHappenedAdverb when tellWhenItHappenedAdverb == typeof(TellWhenItHappenedAdverb) => TellWhenItHappenedAdverbs,
                Type tellWhereItHappenedAdverb when tellWhereItHappenedAdverb == typeof(TellWhereItHappenedAdverb) => TellWhereItHappenedAdverbs,
                Type compound when compound == typeof(Compound) => SomeCompounds.Concat(AnyCompounds).Concat(EveryCompounds).Concat(NoCompounds),
                Type determiner when determiner == typeof(Determiner) => Determiners,
                Type primaryVerb when primaryVerb == typeof(PrimaryVerb) => PrimaryVerbs,
                Type verb when verb == typeof(Verb) => IrregularVerbs,
                Type noun when noun == typeof(Noun) => Nouns.Concat(IrregularNouns),
                Type adjective when adjective == typeof(Adjective) => Adjectives,
                Type modalVerb when modalVerb == typeof(ModalVerb) => ModalVerbs,
                Type preposition when preposition == typeof(Preposition) => Prepositions,
                Type comparisonAdjective when comparisonAdjective == typeof(ComparisonAdjective) => IrregularComparativeAdjectives,
                _ => throw new NotImplementedException(),
            };
            return vocabulary;
        }
    }
}