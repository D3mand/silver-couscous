using Engine.Boundaries;
using Engine.Boundaries.Requests;

namespace Engine.Validator
{
    public class CreateGigValidator: Validator<CreateGigRequestMessage>
    {
        AddressValidator addressValidator = new AddressValidator();

        public override bool Validate(CreateGigRequestMessage request)
        {
            IsValid = request.Bounty >= decimal.Zero &&
                !string.IsNullOrWhiteSpace(request.Label) &&
                !string.IsNullOrWhiteSpace(request.Description) &&
                addressValidator.Validate(request.Pickup) &&
                addressValidator.Validate(request.Destination);

            return IsValid;
        }     
    }
}
