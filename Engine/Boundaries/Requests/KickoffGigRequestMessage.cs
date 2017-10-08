using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Boundaries.Requests
{
    public class KickoffGigRequestMessage 
    {
        public int GigId { get; set; }
        public int ProposalId { get; set; }
    }
}
