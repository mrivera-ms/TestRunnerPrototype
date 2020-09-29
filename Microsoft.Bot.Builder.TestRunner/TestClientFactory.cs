namespace Microsoft.Bot.Builder.TestRunner
{
    public class TestClientFactory
    {
        public TestClientFactory(ClientType client)
        {
                
        }

        public TestClientBase TestClientBase
        {
            get => default;
            set
            {
            }
        }

        public TestClientBase GetTestClient()
        {
            throw new System.NotImplementedException();
        }
    }
}