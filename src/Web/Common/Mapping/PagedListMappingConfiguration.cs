using Application.Common;
using Mapster;

namespace Web.Common.Mapping;

public class PagedListMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig(typeof(PagedList<>), typeof(Contracts.Common.PagedList<>)).MapToConstructor(true);
    }
}