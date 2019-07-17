using ClassLibrary1;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void AboveLegalAgeTest()
        {
            int testAge = 19;
            bool result = Class1.IsLegalVotingAge(testAge);

            Assert.True(result);
        }

        [Fact]
        public void BelowLegalAgeTest()
        {
            int testAge = 11;
            bool result = Class1.IsLegalVotingAge(testAge);

            Assert.False(result);
        }
    }
}
