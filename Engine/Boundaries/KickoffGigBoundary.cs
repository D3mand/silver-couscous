using Engine.Boundaries.Responses;
using Engine.Interactors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Boundaries.Requests
{
    public interface KickoffGigBoundary : Interactor<KickoffGigRequestMessage, KickoffGigResponseMessage>
    {
    }
}
