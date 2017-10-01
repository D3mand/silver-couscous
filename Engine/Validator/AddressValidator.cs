using System;

namespace Engine.Validator
{
    public class AddressValidator : Validator<string>
    {
        public override bool Validate(string address)
        {
            return !string.IsNullOrWhiteSpace(address);
        }
    }
}
