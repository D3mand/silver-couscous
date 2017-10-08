namespace Engine.Boundaries.Requests
{
    public class CancelGigRequestMessage 
    {
        public CancelGigRequestMessage(string id)
        {
            Id = id;
        }

        public string Id { get; }
    }
}