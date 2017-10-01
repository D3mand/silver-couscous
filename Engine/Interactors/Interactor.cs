using System.Threading.Tasks;

namespace Engine.Interactors
{
    public interface Interactor<in TRequest, TResponse> where TResponse : class
    {
        TResponse Handle(TRequest request);
    }
}
