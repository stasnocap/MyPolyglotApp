using AutoMapper;
using MyPolyglotCore;
using MyPolyglotWeb.Models.DomainModels.Words;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Repositories.IRepository;
using System.Collections.Generic;
using System.Linq;
using System;

namespace MyPolyglotWeb.Presentation
{
    public class AdminPresentation
    {
        public ILessonRepository _lessonRepository;
        public IMapper _mapper;

        public AdminPresentation(ILessonRepository lessonRepository, IMapper mapper)
        {
            _lessonRepository = lessonRepository;
            _mapper = mapper;
        }

        public void AddExercise(AddExerciseVM viewModel)
        {
            var recognizer = new Recognizer(viewModel.EngPhrase);

            var dbModel = new ExerciseDB();

            dbModel.EngPhrase = viewModel.UnrecognizedWords.Select(x => GetCastedDBWord(x)).ToList();


            var a = 1;
        }

        private WordDB GetCastedDBWord(UnrecognizedWordVM word)
        {
            return word.Type switch
            {
                UnrecognizableType.Adjective => new AdjectiveDB() { Text = word.Text },
                UnrecognizableType.Noun => new NounDB() { Text = word.Text },
                UnrecognizableType.Verb => new VerbDB() { Text = word.Text },
                _ => throw new NotSupportedException(),
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
