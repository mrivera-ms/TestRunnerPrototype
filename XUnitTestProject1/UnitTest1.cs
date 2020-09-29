using System;
using System.Collections.Generic;
using Xunit;
using Microsoft.Bot.Builder.TestRunner;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var runner = new TestRunner(new TestClientFactory(ClientType.DirectLine).GetTestClient());
            runner.RunTest(@"EmulatorTranscript1.transcript");

            runner.RunTest(new List<string>()
            {
                @"EmulatorTranscript1.transcript",
                @"EmulatorTranscript2.transcript"
            });
        }
    }
}
