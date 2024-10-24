using Application.Vocabulary.Adjectives.Common;
using Application.Vocabulary.Adjectives.Queries.GetAdjectives;
using Contracts.Vocabulary.Adjectives.Requests;
using Contracts.Vocabulary.Adjectives.Responses;
using Mapster;

namespace Web.Areas.Vocabulary.Common.Mapping;

public class AdjectiveMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<GetAdjectivesRequest, GetAdjectivesQuery>()
            .Map(dest => dest.Page, src => src.PageNumber);
        
        config.NewConfig<AdjectiveResult, AdjectiveResponse>()
            .Map(dest => dest.Id, src => src.Id.Value)
            .Map(dest => dest.Text, src => src.Text.Value);
    }
}