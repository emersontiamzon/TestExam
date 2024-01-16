using System.Threading;
using System.Threading.Tasks;

namespace Sprout.Exam.Common.Service
{
    public interface IHandlerAsync<TRequest, TResponse>
    where TRequest : class
    where TResponse : class
    {
        Task<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken = default);
    }
}
