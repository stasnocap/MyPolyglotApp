using AutoMapper;
using MyPolyglotCore;
using MyPolyglotWeb.Models.DomainModels.Words;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Repositories.IRepository;
using System.Collections.Generic;
using System.Linq;
using System;
using MyPolyglotCore.Words;

namespace MyPolyglotWeb.Presentation
{
    public class AdminPresentation
    {
        public IExerciseRepository _exerciseRepository;
        public IMapper _mapper;

        public AdminPresentation(IExerciseRepository exerciseRepository, IMapper mapper)
        {
            _exerciseRepository = exerciseRepository;
            _mapper = mapper;
        }

        public void AddExercise(AddExerciseVM viewModel)
        {
            var recognizer = new Recognizer(viewModel.EngPhrase);
            recognizer.Recognize();

            viewModel.RecognizedWords = recognizer.RecognizedWords;

            var dbModel = _mapper.Map<ExerciseDB>(viewModel);

            _exerciseRepository.Save(dbModel);
        }

        private WordDB CastCoreWordToDBWord(Word word)
        {
            return word.GetType().Name switch
            {
                "Adjective" => new AdjectiveDB() { Text = word.Text },
                "Noun" => new NounDB() { Text = word.Text },
                "Verb" => _mapper.Map<WordDB>(new Verb(word.Text)),
                _ => throw new NotImplementedException(),
            };
        }

        public IEnumerable<UnrecognizedWordVM> GetUnrecognizedWords(string engPhrase)
        {
            var recognizer = new Recognizer(engPhrase);
            recognizer.Recognize();

            var unrecognizedWords = recognizer.UnrecognizedWords
                .Select(x => new UnrecognizedWordVM() { Text = x.Text });

            return unrecognizedWords;
        }
    }
}
