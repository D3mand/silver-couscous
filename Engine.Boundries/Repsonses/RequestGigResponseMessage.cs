namespace Engine.Boundaries.Responses
{
    public class RequestGigResponseMessage
    {
        public RequestGigResponseMessage(string label, string description, string pickup, string destination, decimal bounty, string message, bool success)
        {
            Label = label;
            Description = description;
            Pickup = pickup;
            Destination = destination;
            Bounty = bounty;
            Message = message;
            Success = success;
        }

        public string Label { get; }
        public string Description { get; }
        public string Pickup { get; }
        public string Destination { get; }
        public decimal Bounty { get; }
        public string Message { get; }
        public bool Success { get; }
    }
}