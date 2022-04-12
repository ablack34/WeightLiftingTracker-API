using API.SpecflowTests.Contexts;
using System.Text;
using TechTalk.SpecFlow;
using TrackerAPI.Models;

namespace API.SpecflowTests.Hooks
{
    [Binding]
    public class MockData
    {
        private TestExerciseContext _context;

        public MockData(TestExerciseContext context)
        {
            _context = context;
        }

        [BeforeScenario("Update an Exercise by a valid ID and payload")]
        public static void InsertMockData()
        {
            
            


            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping

            //TODO: implement logic that has to run before executing each scenario
        }

        
    }
}