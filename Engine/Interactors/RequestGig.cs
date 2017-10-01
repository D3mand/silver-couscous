using Engine.Boundaries;
using Engine.Boundaries.Requests;
using Engine.Boundaries.Responses;
using Engine.Entities;
using Engine.Validator;
using External.Jacks;

namespace Engine.Interactors
{
    /// <summary>
    /// Use Case: Request New Gig
    /// Description: User requests to create a new gig
    /// Steps:
    /// 1. Validate request message
    /// 2. Setup new Gig
    /// 3. Save Gig
    /// </summary>
    public class RequestGig : RequestGigBoundary
    {
        GigRepository _repo;
        Validator<CreateGigRequestMessage> _validator;

        public RequestGig(GigRepository repo, Validator<CreateGigRequestMessage> validator)
        {
            _repo = repo;
            _validator = validator;
        }

        public CreateGigResponseMessage Handle(CreateGigRequestMessage request)
        {
            if (!_validator.Validate(request))
            {
                return new CreateGigResponseMessage(request.Label,
                    request.Description,
                    request.Pickup,
                    request.Destination,
                    request.Bounty,
                    $"Validation failed for request",
                    false);
            };

            var gig = new Gig(request.Label, request.Description, request.Pickup, request.Destination, request.Bounty);                     

            _repo.Save(gig);

            var response = new CreateGigResponseMessage(gig.Label,
                gig.Description,
                request.Pickup,
                request.Destination,
                request.Bounty,
                "Success",
                true);

            return response;  
        }
    }
}
