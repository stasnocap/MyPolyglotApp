using AutoMapper;
using MyPolyglotCore;
using MyPolyglotWeb.Models.DomainModels.DomainWords;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Repositories.IRepository;
using System.Collections.Generic;
using System.Linq;
using MyPolyglotWeb.Repositories.IRepository.IRepositoryWords;

namespace MyPolyglotWeb.Presentation
{
    public class AdminPresentation
    {
        public IExerciseRepository _exerciseRepository;
        public IVerbRepository _verbRepository;
        public INounRepository _nounRepository;
        public IAdjectiveRepository _adjectiveRepository;
        public IMapper _mapper;

        public AdminPresentation(IMapper mapper,
            IExerciseRepository exerciseRepository,
            INounRepository nounRepository,
            IVerbRepository verbRepository,
            IAdjectiveRepository adjectiveRepository)
        {
            _mapper = mapper;
            _exerciseRepository = exerciseRepository;
            _nounRepository = nounRepository;
            _verbRepository = verbRepository;
            _adjectiveRepository = adjectiveRepository;
        }

        public void AddExercise(AddExerciseVM viewModel)
        {
            var recognizer = new Recognizer(viewModel.EngPhrase);
            recognizer.Recognize();

            viewModel.RecognizedWords = recognizer.RecognizedWords;

            var exerciseDB = _mapper.Map<ExerciseDB>(viewModel);

            foreach (var word in exerciseDB.EngPhrase)
            {
                SaveWord(word);
            }
        }

        private void SaveWord(WordDB word)
        {
            switch (word)
            {
                case VerbDB v:
                    _verbRepository.Save(v);
                    break;
                case NounDB n:
                    _nounRepository.Save(n);
                    break;
                case AdjectiveDB a:
                    _adjectiveRepository.Save(a);
                    break;
                default:
                    break;
            }
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
