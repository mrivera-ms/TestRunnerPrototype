using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Bot.Schema;

namespace Microsoft.Bot.Builder.TestRunner
{
    public class TestRunner
    {
        public TestClientFactory TestClientFactory
        {
            get => default;
            set
            {
            }
        }

        public TranscriptConverter TranscriptConverter
        {
            get => default;
            set
            {
            }
        }

        public TestRunner(TestClientBase client)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Executes a test based on a collection of transcripts in sequence,
        /// in the order in which  they exist in the collection. This method
        /// can be used  to compose a complex scenario formed by a set of smaller
        /// scenarios defined in each transcript.
        /// </summary>
        /// <param name="transcripts">The collection of transcripts to execute.</param>
        public async Task RunTestAsync(IEnumerable<string> transcripts)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Executes a single scenario based on the transcript passed to the method.
        /// </summary>
        /// <param name="transcript">The transcript that contains the scenario to execute.</param>
        /// <returns></returns>
        public async Task RunTestAsync(string transcript)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Executes a scenario utilizing a parameterized transcript.
        /// </summary>
        /// <param name="transcript">A parameterized transcript.</param>
        /// <param name="values">The parameters to passed to the transcript.</param>
        /// <returns></returns>
        public async Task RunTestAsync(string transcript, params string[] values)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets a collection of activities returned by the test bot.
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Activity>> GetActivitiesAsync()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Sends a single Activity to the test bot.
        /// </summary>
        /// <param name="activity">The Activity to send to the bot.</param>
        /// <returns></returns>
        public Task<bool> SendActivityAsync(Activity activity)
        {
            throw new System.NotImplementedException();
        }

        private void ConvertTranscript()
        {
            throw new System.NotImplementedException();
        }


    }
}