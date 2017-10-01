namespace Engine.Boundaries.Requests
{
    public class CancelGigRequestMessage : RequestMessage
    {
        public CancelGigRequestMessage(string id)
        {
            Id = id;
        }

        public string Id { get; }
    }
}