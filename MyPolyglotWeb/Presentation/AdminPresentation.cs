using AutoMapper;
using MyPolyglotCore;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Repositories.IRepository;
using System.Collections.Generic;
using System.Linq;

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

        public void AddExercise(AddViewModel viewModel)
        {
            var recognizer = new Recognizer(viewModel.EngPhrase);

        }

        public IEnumerable<UnrecognizedWord> GetUnrecognizedWords(string engPhrase)
        {
            var recognizer = new Recognizer(engPhrase);
            recognizer.Recognize();

            var unrecognizedWords = recognizer.UnrecognizedWords
                .Select(x => new UnrecognizedWord() { Text = x.Text });

            return unrecognizedWords;
        }
    }
}
