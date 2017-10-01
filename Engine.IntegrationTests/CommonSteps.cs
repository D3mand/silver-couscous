using Engine.Boundaries;
using Engine.Boundaries.Requests;
using Engine.Entities;
using Ninject;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Engine.IntegrationTests
{
    [Binding]
    public class CommonSteps
    {
        [Given(@"the following Gig")]
        public void GivenTheFollowingGig(Table table)
        {
            var request = table.CreateInstance<CreateGigRequestMessage>();
            var createGigBoundary = SpecFlowExtensions.Kernel.Get<CreateGigBoundary>();
            createGigBoundary.Handle(request);
        }
        
        [Then(@"I should see the following gig in the database")]
        public void ThenIShouldSeeTheFollowingGigInTheDatabase(Table table)
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
