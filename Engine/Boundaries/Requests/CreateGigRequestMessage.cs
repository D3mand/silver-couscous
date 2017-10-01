using System;

namespace Engine.Boundaries.Requests
{
    public class CreateGigRequestMessage : RequestMessage
    {
        public CreateGigRequestMessage(int userId, decimal bounty, string label, string description, string pickup, string destination, DateTime date)
        {
            UserId = userId;
            Bounty = bounty;
            Label = label;
            Description = description;
            Pickup = pickup;
            Destination = destination;
            Date = date;
        }

        public int UserId { get; }
        public decimal Bounty { get; }
        public string Label { get; }
        public string Description { get;  }
        public string Pickup { get; }
        public string Destination { get; }
        public DateTime Date { get; }
    }
}