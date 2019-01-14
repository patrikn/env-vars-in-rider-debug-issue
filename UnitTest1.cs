using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        // Set the environment variable 'TestVar' to value 'TestVal'

        [Fact]
        public void TestShouldFindCapitalised()
        {
            Assert.Equal("TestVal", Environment.GetEnvironmentVariable("TestVar"));
        }

        [Fact]
        public void TestShouldNotFindDowncased()
        {
            Assert.Null(Environment.GetEnvironmentVariable("testvar"));
        }

    }
}
