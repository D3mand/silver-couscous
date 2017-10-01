using Engine.Boundaries;
using Engine.Boundaries.Requests;
using Engine.Boundaries.Responses;
using System.Web.Http;

namespace Engine.Api.Controllers
{
    public class GigController : ApiController
    {
        CreateGigBoundary _createGigBoundary;

        public GigController(CreateGigBoundary createGigBoundary)
        {
            _createGigBoundary = createGigBoundary;
        }

        [HttpPost]
        [Route("create")]
        public CreateGigResponseMessage CreateGig([FromBody] CreateGigRequestMessage request)
        {
            return _createGigBoundary.Handle(request);
        }
    }
}