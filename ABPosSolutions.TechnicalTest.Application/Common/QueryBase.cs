using ABPosSolutions.TechnicalTest.Domain.Common;
using MediatR;

namespace ABPosSolutions.TechnicalTest.Application.Common
{
    public abstract class QueryBase<TResult> : IRequest<TResult>, IBaseRequest where TResult : class
    {
    }

    public abstract class QueryBase : IRequest, IRequest<Unit>, IBaseRequest { }
}
