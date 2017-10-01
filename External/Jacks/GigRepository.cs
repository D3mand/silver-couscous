
using Engine.Entities;
using System.Collections.Generic;

namespace External.Jacks
{
    public interface GigRepository : RepositoryJack<Gig, string>
    {
        IEnumerable<Gig> FindAll();
        IEnumerable<Gig> Find(string text);
    }
}
