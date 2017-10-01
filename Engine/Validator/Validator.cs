using System;
using Engine.Boundaries;

namespace Engine.Validator
{
    public abstract class Validator<T>
    {
        public bool IsValid { get; set; }
        public string Message { get; set; }
        public abstract bool Validate(T request);
    }
}
