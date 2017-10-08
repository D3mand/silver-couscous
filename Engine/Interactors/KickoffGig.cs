using Engine.Boundaries.Requests;
using Engine.Boundaries.Responses;
using Engine.Interactors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Boundaries
{
    public class KickoffGig : KickoffGigBoundary
    {
        public KickoffGigResponseMessage Handle(KickoffGigRequestMessage request)
        {
            return new KickoffGigResponseMessage();
        }
    }
}
