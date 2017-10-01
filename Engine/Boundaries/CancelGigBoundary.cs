using Engine.Boundaries.Requests;
using Engine.Boundaries.Responses;
using Engine.Interactors;

namespace Engine.Boundaries
{
    public interface CancelGigBoundary : Interactor<CancelGigRequestMessage, CancelGigResponseMessage>
    {
    }
}
