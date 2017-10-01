using External.Jacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Engine.Entities;
using Neo4j.Driver.V1;

namespace External.Plugs
{
    public class Neo4JGigRepository : GigRepository
    {   
        public IEnumerable<Gig> Find(string text)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gig> FindAll()
        {
            throw new NotImplementedException();
        }

        public Gig Get(string key)
        {
            throw new NotImplementedException();
        }

        public void Remove(string key)
        {
            throw new NotImplementedException();
        }

        public void Save(Gig entity)
        {
            using (var driver = GraphDatabase.Driver("bolt://localhost:7474", AuthTokens.Basic("neo4j", "neo4j")))
            using (var session = driver.Session())
            {
                session.Run("CREATE (a:Gig {name: {name}, description: {description}, bounty: {bounty}})",
                            new Dictionary<string, object>
                            {
                                { "name", entity.Label },
                                { "description", entity.Description },
                                { "bounty", entity.Bounty}
                            });
                
            }
        }
    }
}
