
using Engine.Boundaries.Requests;
using Engine.Boundaries.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Boundaries
{
    public interface ProposalGigBoundary : Interactors.Interactor<ProposalGigRequestMessage, ProposalGigResponseMessage>
    {
    }
}
