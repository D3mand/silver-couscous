using External.Jacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Engine.Entities;
using Neo4j.Driver.V1;
using System.Text;

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
        public void Update(Gig entity)
        {

        }

        public void Insert(Gig entity)
        {
            using (var driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "fred2607"), new Config { EncryptionLevel = EncryptionLevel.None }))
            using (var session = driver.Session())
            {

                StringBuilder builder = new StringBuilder();
                builder.AppendLine("MATCH (user:User {id: {userid}})");
                builder.AppendLine(@"CREATE (gig:Gig {
                                            name: {name}, 
                                            description: {description}, 
                                            bounty: {bounty}})");
                builder.AppendLine("MERGE(user)-[:CREATED]->(gig)");

                session.Run(builder.ToString(),
                            new Dictionary<string, object>
                            {
                                { "userid", entity.CreatedByUserId },
                                { "name", entity.Label },
                                { "description", entity.Description },
                                { "bounty", entity.Bounty }
                            });
            }
        }
    }
}
