using System;
using System.Collections.Generic;
using System.Linq;
using MyPolyglotCore.Words;
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
        public const string IngEnding = "ing";
        public const string EdEnding = "ed";

        public static readonly IEnumerable<QuestionWord> QuestionWords = new QuestionWord[]
        {
            new QuestionWord("what"),
            new QuestionWord("who"),
            new QuestionWord("where"),
            new QuestionWord("when"),
            new QuestionWord("why"),
            new QuestionWord("how"),
        };

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

        public static readonly IEnumerable<Noun> Nouns = new Noun[]
        {
            new Noun("man"),
            new Noun("mountain"),
            new Noun("state"),
            new Noun("ocean"),
            new Noun("country"),
            new Noun("building"),
            new Noun("cat"),
            new Noun("airline"),
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
            .Concat(SubjectPronouns)
            .Concat(ObjectPronouns)
            .Concat(PossessiveAdjectives)
            .Concat(PossessivePronouns)
            .Concat(ReflexivePronouns)
            .Concat(Determiners)
            .Concat(IrregularVerbs)
            .Concat(PrimaryVerbs)
            .Concat(ModalVerbs);

        public static IEnumerable<Word> GetVocabulary(Type typeOfWord)
        {
            dynamic vocabulary = typeOfWord switch
            {
                Type subjectPronoun when subjectPronoun == typeof(SubjectPronoun) => SubjectPronouns,
                Type objectPronoun when objectPronoun == typeof(ObjectPronoun) => ObjectPronouns,
                Type possessiveAdjective when possessiveAdjective == typeof(PossessiveAdjective) => PossessiveAdjectives,
                Type possessivePronoun when possessivePronoun == typeof(PossessivePronoun) => PossessivePronouns,
                Type reflexivePronoun when reflexivePronoun == typeof(ReflexivePronoun) => ReflexivePronouns,
                Type determiner when determiner == typeof(Determiner) => Determiners,
                Type primaryVerb when primaryVerb == typeof(PrimaryVerb) => PrimaryVerbs,
                Type verb when verb == typeof(Verb) => IrregularVerbs,
                Type noun when noun == typeof(Noun) => Nouns,
                Type adjective when adjective == typeof(Adjective) => Adjectives,
                Type modalVerb when modalVerb == typeof(ModalVerb) => ModalVerbs,
                _ => throw new NotImplementedException(),
            };
            return vocabulary;
        }
    }
}