using AutoMapper;
using MyPolyglotCore;
using MyPolyglotCore.Words;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.DomainModels.DomainWords;
using MyPolyglotWeb.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPolyglotWeb.MapperProfiles
{
    public class WordsProfile : Profile
    {
        public WordsProfile()
        {
            CreateMap<AddExerciseVM, ExerciseDB>()
                .ForMember(nameof(ExerciseDB.EngPhrase), x => x.MapFrom(x => CastUrecognizedWordToDBWord(x)));
        }

        private IEnumerable<WordDB> CastUrecognizedWordToDBWord(AddExerciseVM viewModel)
        {
            var unrecognizedWords = viewModel.UnrecognizedWords.Select(x => CreateWordDBFromUnrecognizedWord(x));
            var recognizedWords = viewModel.RecognizedWords.Select(x => CreatWordDBFormRecognizedWord(x));
            return unrecognizedWords.Concat(recognizedWords);
        }

        private WordDB CreatWordDBFormRecognizedWord(Word word)
        {
            return word.GetType().Name switch
            {
                nameof(Adjective) => new AdjectiveDB() { Text = word.Text },
                nameof(Noun) => new NounDB() { Text = word.Text },
                nameof(Verb) => Vocabulary.IrregularVerbs.FirstOrDefault(x => x.Equals(word)) != null ? CastVerbToVerbDB(word) : CastVerbToVerbDB(word.Text),
                _ => throw new NotImplementedException(),
            }; 
        }

        public WordDB CreateWordDBFromUnrecognizedWord(UnrecognizedWordVM word)
        {
            return word.Type switch
            {
                UnrecognizableType.Adjective => new AdjectiveDB() { Text = word.Text },
                UnrecognizableType.Noun => new NounDB() { Text = word.Text },
                UnrecognizableType.Verb => CastVerbToVerbDB(word.Text),
                _ => throw new NotImplementedException(),
            };
        }

        private VerbDB CastVerbToVerbDB(Word word)
        {
            var verb = word as Verb;
            return InitializeVerbDB(verb);
        }

        private VerbDB CastVerbToVerbDB(string text)
        {
            var verb = new Verb(text);
            return InitializeVerbDB(verb);
        }

        private VerbDB InitializeVerbDB(Verb verb)
        {
            return new VerbDB()
            {
                Text = verb.Text,
                PastForm = verb.PastForm,
                PastParticipleForm = verb.PastParticipleForm,
                PresentParticipleForm = verb.PresentParticipleForm,
                ThirdPersonForm = verb.ThirdPersonForm,
                AdditionalForms = verb.AdditionalForms?.Select(x => new WordDB() { Text = x }).ToList()
            };
        }
    }
}
