using AutoMapper;
using MyPolyglotCore.Words;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.DomainModels.Words;
using MyPolyglotWeb.Models.ViewModels;
using System.Linq;

namespace MyPolyglotWeb.MapperProfiles
{
    public class WordsProfile : Profile
    {
        public WordsProfile()
        {
            CreateMap<AddExerciseVM, ExerciseDB>()
                .ForMember(nameof(ExerciseDB.EngPhrase), x => x.Ignore());
            //.ForMember(nameof(ExerciseDB.EngPhrase), x => x.MapFrom(x => x.EngPhrase));

            CreateMap<UnrecognizedWordVM, WordDB>();

            CreateMap<Verb, VerbDB>();
            //.ForMember(nameof(VerbDB.AdditionalForms), x => x.MapFrom(x =>
            //    x.AdditionalForms.Select(x => new WordDB() { Text = x })));


        }
    }
}
