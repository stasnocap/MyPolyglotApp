using Application.Practice.Lessons.Common;
using Contracts.Practice.Lessons;
using Mapster;

namespace Web.Areas.Practice.Common.Mapping;

public class LessonMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<LessonResult, LessonResponse>()
            .Map(dest => dest.Name, src => src.Name.Value)
            .Map(dest => dest.Number, src => src.Number.Value)
            .Map(dest => dest.Rate, src => src.Rate)
            .Map(dest => dest.LessonId, src => src.LessonId.Value);
    }
}