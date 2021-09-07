using Exercise01;
using System.Numerics;
using Xunit;

namespace PrivacyTests
{
    public class Exercise01Test
    {
        [Fact]
        public void TestDescriber()
        {
            string eighteenM = BigInteger.Parse("18456002032011000007").Towards();
            Assert.Equal("eighteen quintillion, four hundred and fifty-six quadrillion, two trillion, thirty-two billion, eleven million, and seven", eighteenM)
;
        }

        [Fact]
        public void TestDescriberNegative()
        {
            string eighteenM = ((BigInteger)(-18001000)).Towards();
            Assert.Equal("negative eighteen million, one thousand", eighteenM)
;
        }

        [Fact]
        public void TestDescriberZero()
        {
            string eighteenM = ((BigInteger)(0)).Towards();
            Assert.Equal("zero", eighteenM)
;
        }
    }
}
