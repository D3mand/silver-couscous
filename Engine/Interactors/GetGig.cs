using Engine.Boundaries;
using External.Jacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Interactors
{
    public class GetGig : GetGigBoundary
    {
        GigRepository _repo;

        public GetGig(GigRepository repo)
        {
            _repo = repo;
        }

        public GetGigResponseMessage Handle(string id)
        {
            var gig = _repo.Get(id);

            return new GetGigResponseMessage
            {
                
            };
        }
    }
}
