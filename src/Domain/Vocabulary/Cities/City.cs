using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.Cities.ValueObjects;

namespace Domain.Vocabulary.Cities;

public sealed class City : BaseWord<CityId>
{
    private City(CityId id, Text text) : base(id, text)
    {
    }

    public static City Create(Text text)
    {
        return new City(CityId.CreateUnique(), text);
    }
}