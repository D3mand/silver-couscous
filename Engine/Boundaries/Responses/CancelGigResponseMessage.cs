namespace Engine.Boundaries.Responses
{
    public class CancelGigResponseMessage
    {
        public CancelGigResponseMessage(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; }
        public string Message { get; }
    }
}
