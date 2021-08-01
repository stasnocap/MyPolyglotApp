using AutoMapper;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.DomainModels.Words;
using MyPolyglotWeb.Models.ViewModels;

namespace MyPolyglotWeb.MapperProfiles
{
    public class TestProfile : Profile
    {
        public TestProfile()
        {
            CreateMap<AddExerciseVM, ExerciseDB>();
            //.ForMember(nameof(ExerciseDB.EngPhrase), x => x.MapFrom(x => x.EngPhrase));

            CreateMap<UnrecognizedWordVM, WordDB>();

        }
    }
}
