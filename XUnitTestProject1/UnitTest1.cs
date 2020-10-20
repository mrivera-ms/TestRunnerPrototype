using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xunit;
using Microsoft.Bot.Builder.TestRunner;
using Microsoft.Bot.Schema;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private readonly string _transcriptsFolder = Directory.GetCurrentDirectory() + @"TestScripts";

        [Fact]
        public async Task TestSingleScenario()
        {
            var runner = new TestRunner(new TestClientFactory(ClientType.DirectLine).GetTestClient());
            await runner.RunTestAsync(@"EmulatorTranscript1.transcript");
        }

        [Fact]
        public async Task TestParameterizedTranscript()
        {
            string param1 = default;
            string param2 = default;

            var runner = new TestRunner(new TestClientFactory(ClientType.DirectLine).GetTestClient());
            await runner.RunTestAsync(@"EmulatorTranscript1.transcript", param1, param2);
        }

        [Theory]
        [InlineData("Scenario1.transcript")]
        [InlineData("Scenario2.transcript")]
        [InlineData("Scenario3.transcript")]
        [InlineData("Scenario4.transcript")]
        public async Task TestIndependentScenariosInParallel(string transcript)
        {
            var runner = new TestRunner(new TestClientFactory(ClientType.DirectLine).GetTestClient());
            await runner.RunTestAsync(Path.Combine(_transcriptsFolder, transcript));
        }

        [Fact]
        public async Task TestSequentialScenarios()
        {
            var runner = new TestRunner(new TestClientFactory(ClientType.DirectLine).GetTestClient());
            await runner.RunTestAsync(new List<string>()
            {
                @"EmulatorTranscript1.transcript",
                @"EmulatorTranscript2.transcript"
            });
        }

        [Fact]
        public async Task TestComplexScenario()
        {
            //Initialize the TestRunner
            var runner = new TestRunner(new TestClientFactory(ClientType.DirectLine).GetTestClient());

            //Start with two sequential scenarios
            await runner.RunTestAsync(new List<string>()
            {
                @"EmulatorTranscript1.transcript",
                @"EmulatorTranscript2.transcript"
            });

            //Verify some state
            var actual = string.Empty;
            var expected = string.Empty;
            Assert.Equal(expected, actual);

            //Send a single activity
            var response = await runner.SendActivityAsync(new Activity());

            //Get activities
            var activities = await runner.GetActivitiesAsync();

            //Verify the activities
            List<Activity> expectedActivities = null;
            Assert.Equal(expectedActivities, activities);
        }
    }
}
