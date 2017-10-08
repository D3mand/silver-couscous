using Engine.Boundaries;
using Engine.Boundaries.Requests;
using Engine.Boundaries.Responses;
using System.Web.Http;

namespace Engine.Api.Controllers
{
    public class GigController : ApiController
    {
        CreateGigBoundary _createGigBoundary;
        CancelGigBoundary _cancelGigBoundary;
        KickoffGigBoundary _kickoffGigBoundary;
        ProposalGigBoundary _proposalGigBoundary;

        public GigController(
            CreateGigBoundary createGigBoundary, 
            CancelGigBoundary cancelGigBoundary,
            KickoffGigBoundary kickoffGigBoundary,
            ProposalGigBoundary proposalGigBoundary)
        {
            _createGigBoundary = createGigBoundary;
            _cancelGigBoundary = cancelGigBoundary;
            _kickoffGigBoundary = kickoffGigBoundary;
            _proposalGigBoundary = proposalGigBoundary;
        }

        [HttpPost]
        [Route("create")]
        public CreateGigResponseMessage CreateGig([FromBody] CreateGigRequestMessage request)
        {
            return _createGigBoundary.Handle(request);
        }

        [HttpPost]
        [Route("cancel")]
        public CancelGigResponseMessage CancelGig([FromBody] CancelGigRequestMessage request)
        {
            return _cancelGigBoundary.Handle(request);
        }

        [HttpPost]
        [Route("kickoff")]
        public KickoffGigResponseMessage KickoffGig([FromBody] KickoffGigRequestMessage request)
        {
            return _kickoffGigBoundary.Handle(request);
        }

        [HttpPost]
        [Route("propose")]
        public ProposalGigResponseMessage ProposalGig([FromBody] ProposalGigRequestMessage request)
        {
            return _proposalGigBoundary.Handle(request);
        }
    }
}