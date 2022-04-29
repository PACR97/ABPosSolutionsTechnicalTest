using ABPosSolutions.TechnicalTest.Domain.Common;
using MediatR;

namespace ABPosSolutions.TechnicalTest.Application.Common
{
    public abstract class CommandBase<TResult> : IRequest<TResult>, IBaseRequest where TResult : class 
    {
    }

    public abstract class CommandBase : IRequest, IRequest<Unit>, IBaseRequest { }
}
