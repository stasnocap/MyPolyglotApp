using AutoMapper;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.ViewModels;

namespace MyPolyglotWeb.MapperProfiles
{
    public class TestProfile : Profile
    {
        public TestProfile()
        {
            CreateMap<AddExerciseVM, LessonDB>();
        }
    }
}
