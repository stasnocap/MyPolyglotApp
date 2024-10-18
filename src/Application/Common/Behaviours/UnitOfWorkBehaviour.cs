using Application.Common.Interfaces.Persistence;
using ErrorOr;
using MediatR;

namespace Application.Common.Behaviours;

public class UnitOfWorkBehaviour<TRequest, TResponse>(IUnitOfWork _unitOfWork) : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
    where TResponse : IErrorOr
{
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var isCommand = request.GetType().Name.EndsWith("Command");

        if (!isCommand)
        {
            return await next();
        }

        var result = await next();

        if (!result.IsError)
        {
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        return result;
    }
}