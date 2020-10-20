using Microsoft.Bot.Schema;

namespace Microsoft.Bot.Builder.TestRunner
{
    public abstract class TestClientBase
    {
        public void SendActivityAsync()
        {
            throw new System.NotImplementedException();
        }

        public void ValidateActivity(Activity expected, Activity actual)
        {
            throw new System.NotImplementedException();
        }

        private void ActivityComparer()
        {
            throw new System.NotImplementedException();
        }
    }
}