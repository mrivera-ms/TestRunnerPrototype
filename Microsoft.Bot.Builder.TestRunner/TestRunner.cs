using System.Collections;
using System.Collections.Generic;

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
        /// Runs a single transcript
        /// </summary>
        /// <param name="transcriptSource"></param>
        public void RunTest(string transcriptSource)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Runs a list of transcripts
        /// </summary>
        /// <param name="transcripts"></param>
        public void RunTest(IEnumerable<string> transcripts)
        {
            throw new System.NotImplementedException();
        }

        private void ConvertTranscript()
        {
            throw new System.NotImplementedException();
        }
    }
}