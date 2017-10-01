using Engine.Boundaries;
using Engine.Boundaries.Requests;
using Engine.Boundaries.Responses;
using Engine.Validator;
using External.Jacks;

namespace Engine.Actions
{
    public class CancelGig : CancelGigBoundary
    {
        GigRepository _gigRepository;
        Validator<CancelGigRequestMessage> _validator;

        public CancelGig(GigRepository gigRepository, Validator<CancelGigRequestMessage> validator)
        {
            _gigRepository = gigRepository;
            _validator = validator;
        }

        public CancelGigResponseMessage Handle(CancelGigRequestMessage request)
        {
            if (!_validator.Validate(request))
            {
                return new CancelGigResponseMessage(false, $"Validation failed for request");
            }

            _gigRepository.Remove(request.Id);

            return new CancelGigResponseMessage(true, $"Gig {request.Id} - deleted"); ;
        }
    }
}
