using System;

namespace Engine.Boundaries.Requests
{
    public class CreateGigRequestMessage 
    {
        //public CreateGigRequestMessage(int userId, decimal bounty, string label, string description, string pickup, string destination, DateTime date)
        //{
        //    UserId = userId;
        //    Bounty = bounty;
        //    Label = label;
        //    Description = description;
        //    Pickup = pickup;
        //    Destination = destination;
        //    Date = date;
        //}

        public int UserId { get; set; }
        public decimal Bounty { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public string Pickup { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }
    }
}