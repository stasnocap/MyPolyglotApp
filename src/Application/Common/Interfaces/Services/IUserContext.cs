
namespace Application.Common.Interfaces.Services;

public interface IUserContext
{
    Guid? GetCurrentUserId();
}