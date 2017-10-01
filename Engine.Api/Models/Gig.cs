using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Engine.Api.Models
{
    public class Gig
    {
        public Gig(string label, string description, string pickup, string destination, decimal bounty)
        {
            Label = label;
            Description = description;
            Pickup = pickup;
            Destination = destination;
            Bounty = bounty;
        }

        public string Label { get; }
        public string Description { get; }
        public string Pickup { get; }
        public string Destination { get; }
        public decimal Bounty { get; }
        public DateTime Date { get; set; }
    }
}